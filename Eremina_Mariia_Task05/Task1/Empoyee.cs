using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Employee : User
    {
        private int workLength;
        private string standing;

        public Employee(string fN, string lN, string frName, DateTime date, int wLength, string stand) : base(fN, lN, frName, date)
        {
            WorkLength = wLength;
            standing = stand;
        }

        public override string ToString()
        {
            string userString = ("ФИО:" + lastName + firstName + fatherName + 
                "/n" + "Дата рождения: " + bd.ToShortDateString() + 
                "/n" + "Возраст: " + Age + "/n" + "Должность: " + standing + 
                "/n" + "Стаж: " + workLength);
            return userString;
        }

        public int WorkLength
        {
            get { return workLength; }
            set
            {
                if (value <= (Age - 18))
                {
                    if (value >= 0) workLength = value;
                    else throw new Exception("Negative length of work");
                }
                else throw new ArgumentException("Too long work experience for such short life");
            }
        }
        public string Standing
        {
            get { return standing; }
            set
            {
                if (Age >= 18)
                {
                    if (!(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))) standing = value;
                    else throw new ArgumentException("No position");
                }
                else throw new ArgumentException("Illegal");
            }
        }

    }
}
