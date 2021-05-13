using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace studenstProject
{
    public enum Gender { MALE, FEMALE };

    public class studentsDetails
    {

        public int ID { get; set; }
        public int tz { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDay { get; set; }
        public Gender gender { get; set; }
        public DateTime dateOfRegistration { get; set; }

        public studentsDetails()
        {
        }

        public studentsDetails(int iD, int tz, string firstName, string lastName, DateTime birthDay, Gender gender, DateTime dateOfRegistration)
        {
            ID = iD;
            this.tz = tz;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDay = birthDay;
            this.gender = gender;
            this.dateOfRegistration = dateOfRegistration;
        }
    }
    public class students
    {
        public static readonly ReadOnlyCollection<studentsDetails> studenstList = new ReadOnlyCollection<studentsDetails>(new[]
        {
            new studentsDetails(){ID=1 , tz= 212121222,firstName="Racheli",lastName="shalom",birthDay=DateTime.Now,gender=Gender.FEMALE,dateOfRegistration=DateTime.Now.AddYears(1)},
            new studentsDetails(){ID=2 , tz= 309586245,firstName="Yaeli",lastName="Abarjel",birthDay=DateTime.Now,gender=Gender.MALE,dateOfRegistration=DateTime.Now.AddYears(1)},
            new studentsDetails(){ID=3 , tz= 215286357,firstName="Shulamit",lastName="Gavra",birthDay=DateTime.Now,gender=Gender.FEMALE,dateOfRegistration=DateTime.Now.AddYears(1)},
            new studentsDetails(){ID=4 , tz= 305689758,firstName="Chani",lastName="Dopelt",birthDay=DateTime.Now,gender=Gender.FEMALE,dateOfRegistration=DateTime.Now.AddYears(1)},
            new studentsDetails(){ID=5 , tz= 315246895,firstName="Chavi",lastName="Zilber",birthDay=DateTime.Now,gender=Gender.MALE,dateOfRegistration=DateTime.Now.AddYears(1)},
            new studentsDetails(){ID=6 , tz= 254869355,firstName="Michal",lastName="Israel",birthDay=DateTime.Now,gender=Gender.FEMALE,dateOfRegistration=DateTime.Now.AddYears(1)},
            new studentsDetails(){ID=7 , tz= 245863595,firstName="Nachama",lastName="Levi",birthDay=DateTime.Now,gender=Gender.FEMALE,dateOfRegistration=DateTime.Now.AddYears(1)},
            new studentsDetails(){ID=8 , tz= 258645829,firstName="Tamar",lastName="Madmon",birthDay=DateTime.Now,gender=Gender.MALE,dateOfRegistration=DateTime.Now.AddYears(1)},
            new studentsDetails(){ID=9 , tz= 311255486,firstName="Avigail",lastName="Mondrer",birthDay=DateTime.Now,gender=Gender.FEMALE,dateOfRegistration=DateTime.Now.AddYears(1)},
            new studentsDetails(){ID=10 , tz=212121554,firstName="Nechama",lastName="Felman",birthDay=DateTime.Now,gender=Gender.MALE,dateOfRegistration=DateTime.Now.AddYears(1)},
        });
    }
}

