// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements
	
var Name_Names = new Array("��վ����","��վ����","��վ�ؼ���","��վ����","����","LOGO��ַ","��վ��ʶGUID","��Ȩ��Ϣ");
var Name_Values = new Array("web_name","web_host","keyword","Description","title","logo","GUID","Copyright");
var Name;
var TAG = "";

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
	Name = new ListControl('Name');
	Name.setAll(Name_Names,Name_Values);
  }

  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
   
 TAG += '<CMS:WebConfig ';
	  
  if (Name && Name.get() != ""){
		TAG += ' Name="' + Name.getValue() + '"';
  }
  
  TAG += ' runat=server  />';

  gDialogShown = false; // Reset show dialog global.

  return TAG;
}

//---------------    LOCAL FUNCTIONS   ---------------



function initializeUI()
{
  // set UI Globals
		Name = new ListControl('Name');
	Name.setAll(Name_Names,Name_Values);
  Name.focus();
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
