using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    class Program
    {
        class Company
        {
            private string Name;
            private string Location;
            private string City;
            private string Offering;

            public void SetName(string name)
            {
                this.Name = name;
            }
            public void SetLocation(string location)
            {
                this.Location = location;
            }
            public void SetOffering(string offering)
            {
                this.Name = offering;
            }
            public string GetName()
            {
                return this.Name;
            }
            public string GetLocation()
            {
                return this.Location;
            }
            public string GetOffering()
            {
                return this.Offering;
            }
            public void GetCompanyDetails()
            {
                string noc = "Elev8";
                SetName(noc);
                Console.WriteLine("Name of company: " + noc);
                Console.WriteLine($"Name of company: {noc}");//string interpolation
            }
        }
        class Person : Company
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public void DisplayPersonInfo() 
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
            }
        }
        class Employees : Person
        {
            public Employees(Person p, double salary)
            {
                this.Name = p.Name;
                this.Age = p.Age;
                this.Gender = p.Gender;
                this.Salary = salary;
            }
            public double Salary { get; set; }
            public void DisplayEmployeeInfo()
            {
                base.DisplayPersonInfo();
                Console.WriteLine($"Salary: {Salary}");
            }
        }
        class Customer : Person
        {

        }
        public interface IShapes
        {
            double CalculateArea();
            double CalculatePerimeter();
            double CalculateVolume();
        }
        public class Square : IShapes
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public double CalculateArea()
            {
                return Length * Width;
            }

            public double CalculatePerimeter()
            {
                return (Length + Width) * 2;
            }

            public double CalculateVolume()
            {
                return Math.Pow(Length, 3);
            }
        }
        public class Rectangle : IShapes
        {
            public double Length { get; set; }
            public double Height { get; set; }
            public double Width { get; set; }
            public double CalculateArea()
            {
                return Length * Width;
            }

            public double CalculatePerimeter()
            {
                return (Length + Width) * 2;
            }

            public double CalculateVolume()
            {
                return Length * Height * Width;
            }
        }
        abstract class PersonSlim
        {
            public string Name { get; set; }
            public abstract void DisplayPersonSlimInfo();
        }
        class EmployeeSlim : PersonSlim
        {
            public DateTime DateOfEmployment { get; set; }
            public EmployeeSlim(string name, DateTime date)
            {
                Name = name;
                DateOfEmployment = date;
            }
            public override void DisplayPersonSlimInfo()
            {
                Console.WriteLine($"Name: {Name}, Date Of Employment: {DateOfEmployment}");
            }
        }

        static void Main(string[] args)
        {
            Company company = new Company();
            company.GetCompanyDetails();

            Person person = new Person();
            person.Name = "Emma";
            person.Age = 26;
            person.Gender = "Female";


            Employees employee = new Employees(person, 15012.53);
            employee.DisplayEmployeeInfo();

            Square square = new Square();
            square.Length = 10;
            square.Width = 20;
            Console.WriteLine($"Square's Area: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}, Volume: {square.CalculateVolume()}");

            Rectangle rectangle = new Rectangle();
            rectangle.Length = 10;
            rectangle.Width = 20;
            rectangle.Height = 5;
            Console.WriteLine($"Rectangle's Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}, Volume: {rectangle.CalculateVolume()}");

            EmployeeSlim employeeSlim = new EmployeeSlim("İbrahim", DateTime.UtcNow);
            employeeSlim.DisplayPersonSlimInfo();

            Console.ReadLine();
        }
    }
}
