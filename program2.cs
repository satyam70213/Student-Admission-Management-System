using System;

//==================== Interface ====================
// Interface defines the payroll methods.
interface IPayroll
{
    void CalculateSalary();
    void Display();
}

//==================== Base Class ====================
class Employee : IPayroll
{
    // Static variable for auto-generating Employee ID
    static int id = 1000;

    // Protected members can be accessed in derived classes
    protected int EmpId;
    protected string Name;
    protected double Basic, HRA, DA, Bonus, PF, Tax, Gross, Net;

    // Constructor
    public Employee()
    {
        EmpId = ++id;
    }

    // Method to take employee details
    public void GetDetails()
    {
        Console.Write("Enter Employee Name : ");
        Name = Console.ReadLine();

        Console.Write("Enter Basic Salary : ");
        Basic = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Bonus : ");
        Bonus = Convert.ToDouble(Console.ReadLine());
    }

    // Virtual method (Runtime Polymorphism)
    public virtual void CalculateSalary()
    {
        HRA = Basic * 0.20;
        DA = Basic * 0.10;
        PF = Basic * 0.12;
        Tax = Basic * 0.10;

        Gross = Basic + HRA + DA + Bonus;
        Net = Gross - PF - Tax;
    }

    // Display Payroll Slip
    public void Display()
    {
        Console.WriteLine("\n========== PAYROLL SLIP ==========");
        Console.WriteLine("Employee ID : " + EmpId);
        Console.WriteLine("Employee Name : " + Name);
        Console.WriteLine("Basic Salary : " + Basic);
        Console.WriteLine("HRA : " + HRA);
        Console.WriteLine("DA : " + DA);
        Console.WriteLine("Bonus : " + Bonus);
        Console.WriteLine("Gross Salary : " + Gross);
        Console.WriteLine("PF : " + PF);
        Console.WriteLine("Tax : " + Tax);
        Console.WriteLine("Net Salary : " + Net);
    }
}

//==================== Derived Class ====================
// Inheritance
class FullTimeEmployee : Employee
{
    // Method Overriding (Polymorphism)
    public override void CalculateSalary()
    {
        HRA = Basic * 0.25;
        DA = Basic * 0.15;
        PF = Basic * 0.12;
        Tax = Basic * 0.10;

        Gross = Basic + HRA + DA + Bonus;
        Net = Gross - PF - Tax;
    }
}

//==================== Derived Class ====================
class PartTimeEmployee : Employee
{
    // Method Overriding (Polymorphism)
    public override void CalculateSalary()
    {
        HRA = Basic * 0.10;
        DA = Basic * 0.05;
        PF = Basic * 0.05;
        Tax = Basic * 0.05;

        Gross = Basic + HRA + DA + Bonus;
        Net = Gross - PF -Tax;
    }
}

//==================== Main Class ====================
class Program
{
    static void Main()
    {
        Employee emp;     // Parent class reference (Polymorphism)

        Console.WriteLine("===== Employee Payroll System =====");
        Console.WriteLine("1. Full Time Employee");
        Console.WriteLine("2. Part Time Employee");

        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Runtime Polymorphism
        if (choice == 1)
            emp = new FullTimeEmployee();
        else
            emp = new PartTimeEmployee();

        emp.GetDetails();
        emp.CalculateSalary();
        emp.Display();
    }
}