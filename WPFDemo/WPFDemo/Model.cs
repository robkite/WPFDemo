using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo
{
    public static class Model
    {
        public static List<Person> GetAllPeople()
        {
            return new List<Person>()
            {
                new Person("Rob", "Kite", new DateTime(1989, 11, 16), GenderE.Male),
                new Person("Beth", "Furbey", new DateTime(1995, 8, 18), GenderE.Female),
                new Person("Bob", "Smith", new DateTime(1969, 10, 5), GenderE.Male),
                new Person("Jane", "Pearson", new DateTime(1976, 1, 24), GenderE.Female),
                new Person("Rachel", "Jefferson", new DateTime(1997, 6, 13), GenderE.Female),
                new Person("John", "Jewers", new DateTime(1992, 3, 24), GenderE.Male)
            };
        }
    }
}
