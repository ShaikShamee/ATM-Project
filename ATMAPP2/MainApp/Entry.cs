using ATMAPP2.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMAPP2.MainApp
{
   public class Entry
    {
        static void Main(string[] args)
        {
            while (true)
            {
                AppScreen.Welcome();
                ATMApp atmApp = new ATMApp();
                atmApp.InitializeData();
                atmApp.CheckUserCardNumAndPassword();
                atmApp.Welcome();
            }
        }
    }
}
