using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagerLibrary
{
    public class ProfileModel
    {
        public List<Account> Accounts { get; set; } = new List<Account>();
        public string ProfileName { get; set; }

    }
}
