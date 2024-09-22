namespace Homework4;

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
        Shapes();

    }
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
    /*

    */
    static void Shapes()
    {
        Console.WriteLine("Please enter a number: ");
        string mum1 = Console.ReadLine();
        int intmum1 = Convert.ToInt16(mum1);
        Console.WriteLine("Please enter left or right: ");
        string direction = Console.ReadLine();
        if(direction == "right" || direction == "Right"){
            for(int row = 1; row<=intmum1; row++){
                for(int col = 0; col<intmum1; col++)
                {
                    if(col >= intmum1 - row)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
            Console.WriteLine("");
            }
        }
        if(direction == "left" || direction == "Left"){
            for(int row = 0; row<intmum1; row++){
            for(int col = 0; col<intmum1; col++)
            {
                if(row>=col)
                    Console.Write('*');
            }
            Console.WriteLine("");
        }
        }
    }
}
