using System;

namespace HelloWorldApp{

class Employee{

    int Id;
    string Name;
    string Department;
    float Salary;
    string Gender;

    public void AcceptDetails(){
        Console.WriteLine("Enter Employees Details");
        Console.WriteLine("Enter Employees Id:"); 
        Id = Convert.ToInt32(Console.ReadLine());
        // Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Employees Name:");
        Name = Console.ReadLine();
        Console.WriteLine("Enter Employees Department:");
        Department = Console.ReadLine();
        Console.WriteLine("Enter Employees Salary:");
        Salary = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Employees Gender:");
        Gender = Console.ReadLine();
    }

    public void DisplayDetails(){
        Console.WriteLine("Employee Details Are: ");

        Console.WriteLine($"Employee Id is {Id}");

        Console.WriteLine($"Employee Name is {Name}");

        Console.WriteLine($"Employee Department is {Department}");

        Console.WriteLine($"Employee Salary is {Salary}");

        Console.WriteLine($"Employee Gender is {Gender}");


    }
}
}