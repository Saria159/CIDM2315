class Student
{
    public string studentName;

    public int age;
    public string address;

    public void PrintStudentInfo(){
        Console.WriteLine($"Student name: {studentName}");
        Console.WriteLine($"Student age: {age}");
        Console.WriteLine($"Student address: {address}");

    }
    public void ChangeAddress(string new_address){
        address = new_address;
    }
}