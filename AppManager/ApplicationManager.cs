using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace AddressbookTestsAutoit
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";

        private AutoItX3 aux;
        private   GroupHelper groupHelper;
        
        public ApplicationManager()
        {
            aux = new AutoItX3();
            aux.Run(@"C:\AddressBookWinows\AddressBook.exe", "",aux.SW_SHOW);
            aux.WinWait(WINTITLE);
            aux.WinActivate(WINTITLE);
            aux.WinActive(WINTITLE);

            groupHelper = new GroupHelper(this);
        }

        public AutoItX3 Aux
        {
            get 
            {
                return aux;
            
            }
        
        }
        public void Stop()
        {
            //window name, text of the button (not mandatory),  button id(locator) 
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.62e44910");
        }

        public GroupHelper Groups
        {
            get
            { 
                return groupHelper; 
            }
        }
    }

  
}
