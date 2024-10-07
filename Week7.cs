namespace Week7;

class Program
{
    static void Main(string[] args)
    {
        /*
    Professor p1 = new Professor();
    p1.name = "Alice";
    p1.age = 30;
    p1.PrintInfo();

    Professor p2 = new Professor();
    p2.name = "Bob";
    p2.age = 40;
    p2.PrintInfo();
    

    Building B1 = new Building();
    B1.name = "Clasroom Center";
    B1.address = "Canyon";
    B1.num_rooms = 100;
    B1.PrintBuildingInfo();
    B1.UpdateName("Study Center");
    Console.WriteLine($"The new name is: {B1.name}");
    */
    Student s1 = new Student();
    s1.studentName = "Alice Smith";
    s1.age = 21;
    s1.address = "Amarillo";
    s1.PrintStudentInfo();
    s1.ChangeAddress("Canyon");
    s1.PrintStudentInfo();
    }
}