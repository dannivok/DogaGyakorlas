using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogaGyakorlas
{
    internal class Member
    {
        private string _name;
        private int _age;
        private bool _isStudent;
        private int _visits;

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public bool IsStudent { get { return _isStudent; } }

        public int Visits { get { return _visits; } }

        public Member(string name, int age, bool isStudent)
        {
            _name = name;
            _age = age;
            _isStudent = isStudent;
            _visits = 0;
        }


        public void CheckIn()
        {
            _visits++;
        }

        public string Describe()
        {
            string tipus = _isStudent ? "diák" : "normál";
            return $"{_name} ({_age} éves, {tipus}) - {_visits} látogatás";
        }

    }
}
