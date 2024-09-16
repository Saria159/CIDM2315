namespace Week4;

class Program
{
    static void Main(string[] args)
    {
        /*
        string int_put;
        int num;
        int total = 0;

        for(int i = 0; i<3; i++){
            Console.WriteLine("Please input int: ");
            int_put = Console.ReadLine();
            num = Convert.ToInt16(int_put);
            total = total + num;
        }
        Console.WriteLine($"The total is: {total}");
        
        int attempts = 3;
        string username = "alice";
        string password = "alice123";
        string input_username;
        string input_password;
        do{
            Console.WriteLine("Please input username: ");
            input_username = Console.ReadLine();
            Console.WriteLine("Please input password: ");
            input_password = Console.ReadLine();
            if(input_username == username && input_password == password){
                Console.WriteLine("Log in Successful");
                break;
            }
            else{
                Console.WriteLine("Wrong username or password");
            }
            attempts--;
            Console.WriteLine($"You have {attempts} chances left");
        }
        while(attempts>0);


    
        int stu_id1 = 101; string stu_name1 = "Alice";
        int stu_id2 = 102; string stu_name2 = "Bob";
        Console.WriteLine("------Print information with method------");
        WelcomeMessage(stu_id1, stu_name1);
        WelcomeMessage(stu_id2, stu_name2);

    }
    static void WelcomeMessage(int stu_id, string stu_name){
        Console.WriteLine($"Welcome to WT Student: {stu_id}, Your name is {stu_name}!");
*/

        int stu_id1 = 101; string stu_name1 = "Alice";
        WelcomeMessage(stu_id1, stu_name1);
        Console.WriteLine("------Printwords method------");
        PrintWords();
        
    }
    
    static void WelcomeMessage(int stu_id, string stu_name){
        Console.WriteLine($"Welcome to WT Student: {stu_id}, Your name is {stu_name}!");
    }
    static void PrintWords(){
        Console.WriteLine("Sample method without inputs and outputs values");

    }

}
