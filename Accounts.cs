using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic9
{
    public class Accounts
    {
        String PIN, lastTransaction, accountNumber;
        int Balance;

        public Accounts(String p, String an, int b)
        {
            PIN = p;
            accountNumber = an;
            Balance = b;
        }

        public virtual Boolean checkPin(String a,String p)
        {
            if (accountNumber.ToLower().Equals(a.ToLower()) == false)
                return false;

            if (PIN.ToLower().Equals(p.ToLower()))
                return true;
            else return false;

        }

        public virtual int getBalance()
        {
            return Balance;
        }

        public void updateBalance(int updatedBalane) { Balance = updatedBalane; }

        public virtual Boolean withdraw(int amount)
        {
            if (amount > Balance) return false;
            lastTransaction = "Balance was = " + Balance + "\nAmount withdrawn = " + amount;
            Balance -= amount;
            lastTransaction += "\nFinal balance = " + Balance;
            return true;
        }

        public virtual String getLastTransaction()
        {
            if (lastTransaction == null)
                return "No transactions!";
            return lastTransaction;
        }

        public void updateLastTransaction (String updatedLastTransaction)
        {
            lastTransaction = updatedLastTransaction;
        }
    }
}
