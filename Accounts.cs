using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic9
{
    public class Accounts
    {
        String PIN, lastTransaction;
        int Balance;

        public Accounts(String p, int b)
        {
            PIN = p;
            Balance = b;
        }

        public Boolean checkPin(String p)
        {
            if (PIN.ToLower().Equals(p.ToLower()))
                return true;
            else return false;

        }

        public int getBalance()
        {
            return Balance;
        }

        public Boolean withdraw(int amount)
        {
            if (amount > Balance) return false;
            lastTransaction = "Balance was = " + Balance + "\nAmount withdrawn = " + amount;
            Balance -= amount;
            lastTransaction += "\nFinal balance = " + Balance;
            return true;
        }

        public String getLastTransaction()
        {
            if (lastTransaction == null)
                return "No transactions!";
            return lastTransaction;
        }
    }
}
