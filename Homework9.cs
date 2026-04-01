using System.Configuration.Assemblies;

public class Student
{
    private int studentID;
    private string studentName;

    // List storing student info
    public static List<Student> studentList = new List<Student>();

    // Constructor
    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;

        // Append student to list
        studentList.Add(this);
    }

    // Print student info
    public void PrintInfo()
    {
        Console.WriteLine($"ID: {studentID}, Name: {studentName}");
    }

    // Retreiving student name
    public string GetName()
    {
        return studentName;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating Students
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        Console.WriteLine("All Students:");
        foreach (Student s in Student.studentList)
        {
            s.PrintInfo();
        }

        // Gradebook
        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
          {"Alice", 4.0},
          {"Bob", 3.6},
          {"Cathy", 2.5},
          {"David", 1.8},
        };

        // Check if Tom exists
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        // Average GPA
        double totalGPA = 0;
        foreach (var entry in gradebook)
        {
            totalGPA += entry.Value;
        }

        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"Average GPA: {averageGPA:F2}");

        // Students with GPA higher than the average
        Console.WriteLine("Students with GPA above average:");

        foreach (Student s in Student.studentList)
        {
            string name = s.GetName();

            if (gradebook.ContainsKey(name) && gradebook[name] > averageGPA)
            {
                s.PrintInfo();
                Console.WriteLine($"GPA: {gradebook[name]}");
            }
        }
    }
}
