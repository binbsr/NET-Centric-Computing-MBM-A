using System;

namespace EnumsAndProperties
{
    internal class Person
    {
        private byte age;
        private int grade;
        public string name;
        public string address;
        public DateTime dob;

        //getter-setter
        public byte Age
        {
            get { return age; }
            set
            {
                if (value >= 30 && value <= 40)
                {
                    age = value;
                }
            }
        }

        //auto implemented properties
        public string Address { get; set; }

        //read only
        public string Name { get; }
    }
}