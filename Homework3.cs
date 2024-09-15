namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        
        // code for Q1
        Console.WriteLine("Input an integer: ");
        string numinput = Console.ReadLine();
        int num = Convert.ToInt16(numinput);
        bool isPrime = true;
        for(int n = 2; n<num; n++){
            if(num%n == 0){
                isPrime = false;
                break;
            }

        }
        if(isPrime){
            Console.WriteLine($"{num} is prime");
        }
        else{
            Console.WriteLine($"{num} is not prime");
        }

        // code for Q2
        Console.WriteLine("Assign an int value to M: ");
        string Mumber = Console.ReadLine();
        int mumb = Convert.ToInt16(Mumber);
        for(int row=0; row<mumb; row++){
            for(int col = 0; col<mumb; col++){
                Console.Write('*');
            }
            Console.WriteLine("");
        }
     
        // code for Q3 
        Console.WriteLine("Assign an int value to L: ");
        string Lumber = Console.ReadLine();
        int lumb = Convert.ToInt16(Lumber);
        for(int row = 0; row<lumb; row++){
            for(int col = 0; col<lumb; col++)
            {
                if(row>=col)
                    Console.Write('*');
            }
            Console.WriteLine("");
        }
        
        // Bonus Question
        Console.WriteLine("Assign an int value to T: ");
        string Tumber = Console.ReadLine();
        int tumb = Convert.ToInt16(Tumber);
        for(int row = 1; row<=tumb; row++){
            for(int col = 0; col<tumb; col++)
            {
                if(col >= tumb - row)
                    Console.Write(row);
                else
                    Console.Write(" ");
            }
        Console.WriteLine("");
        }

    }
}
