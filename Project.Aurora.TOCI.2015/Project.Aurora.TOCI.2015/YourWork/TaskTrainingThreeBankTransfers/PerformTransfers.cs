using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.YourWork.TaskTrainingThreeBankTransfers
{
    public abstract class PerformTransfers
    {
        protected abstract List<BankTransfersParser> GetAllParsers();

        protected abstract List<TransferHandle> GetAllHandles();

        public virtual void TransferAll()
        {
            var parsers = GetAllParsers();
            var handles = GetAllHandles();

            foreach (var parser in parsers)
            {
                var transfers = parser.GetBankTransfers();

                foreach (var transfer in transfers)
                {
                    foreach (var handle in handles)
                    {
                        handle.SendTransfer(transfer);
                    }
                }

                //odp ktore sie powiodly
            }
        }
    }
}
