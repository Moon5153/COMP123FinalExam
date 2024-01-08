using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Final
{
    public class People
    {
        List<Person> _people = new List<Person>();
        public int Count { get { return _people.Count; } }
        public void Add(Person person)
        {
            _people.Add(person);
        }
        public void Clear()
        {
            _people.Clear();
        }
        public IEnumerable<Person>GetAllPeople()
        {
            return _people;
        }
        public IEnumerable<Person> GetAndroidPeople()
        {
            return _people.Where(x => x.MobileType ==MobileType.Android).ToList();
        }
        public IEnumerable<Person> GetApplePeople()
        {
            return _people.Where(x => x.MobileType == MobileType.Apple).ToList();
        }


    }
}
