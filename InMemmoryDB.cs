using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin
{
    internal static class InMemmoryDB
    {
        public static List<Person> people = new List<Person>();
      
          
      
        private static readonly string Path = "Person.txt";


        public static void SaveToFile ()
        {
            var MyFile = JsonConvert.SerializeObject(people);
            File.WriteAllText(Path, MyFile);
        }
        public static void LoadFile()
        {
            
            var ReadFile =  File.ReadAllText(Path);

            people = JsonConvert.DeserializeObject<List<Person>>(ReadFile);



            
        }

    }
}
