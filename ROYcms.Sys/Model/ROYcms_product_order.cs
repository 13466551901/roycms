using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ROYcms_product_order:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class ROYcms_product_order
	{
		public ROYcms_product_order()
		{}
		#region Model
		private int _id;
		private string _order_id;
		private string _user_id;
		private string _order_status;
		private decimal? _order_price;
		private string _order_payment;
		private string _order_rec_name;
		private string _order_rec_address;
		private string _order_rec_code;
		private string _order_rec_phone;
		private string _order_rec_tel;
		private string _order_shipping;
		private decimal? _order_freight;
		private string _order_deliverytime;
		private DateTime? _create_time;
		private bool? _ifdefault;
		/// <summary>
		/// ���
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string order_id
		{
			set{ _order_id=value;}
			get{return _order_id;}
		}
		/// <summary>
		/// �û�id
		/// </summary>
		public string user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// ����״̬
		/// </summary>
		public string order_status
		{
			set{ _order_status=value;}
			get{return _order_status;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public decimal? order_price
		{
			set{ _order_price=value;}
			get{return _order_price;}
		}
		/// <summary>
		/// ���� ���ʽ
		/// </summary>
		public string order_payment
		{
			set{ _order_payment=value;}
			get{return _order_payment;}
		}
		/// <summary>
		/// �ջ���
		/// </summary>
		public string order_rec_name
		{
			set{ _order_rec_name=value;}
			get{return _order_rec_name;}
		}
		/// <summary>
		/// �ջ��˵�ַ
		/// </summary>
		public string order_rec_address
		{
			set{ _order_rec_address=value;}
			get{return _order_rec_address;}
		}
		/// <summary>
		/// �ջ����ʱ�
		/// </summary>
		public string order_rec_code
		{
			set{ _order_rec_code=value;}
			get{return _order_rec_code;}
		}
		/// <summary>
		/// �ջ��˵绰
		/// </summary>
		public string order_rec_phone
		{
			set{ _order_rec_phone=value;}
			get{return _order_rec_phone;}
		}
		/// <summary>
		/// �ջ����ֻ�
		/// </summary>
		public string order_rec_tel
		{
			set{ _order_rec_tel=value;}
			get{return _order_rec_tel;}
		}
		/// <summary>
		/// ���ͷ�ʽ
		/// </summary>
		public string order_shipping
		{
			set{ _order_shipping=value;}
			get{return _order_shipping;}
		}
		/// <summary>
		/// �˷�
		/// </summary>
		public decimal? order_freight
		{
			set{ _order_freight=value;}
			get{return _order_freight;}
		}
		/// <summary>
		/// ��������ʱ��
		/// </summary>
		public string order_deliveryTime
		{
			set{ _order_deliverytime=value;}
			get{return _order_deliverytime;}
		}
		/// <summary>
		/// ʱ��
		/// </summary>
		public DateTime? create_time
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// ��ʶ
		/// </summary>
		public bool? ifdefault
		{
			set{ _ifdefault=value;}
			get{return _ifdefault;}
		}
		#endregion Model

	}
}

