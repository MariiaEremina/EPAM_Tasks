using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Employee : User, IEquatable<Employee>
    {
        private int workLength;
        private string standing;

        public Employee(string fN, string lN, string frName, DateTime date, int wLength, string stand) : base(fN, lN, frName, date)
        {
            WorkLength = wLength;
            standing = stand;
        }

        public new void Print()
        {
            Console.WriteLine("ФИО: {0} {1} {2}", lastName, firstName, fatherName);
            Console.WriteLine("Дата рождения: " + bd.ToShortDateString());
            Console.WriteLine("Возраст: " + Age());
            Console.WriteLine("Должность: " + standing);
            Console.WriteLine("Стаж: " + workLength);

        }

        public bool Equals (Employee employee)
        {
            if ((lastName.Equals(employee.lastName)) &&
                (firstName.Equals(employee.firstName))&&
                (fatherName.Equals(employee.fatherName))&&
                (Age().Equals(employee.Age()))&&
                (standing.Equals(employee.standing))&&
                (workLength.Equals(employee.workLength))
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int WorkLength
        {
            get { return workLength; }
            set
            {
                if (value <= (Age() - 18))
                {
                    if (value >= 0) workLength = value;
                    else throw new Exception("Negative length of work");
                }
                else throw new Exception("Too long work experience for such short life");
            }
        }
        public string Standing
        {
            get { return standing; }
            set {
                if (Age() >= 18)
                {
                    if (!(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))) standing = value;
                    else throw new Exception("No position");
                }
                else throw new Exception("Illegal");
            }
        }

    }
}
