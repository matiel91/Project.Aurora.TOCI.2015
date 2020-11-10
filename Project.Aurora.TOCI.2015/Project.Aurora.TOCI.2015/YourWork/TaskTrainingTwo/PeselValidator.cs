using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.YourWork.TaskTrainingTwo
{
    public abstract class PeselValidator
    {
        protected abstract string CutOffDate(string pesel);

        protected abstract bool Checksum(string pesel);

        protected abstract bool ValidateDate(int year, int month, int day);

        public abstract string GetNick();

        // cut, checksum, validate
        public abstract bool IsPeselValid(string pesel);
    }
}
