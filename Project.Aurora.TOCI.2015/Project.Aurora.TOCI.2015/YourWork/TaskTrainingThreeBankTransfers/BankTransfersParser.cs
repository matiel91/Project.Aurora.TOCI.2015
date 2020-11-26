using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.YourWork.TaskTrainingThreeBankTransfers
{
    public abstract class BankTransfersParser
    {
        protected FileOperation BankFileOperation;

        // wczytac plik do stringu
        // rozbic string na linie
        // linie przetworzyc GetTransferEntry na typ BankTransfer
        public abstract List<BankTransfer> GetBankTransfers();


        protected abstract BankTransfer GetTransferEntry(string entry);
    }
}
