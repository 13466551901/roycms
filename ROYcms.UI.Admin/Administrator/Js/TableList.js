/*ȫѡ*/
function CheckAll(form)
  {
  for (var i=0;i<form.elements.length;i++)
    {
    var e = form.elements[i];
    if (e.Name != "chkAll"&&e.disabled==false)
       e.checked = form.chkAll.checked;
    }
}

function topCheckAll(form)
  {
  for (var i=0;i<form.elements.length;i++)
    {
    var e = form.elements[i];
	 if (e.Name != "topchkAll"&&e.disabled==false)
       e.checked = form.topchkAll.checked;
    }
}
/*�����¼�*/
function Click(id)
{
    var e= $('#tr'+id).find('input[type=checkbox]:first-child').attr('checked');
	if(e==true)
	{   
	    $('#tr'+id).toggleClass("CheckOut");/*������class����*/
		$('#tr'+id).find('input[type=checkbox]:first-child').attr('checked','false');
	}
	else if(e==false)
	{ 
	    $('#tr'+id).toggleClass("Check");/*������class����*/
	    $('#tr'+id).find('input[type=checkbox]:first-child').attr('checked','true');
	}
}
/*��꾭��*/
function MouseMove(id)
{
	$('#tr'+id).toggleClass("Check");/*������class����*/
}
/*����뿪*/
function MouseDown(id)
{
	$('#tr'+id).toggleClass("CheckOut");/*������class����*/
}

 /*��ѡ��Ԫ���ɫ*/
function chkRow(obj){
var r = obj.parentElement.parentElement;
if(obj.checked){ r.style.backgroundColor="#92C9D9";}
else {if(r.rowIndex%2==1)r.style.backgroundColor="";else r.style.backgroundColor="#f4fbff";}
}