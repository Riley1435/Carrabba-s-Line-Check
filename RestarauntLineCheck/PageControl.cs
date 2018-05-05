using System;
using System.Windows.Forms;
//
//Extends the tab control class to hide tabs during program runtime
//allows for a unique UX within a Windown Form Application.
//
namespace RestarauntLineCheck
{ 
   
   class PageControl : TabControl
   {
      protected override void WndProc(ref Message m)
      {
         if (m.Msg == 0x1328 && !DesignMode)
         {
            m.Result = (IntPtr)1;
         }
         else
         {
            base.WndProc(ref m);
         }
      }
   }
}