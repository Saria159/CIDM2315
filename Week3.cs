namespace Week3;

class Program
{
    static void Main(string[] args)
    {
        /*
        for(int x=0;x<10;x++){
            Console.WriteLine(x);
        }
        for(int j=0;j<10;j=j+3){
            Console.WriteLine(j);
        }
        for(int k=10;k>0;k=k-3){
            Console.WriteLine(k);
        }
        
        Console.WriteLine("Please enter N: ");
        int N = Convert.ToInt16(Console.ReadLine());
        for(int n=0; n<N; N--){
            Console.Write("*");
        }
        
        int attempts = 3;
        string username = "alice";
        string input_username;
        do{
            Console.WriteLine("Please input username: ");
            input_username = Console.ReadLine();
            if(input_username == username){
                Console.WriteLine("Log in Successful");
                break;
            }
            else{
                Console.WriteLine("Wrong username");
            }
            attempts--;
            Console.WriteLine($"You have {attempts} chances left");
        }
        while(attempts>0);

        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++){
                if(row<=col)
                    Console.Write('*');
            }
            Console.WriteLine("");
        }
        for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++){
                Console.Write('*');
            }
            Console.WriteLine("");
        }
             for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++){
                if(row>=col)
                    Console.Write('*');
            }
            Console.WriteLine("");
        }
             for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++){
                Console.Write(col);
            }
            Console.WriteLine("");

        }
        */
        int num1 = 10;
        int num2 = 20;
        
        int max_num = (num1 > num2) ? num1 : num2;
        Console.WriteLine($"the max value is: {max_num}");
    }
}
