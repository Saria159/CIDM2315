namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1_method
        Console.WriteLine("Please enter a: ");
        int n1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please enter b: ");
        int n2 = Convert.ToInt16(Console.ReadLine());
        int returned_num = Compare(n1,n2);
        Console.WriteLine($"a = {n1}, b = {n2}");
        Console.WriteLine($"The larger number is {returned_num}");
        //Call Q2_method
        Console.WriteLine("Please enter a: ");
        int a1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please enter b: ");
        int b2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please enter c: ");
        int c3 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please enter d: ");
        int d4 = Convert.ToInt16(Console.ReadLine());
        int returned_max = FourCompare(a1,b2,c3,d4);
        Console.WriteLine($"a = {a1}, b = {b2}, c = {c3}, d = {d4}");
        Console.WriteLine($"The largest number is {returned_max}");
        //Q3
        createAccount();


    }
    //Q1 method
    static int Compare(int a, int b)
    {
        int num;
        if(a > b)
        {
            num = a;
        }
        else
        {
            num = b;
        }
        return num;
    }
    //Q2 method
    static int FourCompare(int num1, int num2, int num3, int num4)
    {
        int max1 = Compare(num1,num2);
        int max2 = Compare(num3,num4);
        int ultramax = Compare(max1,max2);
        return ultramax;
    }
    //Q3 method
    static bool checkAge(int birth_year){
        int current_year = 2024;
        int age = current_year - birth_year;
        if(age>=18){
            return true;
        }
        else{
            return false;
        }
    }
    static void createAccount(){
        Console.WriteLine("Please enter a username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Please enter a password: ");
        string password = Console.ReadLine();
        Console.WriteLine("Please re-enter your password: ");
        string conpass = Console.ReadLine();
        Console.WriteLine("Please enter your birth year: ");
        int birth = Convert.ToInt16(Console.ReadLine());
        if(checkAge(birth) == true){
            if(password == conpass){
                Console.WriteLine("Account is created successfully");
            }
            else{
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create account");
        }
    }
}
