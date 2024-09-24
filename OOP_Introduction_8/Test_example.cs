using System;

namespace SchoolHierarchy
{
    // Base class: School
    class School
    {
        public string Name { get; set; }
        public string Principal { get; set; }
        public int StudentCount { get; set; }

        // Constructor
        public School(string name, string principal, int studentCount)
        {
            Name = name;
            Principal = principal;
            StudentCount = studentCount;
        }

        // Method to display school details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"School Name: {Name}");
            Console.WriteLine($"Principal: {Principal}");
            Console.WriteLine($"Student Count: {StudentCount}");
        }
    }

    // Derived class: MiddleSchool
    class MiddleSchool : School
    {
        public int LowestGrade { get; set; }
        public int HighestGrade { get; set; }

        // Constructor
        public MiddleSchool(string name, string principal, int studentCount, int lowestGrade, int highestGrade)
            : base(name, principal, studentCount)
        {
            LowestGrade = lowestGrade;
            HighestGrade = highestGrade;
        }

        // Method to display middle school details
        public override void DisplayDetails()
        {
            base.DisplayDetails();  // Call the base class method
            Console.WriteLine($"Lowest Grade: {LowestGrade}");
            Console.WriteLine($"Highest Grade: {HighestGrade}");
        }
    }

    // Derived class: HighSchool
    class HighSchool : School
    {
        public string SportsFieldName { get; set; }

        // Constructor
        public HighSchool(string name, string principal, int studentCount, string sportsFieldName)
            : base(name, principal, studentCount)
        {
            SportsFieldName = sportsFieldName;
        }

        // Method to display high school details
        public override void DisplayDetails()
        {
            base.DisplayDetails();  // Call the base class method
            Console.WriteLine($"Sports Field Name: {SportsFieldName}");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Create a MiddleSchool object
            MiddleSchool middleSchool = new MiddleSchool("Green Valley Middle School", "Ms. Johnson", 500, 6, 8);
            Console.WriteLine("Middle School Details:");
            middleSchool.DisplayDetails();

            Console.WriteLine();

            // Create a HighSchool object
            HighSchool highSchool = new HighSchool("Springfield High School", "Mr. Smith", 800, "Eagle Stadium");
            Console.WriteLine("High School Details:");
            highSchool.DisplayDetails();

            Console.ReadLine();  // Wait for input to keep the console window open
        }
    }
}
