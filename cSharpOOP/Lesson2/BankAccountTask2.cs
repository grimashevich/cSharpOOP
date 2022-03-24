using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class BankAccountTask2: BankAccountTask1
    {
        private static protected ulong _lastAccountID = 10000000;

        public void SetAccountAutoID() {this._id = _lastAccountID++;}
        public override void SetId(ulong id) { this.SetAccountAutoID(); }
    }
}
