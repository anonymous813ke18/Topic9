using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic9
{
    class BasicAccount : Accounts
    {
        int overdraftAllowed = 10000;
        int overdraftValue = 0;

        String PIN, lastTransaction, accountNumber;
        int Balance;

        public BasicAccount(string p, string an, int b) : base(p, an, b)
        {
            PIN = p;
            accountNumber = an;
            Balance = b;
        }

        public override bool withdraw(int amount)
        {
            if (amount < Balance)
                return base.withdraw(amount);
            else
            {
                overdraftValue = amount - Balance;
                if (overdraftValue > overdraftAllowed)
                {
                    MessageBox.Show("Overdraft limit exceeded.");
                    return false;
                }                    
                else
                {
                    overdraftAllowed -= overdraftValue;
                    lastTransaction = "Balance was = " + Balance + "\nAmount withdrawn = " + amount+"\nOverdraft = "+overdraftValue;
                    Balance = 0;
                    lastTransaction += "\nFinal Balance = " + Balance;
                    base.updateBalance(Balance);
                    base.updateLastTransaction(lastTransaction);
                    MessageBox.Show("Overdraft = " + overdraftValue);
                    return true;
                }

            }
        }
        public override int getBalance()
        {
            return base.getBalance();
            
        }
    }
}
