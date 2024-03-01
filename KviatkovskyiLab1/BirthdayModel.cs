using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Kviatkovskyi Andrii

namespace KviatkovskyiLab1
{
    internal class BirthdayModel
    {
        private DateTime _birthdate;
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

     
        public int Age()
        {
            DateTime current = DateTime.Now;
            int age = current.Year - _birthdate.Year;

            if (current.Month < _birthdate.Month || (current.Month == _birthdate.Month && current.Day < _birthdate.Day))
            {
                age--;
            }

            return age;
        }

        public bool IsBirthday()
        {
            DateTime current = DateTime.Now;
            return (current.Month == _birthdate.Month && current.Day == _birthdate.Day);
        }



        public string ZodiacWestern()
        {
            DateTime[] zodiacDates = new DateTime[]
            {
                new DateTime(_birthdate.Year, 1, 20),      // Aquarius
                new DateTime(_birthdate.Year, 2, 19),      // Pisces
                new DateTime(_birthdate.Year, 3, 21),      // Aries
                new DateTime(_birthdate.Year, 4, 20),      // Taurus
                new DateTime(_birthdate.Year, 5, 21),      // Gemini
                new DateTime(_birthdate.Year, 6, 21),      // Cancer
                new DateTime(_birthdate.Year, 7, 23),      // Leo
                new DateTime(_birthdate.Year, 8, 23),      // Virgo
                new DateTime(_birthdate.Year, 9, 23),      // Libra
                new DateTime(_birthdate.Year, 10, 23),     // Scorpio
                new DateTime(_birthdate.Year, 11, 22),     // Sagittarius
                new DateTime(_birthdate.Year, 12, 22),     // Capricorn

            };

            string[] zodiacSigns = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius"};

            for (int i = 0; i < zodiacDates.Length; i++)
            {
                if (_birthdate < zodiacDates[i]) return zodiacSigns[i];
            }

            return zodiacSigns[0];
        }

        public string ZodiacChinese()
        {
            int yearInCycle = _birthdate.Year % 12;

            string[] zodiacSigns = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"};

            return zodiacSigns[yearInCycle];
        }
    }
}
