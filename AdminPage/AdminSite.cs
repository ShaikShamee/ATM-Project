using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPage
{
    public class AdminSite
    {
        public string UserName { get; set; }
        public string passwordd { get; set; }

        public void ShowMainPage()
        {
            Console.WriteLine("welcome to the AdminSite:" + UserName);
        }


    }
}
