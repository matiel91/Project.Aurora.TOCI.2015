using Project.Aurora.TOCI._2015.YourWork.TaskTrainingThreeBankTransfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.LINQ_JoinTraining
{
    public class BasicPlayWithLinq
    {
        Dictionary<string, string> FirstLinqDictionary2 = new Dictionary<string, string>
        {
            {"301020123123123","Mateusz" },
            {"1210501231231312","Ewa" },
            {"3210303123131231312","Florian " },
            {"1050","mBank" },
            {"1060","mBank" },
        };
        Dictionary<string, string> FirstLinqDictionary = new Dictionary<string, string>
        {
            {"1020","PKO" },
            {"1030","Ing" },
            {"1040","mBank" },
            {"1050","mBank" },
            {"1060","mBank" },
        };
        public class Terminator
        {
            public string Code { get; set; }
            public string Name { get; set; }

            public Terminator(string code, string name)
            {
                Code = code;
                Name = name;
            }
        }
        public void RunLinqRound1()
        {
            var chosenBanks = FirstLinqDictionary.Where(item => item.Key == "1020");
            var chesenBansarray = chosenBanks.ToArray();

            var testForSelect = FirstLinqDictionary.Where(item => item.Value == "mBank").Select(item => string.Format("{0} to kod banku {1}", item.Key, item.Value));
            var listaCzegokolwiekZSelectem = FirstLinqDictionary.Where(item => item.Value == "mBank").Select(x => new Terminator(x.Key, x.Value));

            FirstLinqDictionary.Add("1070", "mBank");

            var dlugoscListy = testForSelect.ToArray().Length;
        }
        public void RunLinqDefferedExecution()
        {
            IEnumerable<int> tablica = new int[] { 2, 3, 4, 6, 2, 5 };
            var lista = tablica.ToList();

            int[] tabOfInts = { 1, 2, 3, 1, 2, 4, 3 };
            int Sum = tabOfInts.Sum();

            var result = lista.Where(item => item == 3);

            lista.Add(3);
            lista.Add(3);
            lista.Add(3);
            lista.Add(3);
            lista.Add(3);
            lista.Add(3);

            var icoteraz = result.ToArray();
            var ileElemWIcoTeraz = icoteraz.Length;
        }

        public void JoinExcersize()
        {
            Dictionary<string, string> klienci = new Dictionary<string, string>
        {
            {"3010201231231232","Mateusz" },
            {"1210501231231312","Ewa" },
            {"3210303123131231","Florian " },
            {"3210501231231312","Daria" },
            {"1210403123123132","Michal" },
        };
            Dictionary<string, string> banki = new Dictionary<string, string>
        {
            {"1020","PKO" },
            {"1030","Ing" },
            {"1040","mBank" },
             
        };
            banki.Add("1060", "bzwbk");
            // nr konta, nazwa banku, klient
            //TODO to samo ale do obiektu Klient z property

            var wynik = klienci.Join(
                banki,
                klienciSelector => klienciSelector.Key.Substring(2, 4),
                bankiSelector => bankiSelector.Key,
                (klient, bank) => new BankTransfer { AccountNumber = klient.Key, BankName = bank.Value, BankCode = bank.Key, ClientName = klient.Value });
            
            var wynik2 = klienci.Join(
                banki,
                klienciSelector => klienciSelector.Key.Substring(2, 3),
                bankiSelector => bankiSelector.Key.Substring(0, 3),
                (klient, bank) => new BankTransfer { AccountNumber = klient.Key, BankName = bank.Value, BankCode = bank.Key, ClientName = klient.Value });

        }

        public void Linqexcersize()
        {
            List<Person> personalList = new List<Person>
            {
                new Person()
                {
                    Name = "Waclaw",
                    Age = 16,
                },
                new Person()
                {
                    Name = "Tomasz",
                    Age = 15,
                },
                new Person()
                {
                    Name = "Roman",
                    Age = 17,
                },

            };

            var wynik = personalList.Min(x => x.CompareTo(x.Age));
            

        }
        
        


    }

    public class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
