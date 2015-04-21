  function clickDiv() {
       if (__doPostBack) {
           __doPostBack('<%=btnNew.UniqueID %>', '');
       }
       else {
           var theForm = document.forms['aspnetForm'];
           if (!theForm) {
               theForm = document.aspnetForm;
           }
           if (!theForm.onsubmit || (theForm.onsubmit() != false)) {
               theForm.__EVENTTARGET.value = '<%=btnNew.UniqueID %>';
               theForm.__EVENTARGUMENT.value = '';
               theForm.submit();
           }
       }
   }