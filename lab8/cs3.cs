using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    
    public struct Birthday
    {
        
        private DateTime _birthdate;

        public Birthday(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public string GetDayOfWeek()
        {
            return _birthdate.ToString("dddd");
        }

        public string GetDayOfWeekInYear(int year)
        {
            DateTime nextBirthday = _birthdate.AddYears(year - _birthdate.Year);
            return nextBirthday.ToString("dddd");
        }

        public int GetDaysUntilBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = _birthdate.AddYears(today.Year - _birthdate.Year);
            if (nextBirthday < today)
                nextBirthday = nextBirthday.AddYears(1);
            return (nextBirthday - today).Days;
        }
    }
    internal class cs3
    {
        public static void task_3()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Birthday bday = new Birthday(new DateTime(2006, 1, 3));
            Console.WriteLine(bday.GetDayOfWeek()); 
            Console.WriteLine(bday.GetDayOfWeekInYear(2024)); 
            Console.WriteLine(bday.GetDaysUntilBirthday()); 
        }
    }
}
