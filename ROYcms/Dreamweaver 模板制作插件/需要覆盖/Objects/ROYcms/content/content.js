// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements
			
var Name_Names = new Array("����","����","�ؼ���","����","����ͼ","����","��Դ","ID","����ID","��ǩ","������","�����","����ʱ��");
var Name_Values = new Array("title","contents","keyword","zhaiyao","pic","author","infor","bh","classname","tag","dig","hits","time");
var Name;
var Length;
var TAG = "";

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
	 Length = document.theForm.Length;
	Name = new ListControl('Name');
	Name.setAll(Name_Names,Name_Values);
  }

  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
  
 // <%# ROYcms.Common.input.GetSubString(Eval("title").ToString(),24) %>
	  
  if (Name && Name.get() != ""){
		TAG ='<%#Eval("'+ Name.getValue()+'")%>';
  }
  
  if (Length.value != "" && Name && Name.get() != ""){
      TAG = '<%#ROYcms.Common.input.GetSubString(Eval("'+ Name.getValue()+'").ToString(),'+Length.value+')%>';
      }

  gDialogShown = false; // Reset show dialog global.

  return TAG;
}

//---------------    LOCAL FUNCTIONS   ---------------



function initializeUI()
{
  // set UI Globals
  Length = document.theForm.Length;
		Name = new ListControl('Name');
	Name.setAll(Name_Names,Name_Values);
  Name.focus();
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
