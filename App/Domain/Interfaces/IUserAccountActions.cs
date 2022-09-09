using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Interfaces
{
  public  interface IUserAccountActions
    {
        void CheckBalance();
        void PlaceDeposit();
        void MakeWithDrawal();
    }
}
