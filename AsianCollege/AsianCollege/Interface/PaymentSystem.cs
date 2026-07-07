using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Interface
{
    interface PaymentSystem
    {
        void Pay(int balance);
        void Refund(double balance);
        void GetBalance();
    }

    interface PanIdentification
    {
        void WhopaysAmount(int balance);
        void WhomTransferredAmount(double balance);
    }
}
