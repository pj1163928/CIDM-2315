using System.Dynamic;

namespace Homework6;
class Program
{
    static void Main(string[ ] args)
    {

    //Professors
    Professor prof1 = new Professor("Alice", "Java", 9000);
    Professor prof2 = new Professor("Bob", "Math", 8000);

    //Students
    Student stu1 = new Student("Lisa", "Java", 90);
    Student stu2 = new Student("Tom", "Math", 80);

    //Printing Details

    //Professors
    Console.WriteLine($"Professor {prof1.profName}, teaches {prof1.classTeach}, and their salary is: {prof1.GetSalary()}.");
    Console.WriteLine($"Professor {prof2.profName}, teaches {prof2.classTeach}, and their salary is: {prof2.GetSalary()}.");

    //Student
    Console.WriteLine($"Student {stu1.studentName}, is enrolled in {stu1.classEnroll}, and their grade is: {stu1.GetGrade()}.");
    Console.WriteLine($"Student {stu2.studentName}, is enrolled in {stu2.classEnroll}, and their grade is: {stu2.GetGrade()}.");

    //Salary Differences
    //Determining Salary Difference
    double salaryDiff = Math.Abs(prof1.GetSalary() - prof2.GetSalary());

    //Printing Result
    Console.WriteLine($"The salary difference between Alice and Bob is: {salaryDiff}.");

    //Grades Combined
    //Determining Combined Grade
    double totalGrade = stu1.GetGrade() + stu2.GetGrade();

    //Printing Result
    Console.WriteLine($"The total grade for Lisa and Tom is: {totalGrade}.");
    }
 }


class Professor
{
    //Creating public classes for professor
    public string profName {get; private set;}
    public string classTeach {get; private set;}
    private double salary;

    //Professor
    public Professor(string profName, string classTeach, double salary)
    {
        this.profName = profName;
        this.classTeach = classTeach;
        this.salary = salary; 
    }
    // Creating Salary Value
    public void SetSalary(double salary_amaount)
    {
        this.salary = salary_amaount;
    }
    //Returning Salary Value
    public double GetSalary()
    {
        return salary;
    }
}


class Student
{
    //Creating public classes for student
    public string studentName {get; private set;}
    public string classEnroll {get; private set;}
    private double studentGrade;

    //Student
    public Student(string studentName, string classEnroll, double studentGrade)
    {
        this.studentName = studentName;
        this.classEnroll = classEnroll;
        this.studentGrade = studentGrade;
    }
    //Creating Grade Value
    public void Setgrade(double newGrade)
    {
        this.studentGrade = newGrade;
    }
    //Returning Grade Value
    public double GetGrade()
    {
        return studentGrade;
    }
}
