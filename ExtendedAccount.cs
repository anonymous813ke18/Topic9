using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic9
{
    class ExtendedAccount : Accounts
    {
        public ExtendedAccount(string p, string an, int b) : base(p, an, b)
        {
        }

        public override string queryType()
        {
            return "Extended Account";
        }
    }
}
