using System;

namespace Access_Modifier
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthday(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
