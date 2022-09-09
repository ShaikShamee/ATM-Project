using System;
using System.Collections.Generic;
using System.Text;

namespace App.MainApp
{
   public class Entry
    {
        static void Main(string[] args)
        {
            ATMApp atmApp = new ATMApp();
            atmApp.InitializeData();
            atmApp.Run();
        }
        
    }
}
