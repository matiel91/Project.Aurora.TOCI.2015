using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.YourWork.TaskTrainingTwo
{
    public abstract class GhostRiderStringManipulationsBase
    {
        // true: beata; at, ata, ta, ea
        // false: beata; ae, eb, aa
        protected abstract bool IsStringInString(string subject, string seek);

        // true: beata; aat, taae, aea
        // false: beata; aaa, taaa, tta, aee
        protected abstract bool IsStringElementsInString(string subject, string seek);

        // true: beata; ataeb, aateb, tbaea
        // false: beata; aaateb, fdwgdw
        protected abstract bool IsStringAnagramOfString(string subject, string seek);

        protected abstract string GetNick();

        public abstract StringManipulationsResults RunStringOperations(string subject, string seek);

        protected virtual StringManipulationsResults Run(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();

            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            result.IsStringInString = IsStringInString(subject, seek);

            return result;
        }
    }
}
