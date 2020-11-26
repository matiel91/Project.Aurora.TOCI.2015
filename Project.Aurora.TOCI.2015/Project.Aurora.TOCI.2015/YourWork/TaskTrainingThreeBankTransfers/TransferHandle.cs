using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.YourWork.TaskTrainingThreeBankTransfers
{
    public abstract class TransferHandle
    {
        protected string BankName;

        public bool SendTransfer(BankTransfer transfer)
        {
            return IsMyDestination(transfer) && Send(transfer);
        }

        protected abstract bool Send(BankTransfer transfer); // succesfull true lub false

        protected bool IsMyDestination(BankTransfer transfer)
        {
            return BankName == transfer.DestinationBank;
        }
    }
}
