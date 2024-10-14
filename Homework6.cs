namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(salary_amount:9000);

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(salary_amount:8000);

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1. classEnroll = "Java";
        s1.SetGrade(newGrade:90);

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2. classEnroll = "Math";
        s2.SetGrade(newGrade:80);
        
        //Q2
        Console.WriteLine($"Professor {p1.profName} teaches {p1.classTeach}, and the salary is: {p1.GetSalary()}");
        Console.WriteLine($"Professor {p2.profName} teaches {p2.classTeach}, and the salary is: {p2.GetSalary()}");
        Console.WriteLine($"Student {s1.studentName} enrolls {s1.classEnroll}, and the grade is: {s1.GetGrade()}");
        Console.WriteLine($"Student {s2.studentName} enrolls {s2.classEnroll}, and the grade is: {s2.GetGrade()}");
        double p3 = p1.GetSalary() - p2.GetSalary();
        double s3 = s1.GetGrade() + s2.GetGrade();
        Console.WriteLine($"The salary difference between Alice and Bob is: {p3}");
        Console.WriteLine($"The total grade of Lisa and Tom is: {s3}");

    }
}


// Professor.cs
class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
    }
}

//Student

class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
}