﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ivony.Html;
using Ivony.Fluent;
using Ivony.Html.Parser.ContentModels;

namespace Ivony.Html.Parser
{


  /// <summary>
  /// IHtmlFragment 的实现
  /// </summary>
  public class DomFragment : DomObject, IHtmlFragment, IDomContainer
  {


    /// <summary>
    /// 创建一个 DomFragment 实例
    /// </summary>
    /// <param name="manager">文档碎片管理器</param>
    public DomFragment( DomFragmentManager manager )
    {
      _manager = manager;
      _nodeCollection = new DomNodeCollection( this );
    }


    /// <summary>
    /// 从指定 HTML 创建一个 DomFragment 实例
    /// </summary>
    /// <param name="manager">文档碎片管理器</param>
    /// <param name="html">要分析成碎片的原始 HTML 文本</param>
    public DomFragment( DomFragmentManager manager, string html )
      : this( manager )
    {

      var parser = new FragmentParser();

      parser.ProcessFragment( html, this );

    }


    /// <summary>
    /// 解析 HTML 文本为碎片的 HTML 解析器
    /// </summary>
    protected class FragmentParser : JumonyParser
    {


      /// <summary>
      /// 重写 Parse 方法，抛出 NotSupportedException
      /// </summary>
      /// <param name="html">要解析的 HTML 字符串</param>
      /// <param name="url">文档的 URL</param>
      /// <returns>总是抛出 System.NotSupportedException ，因为此解析器不能用于解析文档</returns>
      public sealed override IHtmlDocument Parse( string html, Uri url )
      {
        throw new NotSupportedException();
      }

      /// <summary>
      /// 解析 HTML 文本到指定的文档碎片对象
      /// </summary>
      /// <param name="html"></param>
      /// <param name="fragment"></param>
      public virtual void ProcessFragment( string html, DomFragment fragment )
      {

        if ( string.IsNullOrEmpty( html ) )
          return;

        lock ( SyncRoot )
        {
          InitializeStack();

          ContainerStack.Push( fragment );

          ParseInternal( html );

          fragment.ContentFragment = new HtmlContentFragment( Reader, 0, Reader.HtmlText.Length );
        }
      }


    }

    private object _sync = new object();
    private DomFragmentManager _manager;
    private DomNodeCollection _nodeCollection;

    /// <summary>
    /// 存放子节点的容器
    /// </summary>
    public DomNodeCollection NodeCollection
    {
      get { return _nodeCollection; }
    }


    /// <summary>
    /// 获取所有的子节点
    /// </summary>
    /// <returns>所有的子节点</returns>
    public IEnumerable<IHtmlNode> Nodes()
    {
      return _nodeCollection.HtmlNodes;
    }


    /// <summary>
    /// 获取所属文档
    /// </summary>
    public override IHtmlDocument Document
    {
      get { return _manager.Document; }
    }


    public DomFragmentManager Manager
    {
      get { return _manager; }
    }



    /// <summary>
    /// 用于同步的对象
    /// </summary>
    public object SyncRoot
    {
      get { return _sync; }
    }






    /// <summary>
    /// 将文本碎片置入文档
    /// </summary>
    /// <param name="container">要置入的容器</param>
    /// <param name="index">置入的位置</param>
    /// <returns>置入后在容器中所产生的节点集</returns>
    public IEnumerable<IHtmlNode> Into( IHtmlContainer container, int index )
    {

      if ( container == null )
        throw new ArgumentNullException( "container" );

      if ( !object.Equals( container.Document, Document ) )
        throw new InvalidOperationException();

      var domContainer = container as IDomContainer;
      if ( domContainer == null )
        throw new InvalidOperationException();

      var modifier = _manager.DomModifier;

      lock ( SyncRoot )
      {
        lock ( modifier.SyncRoot )
        {

          _manager.Allocated( this );


          var nodeList = NodeCollection.ToArray();

          lock ( container.SyncRoot )
          {
            foreach ( var node in nodeList.Reverse() )
            {
              node.Container = null;
              NodeCollection.Remove( node );

              domContainer.NodeCollection.Insert( index, node );

              modifier.OnFragmentInto( this, container, node );
            }
          }


          return nodeList.Cast<IHtmlNode>();
        }
      }
    }
  }




}


