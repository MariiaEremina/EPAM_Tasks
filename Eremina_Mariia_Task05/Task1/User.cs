using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        protected string firstName;
        protected string lastName;
        protected string fatherName;
        protected int age;
        protected DateTime bd;

        public User(string fN, string lN, string frName, DateTime date)
        {
            Name = fN;
            LastName = lN;
            FatherName = frName;
            BD = date;
        }


        public int Age
        {
            get
            {
                if ((bd.Day < DateTime.Today.Day && bd.Month == DateTime.Today.Month) || bd.Month < DateTime.Today.Month)
                {
                    age = DateTime.Today.Year - (bd.Year + 1);
                }
                else
                {
                    age = DateTime.Today.Year - bd.Year;
                }
                return age;
            }
        }

        public override string ToString()
        { 
            string userString = ("ФИО:"+ lastName + firstName + fatherName + "/n" + "Дата рождения: " + bd.ToShortDateString() + "/n" + "Возраст: " + Age);
            return userString;
        }

        public string Name
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!(String.IsNullOrWhiteSpace(value)))
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("No name");
                }
            }
        }


        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string FatherName
        {
            get
            {
                return fatherName;
            }
            set
            {
                fatherName = value;
            }
        }

        public DateTime BD
        {
            get
            {
                return bd;
            }
            set
            {
                if (value.CompareTo(DateTime.Today) >= 0)
                {
                    if (value.Year > (DateTime.Today.Year - 150))
                    {
                        bd = value;
                    }
                    else
                    {
                        throw new ArgumentException("Vampire attack");
                    }
                }
                else
                {
                    throw new ArgumentException("Time travelling");

                }
            }
        }


    }
}