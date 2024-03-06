    interface IEmployee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
        public double Pay();
    }
class Program
{
    class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        public virtual double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }

    }
    class Executive : Employee
    {
        public string Title { get; set; }
        public int Salary { get; set; }

        public Executive() : base()
        {
            Title = string.Empty;
            Salary = 0;
        }
        public Executive(int id, string firstName, string lastName, string title, int salary)
            : base(id, firstName, lastName)
        {
            Title = title;
            Salary = salary;
        }

        public override double Pay()
        {
            return Salary;
        }
    }
    static void Main(string[] args)
    {
        Employee employee = new Employee(10, "Rory", "Williams");
        Console.WriteLine(employee.Fullname());
        Console.WriteLine(employee.Pay());

        Executive executive = new Executive(12, "Amy", "Pond", "CEO", 100000);
        Console.WriteLine(executive.Fullname());
        Console.WriteLine(executive.Pay());
    }

}