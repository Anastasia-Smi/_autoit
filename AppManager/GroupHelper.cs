using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookTestsAutoit
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base(manager) { }
        public static string GROUPWINTITLE = "Group editor";

        public List<GroupData> GetGroupList()
        {
            List<GroupData> list = new List<GroupData>();
            OpenGroupsDialog();
            string count = aux.ControlTreeView(
                GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51", 
                "GetItemCount", "#0", "");
            for (int i  = 0; i < int.Parse(count); i++)
            {
                string item = aux.ControlTreeView(
                    GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                "GetText", "#0|#"+i, "");
                list.Add(new GroupData()
                {
                    Name = item
                });
            }

            CloseGroupsDialog();
            return list;


        }

        public void Add(GroupData newGroup)
        {
            OpenGroupsDialog();
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            aux.Send(newGroup.Name);
            aux.Send("{ENTER}");
            CloseGroupsDialog();
        }

        public void Remove()
        {
            OpenGroupsDialog();
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.62e4493");
            SelectGroup();
            ClickDeleteGroup();
            DeletingCompletely();
            CloseGroupsDialog();
        }

        private void SelectGroup()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51"); 
        }
                private void ClickDeleteGroup()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d5"); ;
        }

        private void DeletingCompletely()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
        }
        


  

        private void CloseGroupsDialog()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.62e4494");
        }

        private void OpenGroupsDialog()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            aux.WinWait(GROUPWINTITLE);
        }
    }
}

  
