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
        protected DateTime bd;
        DateTime dt = DateTime.Today;

        public User (string fN, string lN, string frName, DateTime date)
        {
            Name = fN;
            LastName = lN;
            FatherName = frName;
            BD = date;
        }
      

        protected int Age()
        {
            int age =0;
            if ((bd.Day < dt.Day && bd.Month == dt.Month) || bd.Month < dt.Month)
                {
                    age = dt.Year - (bd.Year+1);
                }
            else
                { age = dt.Year - bd.Year; }
             
            
            return age;
        }       

        public void Print()
        {
            Console.WriteLine("ФИО: {0} {1} {2}", lastName, firstName, fatherName);
            Console.WriteLine("Дата рождения: " + bd.ToShortDateString());
            Console.WriteLine("Возраст: " + Age());

        }

        public string Name
        {
            get { return firstName; }
            set
            {
                if (!(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))) firstName = value;
                else
                throw new Exception("No name");
            }
        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }

        public DateTime BD
        {
            get { return bd; }
            set {
                if (value.CompareTo(dt) >= 0)
                {
                    if (value.Year > (dt.Year-150)) bd = value; 
                    else throw new Exception("Vampire attack");
                }
                else
                {
                    throw new Exception("Time travelling");

                }
            }
        }


    }
}