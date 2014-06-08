
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassHW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stList = new List<Student> {
         new Student("Kerim", "Krdzevic", "kmkc1511@aubih.edu.ba"),
         new Student("Adis", "Jugo", "asjo1312@aubih.edu.ba"),
         new Student("Nedim", "Kulasin", "nmkn1943@aubih.edu.ba"),
};
            stList.Sort();
            stList.ForEach(student => Console.WriteLine(student.email));

            Console.WriteLine("Press Enter to Exit.");
            Console.ReadLine();
        }
    }

    class Person
    {
        protected string name, lastName;

        protected Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        protected string getPersonInfo()
        {
            return name + ", " + lastName;
        }
    }

    class Student : Person, IComparable<Student>
    {
        public string email { get; set; }
        private string Location;
        private string location
        {
            get
            {
                if (Location == "SA")
                {
                    return "Sarajevo";
                }
                else if (Location == "TZ")
                {
                    return "Tuzla";
                }
                else
                {
                    return "Other";
                }
            }
            set
            {
                if (value == "SA" || value == "SARAJEVO" || value == "Sarajevo")
                {
                    Location = "Sarajevo";
                }
                else if (value == "TZ" || value == "TUZLA" || value == "Tuzla")
                {
                    Location = "Tuzla";
                }
                else
                {
                    Location = "NA";
                }
            }
        }

        public Student()
            : base("Kerim", ";e,oc")
        {
            this.email = "kmkc1511@aubih.edu.ba";
            this.Location = "Sarajevo";
        }

        ~Student()
        {

        }

        public Student(string name, string lastname, string email)
            : base(name, lastname)
        {
            this.email = email;
            this.Location = "Sarajevo";
        }

        public bool setName(string input)
        {
            if (input.Length <= 2)
            {
                Console.WriteLine("Name need to be at least two characters long.");
                return false;
            }

            char[] cArray = input.ToCharArray();
            foreach (char c in cArray)
            {
                if (!char.IsLetter(c))
                {
                    Console.WriteLine("Name must have only letters");
                    return false;
                }
            }

            if (char.IsUpper(cArray[0]))
            {
                Console.WriteLine("Name only can start with uppercase letter");
                return false;
            }

            return true;
        }

        public string getStudentInfo()
        {
            return base.getPersonInfo() + ", " + this.email + ", " + this.Location;
        }

        public override string ToString()
        {
            return getStudentInfo();
        }

        public int CompareTo(Student student)
        {
            return email.CompareTo(student.email);
        }
    }
}

