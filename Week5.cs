namespace Week5;

class Program
{
    static void Main(string[] args)
    {
        //Review
        /*
        PrintHello();
        PrintWelcome("Alice");
        PrintWelcome(Console.ReadLine());
        Console.WriteLine("Please input two integers: ");
        int integer1 = getInteger();
        int integer2 = getInteger();
        int sum = TwoSum(integer1, integer2);
        Console.WriteLine($"{integer1}+{integer2}={sum}");
        
        PrintNames("Alice", "Smith");

        string fName = "Alice";
        string lName = "Smith";
        PrintNames(fName, lName);
        PrintNames(firstName:fName,lastName:lName);
        
        int two_grade_sum = GradeSum(english:60, math: 90);
        Console.WriteLine("Sum grade of two classes: " +two_grade_sum);
        int three_grade_sum = GradeSum(english:60, math:90, java:100);
        Console.WriteLine($"Sum Grade of three classes: {three_grade_sum}");
        
        double ThreeAverage = ThreeAvg(a1:1.5, c1:6.5, b1:5.5);
        Console.WriteLine($"The Average of the Three numbers is: {ThreeAverage}");
        double TwoAverage = ThreeAvg(a1:1.5, c1:5.5);
        Console.WriteLine($"The Average of the Two numbers is: {TwoAverage}");
        
        Print(CourseName: "Math", PointGrade: 98.5);
        Print(StuName: "Alice", StuID: 12345);
        */
        string first_name = "Alice";
        string last_name = "Smith";
        bool driver_license = false;
        double history = 90;
        double math = 100;
        StudentSummary(first_name, last_name, driver_license, history, math);
    }
    static void StuInfo(string FirstName, string LastName, bool DriverLicense){
        Console.WriteLine($"Student's full name: {FirstName} {LastName}");
        Console.WriteLine($"Student has driver license: {DriverLicense}");
    }
    static double TotalGrade(double Course1=0, double Course2=0, double Course3 = 0){
        double sum = Course1+Course2+Course3;
        return sum;
    }
    static void StudentSummary(string _FirstName, string _LastName, bool _DriverLicense, double _Course1=0, double _Course2=0, double _Course3=0){
        StuInfo(_FirstName, _LastName, _DriverLicense);
        double total_grade = TotalGrade(_Course1, _Course2, _Course3);
        Console.WriteLine($"Student's total grade: {total_grade} points");
    }
    /*
    static void Print(string CourseName, double PointGrade){
        Console.WriteLine($"The grade of {CourseName} is: {PointGrade}");
    }
    static void Print(string StuName, int StuID){
        Console.WriteLine($"The Student ID of {StuName} is: {StuID}");

    }
    
    static double ThreeAvg(double a1, double c1, double b1 = 3.5){
        return (a1+b1+c1)/3;
    }
    
    static void PrintHello(){
        Console.WriteLine("Hello");
    }
    static void PrintWelcome(string name){
        Console.WriteLine($"Welcome {name}");
    }
    static int getInteger(){
        string str_input = Console.ReadLine();
        int int_intput = Convert.ToInt16(str_input);
        return int_intput;
    }
    static int TwoSum(int a, int b){
        int sum = a + b;
        return sum;
        Console.WriteLine("Code Below return");
    }
    static void PrintNames(string firstName, string lastName){
        Console.WriteLine($"First Name: {firstName}; Last Name: {lastName}");
    }
    static int GradeSum(int english, int math, int java=0){
        return english+math+java;
    }
    */
}
