using System;

namespace Properties
{
    public class Person
    {
        //private DateTime _birthdate;
        // this is created by VS Editor Bulb 'Encaptiolate Field'
        //public DateTime Birthdate { get => _birthdate; set => _birthdate = value; }

        // using Auto-Implementet Propertie the compiler creates a privale
        // field and implements public methods for us
        // if the birthday should only set once we put the private accessor
        // before the set method
        public DateTime Birthdate { get; private set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person(DateTime birtdate)
        {
            Birthdate = birtdate;
        }

        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }



        // using properties instate of methods
        //public void SetBirthday(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}

        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}
    }
}
