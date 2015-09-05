using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassReviewDefiningAClass
{
    class Program   // How to Create a Class 
    {
        static void Main(string[] args)
        // { // Fields - usually set as private. Guard against invalid user input values. 
        //  Properties - Public asscess modifier, so users can manipulate the data. Properites answer to the Fields. For each field you create
        // properites. 
        // Methods - info that you expose to your client. Can be static or non- static. Basic part of a program, take parameters and return values. 
        // Constructors - 

        // Syntax of Fields - Camell case (lower case), Ex: Private, datatype, fieldname(lowercase)
        // Syntax of Properties - have a get : set , Pasquall case Ex: Public, datatype, PropertyName(Uppercase)
        // get { return this.fieldname;} set { this.fieldname = value;}
        // get- takes the field and returns it to the property,is an accessor. Set- sets the value of te field to the property, is accessor. this - refers to the object 
        // that is enstanciated, also is already implied. value - user input, based off the field varible. 
        // Syntax of Methods - Pasqual Case, Can be static or Non static, Can return values, can have parameters. 
        // Ex: Public, static/void/&or datatype, MethodName(pasquelCase) () {}  
        // Can have parameters and arguments. 

        // Syntax of Constructors - 
        {
            Students StudentInfo = new Students();
            StudentInfo.DisplayCompleteInfo();
        }
        public class Students
        {
            private string fullName;  // 1. Feild
            private string subject;
            private string course;
            private string university;
            private string email;
            private double phoneNumber;

            public string FUllName // 2. First property 
            {
                get { return this.fullName; }
                set { this.fullName = value; }
            }

            public string Subject // 2. First property 
            {
                get { return this.subject; }
                set { this.subject = value; }
            }


            public string Course // 2. Second property 
            {
                get { return this.course; }
                set { this.course = value; }
            }

            public string University // 2. Thrid property 
            {
                get { return this.university; }
                set { this.university = value; }
            }

            public string Email // 2. Forth property 
            {
                get { return this.email; }
                set { this.email = value; }
            }
            public double PhoneNumber // 2. Fith property 
            {
                get { return this.phoneNumber; }
                set { this.phoneNumber = value; }
            }

            public Students() // 3. Creating 1st Constructor, 1st one is a Default Constructor() 
            {
                this.FUllName = "Tenecia Aja Guinea";
                this.Course = "Coding for Beginners";
                this.Subject = "Coding";
                this.University = "We CanCodeIt University";
                this.Email = "email@email.com";
                this.PhoneNumber = 2163334444;
            }

            public Students(string Name, string Course) // 3rd Constructor
            {
                this.FUllName = Name;
                this.Course = Course;
            }
            public Students(string Email) // 4th Constructor
            {
                this.email = Email;
            }


            public Students(string Name, string Course, string Subject, string University, string Email, double Phone) // 3. 2nd Constructor
            {
                this.FUllName = Name;
                this.Course = Course;
                this.Subject = Subject;
                this.University = University;
                this.Email = Email;
                this.PhoneNumber = Phone;
            }





            public void DisplayCompleteInfo() // Method
            {
                Console.WriteLine("Student Name:" + this.FUllName + "taking course:" + this.Course + "in Subject:" + this.Subject + "in University:" + this.University + "student can be reached at:" + this.PhoneNumber + "or email" + this.Email);
            }

        }

        public class MobliePhone
        {
            private string model;  // 1. Feild
            private string manufacturer;
            private string price;
            private string owner;
            private string color;
            private double screensize;

            public string Model // 2. 2nd property 
            {
                get { return this.model; }
                set { this.model = value; }
            }

            public string Manufacturer // 2. 3rd property 
            {
                get { return this.manufacturer; }
                set { this.manufacturer = value; }
            }


            public string Price // 2. 4th property 
            {
                get { return this.price; }
                set { this.price = value; }
            }

            public string Owner // 2. 3rd property 
            {
                get { return this.owner; }
                set { this.owner = value; }
            }

            public string Color // 2. 4th property 
            {
                get { return this.color; }
                set { this.color = value; }
            }
            public double Screensize // 2. 5th property 
            {
                get { return this.screensize; }
                set { this.screensize = value; }
            }

        }

    }
}














    



     

        
    

