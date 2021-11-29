using System;
using System.Collections.Generic;
using System.Text;

namespace Vaccination
{
    class Benifier
    {
        private string name { get; set; }
        private long phoneNo { get; set; }
        private string city { get; set; }
        private int age { get; set; }
        public Gender gender { get; set; }
        private int registerId { get; set; }
        





        public Benifier(string Name, long PhoneNo, string City, int Age, Gender Gender1, int RegisterId)
        {
            this.name = Name;
            this.phoneNo = PhoneNo;
            this.city = City;
            this.age = Age;
            this.gender = (Gender)Gender1;
            this.registerId = RegisterId;
            
        }
        public enum Gender
        {
            male,
            female,
            other
        }
        public static string getGender(Gender gen)
        {
            switch(gen)
            {
                case Gender.male:
                    return "male";
                case Gender.female:
                    return "female";
                case Gender.other:
                    return "other";
                default:
                    return "Invalid";

            }
        }
       

    }
}

