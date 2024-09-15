namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // code of Q1
        Console.WriteLine("Please input a letter grade: ");
        string letter_grade = Console.ReadLine();
        if(letter_grade == "A"){
            Console.WriteLine("GPA point: 4");
        }
        else if(letter_grade == "B"){
            Console.WriteLine("GPA point: 3");
        }
        else if(letter_grade == "C"){
            Console.WriteLine("GPA point: 2");
        }    
        else if(letter_grade == "D"){
            Console.WriteLine("GPA point: 1");
        }
        else if(letter_grade == "F"){
            Console.WriteLine("GPA point: 0");
        }
        else{
            Console.WriteLine("Wrong Letter Grade");
        }  

        // code of Q2
        Console.WriteLine("Please input the first num: ");
        string first_num = Console.ReadLine();
        int n1 = Convert.ToInt16(first_num);
        Console.WriteLine("Please input the second num: ");
        string sec_num = Console.ReadLine();
        int n2 = Convert.ToInt16(sec_num);
        Console.WriteLine("Please input the third num: ");
        string third_num = Console.ReadLine();
        int n3 = Convert.ToInt16(third_num);
        if(n1<n2){
            if(n1<n3){
                Console.WriteLine($"The smallest number is {n1}");
            }
            else{
                Console.WriteLine($"The smallest number is {n3}");
            }
        }
        else{
            if(n2<n3){
                Console.WriteLine($"The smallest number is {n2}");
            }
            else{
                Console.WriteLine($"The smallest number is {n3}");
            }
        }

        // code of Bonus
        Console.WriteLine("Please input a year: ");
        string Lyear_input = Console.ReadLine();
        int Lyear = Convert.ToInt16(Lyear_input);
        if (Lyear%4 == 0){
            if(Lyear%100 == 0 && Lyear%400 != 0){
                Console.WriteLine($"{Lyear} is not a leap year");
            }
            else{
                Console.WriteLine($"{Lyear} is a leap year");
            }
        }
        else{
            Console.WriteLine($"{Lyear} is not a leap year");
        }
    }
}
