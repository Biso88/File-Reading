using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ProjectEx
{
    public class Person
    {

        //private fields
        private string _firsName = "";
        private string _lastName = "";
        private int _age = 0;
        private string _occupation = "";



        //public fields
        public string FirsName { get { return _firsName;} }
        public string LastName { get { return _lastName;} }
        public int Age { get { return _age; } }
        public string Occupation { get { return _occupation;} }



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstname">First name</param>
        /// <param name="lastname">Last name</param>
        /// <param name="age">Age</param>
        /// <param name="occupation">Occupation</param>
        public Person(string firstname, string lastname, int age, string occupation)
        {
            _firsName = firstname;
            _lastName = lastname;
            _age = age;
            _occupation = occupation;
        }

    }
}
