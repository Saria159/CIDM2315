namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222,"Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);
        if(!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom",3.3);
        }
        double totalGPA = 0;
        int countGPA = 0;
        foreach(var gpa in gradebook){
            totalGPA += gpa.Value;
            countGPA++;
        }
        double averageGPA = totalGPA/countGPA;
        Console.WriteLine($"The average GPA of all students: {averageGPA}");
        foreach(var stu in Student.studentList){
            if(gradebook[stu.studentName]>averageGPA){
                stu.PrintInfo();
            }
        }
    }
}
class Student
{
    private int studentID{get;set;}
    public string studentName{get;set;}
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public static List<Student> studentList = new List<Student>();
    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        studentList.Add(this);
    }
}
