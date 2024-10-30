namespace Week10;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        /*
        int[] int_1d_array = {1,2,3,4,5};
        int[,] int_2d_array = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        int[][] int_jagged_array = {
            new int[]{1,2,3},
            new int[]{4,5},
            new int[]{6,7,8,9}
        };
            
        ArrayLength(int_1d_array, int_2d_array, int_jagged_array);
        int[] int_1d_array = {1,2,3,4,5};
        MaxMinSum(int_1d_array);
        
        int[] int_1d_array = {11,2,33,4,45};
        string[] name = {"Alice", "Bob", "Cathy", "David"};
        ArraySort(int_1d_array, name);
        
        string[] car = {"Volvo", "BMW", "Ford", "Mazda"};
        Console.WriteLine($"The index of BMW in array car is: {Array.IndexOf(car, "BMW")}");

        int[,] int_2d_array2 = {
            {1,2,3,4},
            {4,5,6,7}
        };
        Console.WriteLine($"The number of row: {int_2d_array2.GetLength(0)}");
        Console.WriteLine($"The number of col: {int_2d_array2.GetLength(1)}");
        for(int row = 0; row<int_2d_array2.GetLength(0);row++){
            for(int col=0; col<int_2d_array2.GetLength(1); col++){
                Console.Write(int_2d_array2[row, col]+ " ");
            }
            Console.WriteLine();
        }
        int[] int_arr = {1,23,44,552,34,88,91,256,22,31,45};
        ArrayLength(int_arr);
        ArrayRank(int_arr);
        MaxMinSum(int_arr);
        ArraySort(int_arr);
        Console.WriteLine($"The index of BMW in array car is: {Array.IndexOf(int_arr, 256)}");
        */
        string[] name_arr1 = new string[3];
        name_arr1[0] = "Alice";
        name_arr1[1] = "Bob";
        name_arr1[2] = "Cathy";
        string[] name_arr2 = new string[]{"Alice", "Bob", "Cathy"};

        List<string> name_list1 = new List<string>();
        name_list1.Add("Alice");
        name_list1.Add("Bob");
        name_list1.Add("Cathy");
        name_list1.Add("David");
        name_list1.Add(null);
        List<string> name_list2 = new List<string>(){"Alice", "Bob", "Cathy", "David", null};

        Console.WriteLine("\n----Access element with index----");
        Console.WriteLine($"Access first element in name_arr1: {name_arr1[0]}");
        Console.WriteLine($"Access first element in name_list1: {name_list1[0]}");

        Console.WriteLine("\n----Iterate Array with foreach----");
        foreach(var name in name_arr1){
            Console.Write(name +" ");
        }
    
        Console.WriteLine("\n\n----Iterate List with foreach----");
        foreach(var name in name_list1){
            Console.Write(name +" ");
        }

        Console.WriteLine("\n\n----Get number of elements----");
        Console.WriteLine($"Number of elements in name_arr1: {name_arr1.Length}");
        Console.WriteLine($"Number of elements in name_list1: {name_list1.Count}");

        List<string> weekday_list = new List<string>(){"Monday", "Tuesday", "Wednesday", "Sunday"};
        weekday_list.Add("Friday");
        weekday_list.Remove("Sunday");
        weekday_list.Insert(3, "Thursday");
        Console.WriteLine("----Elements in weekday_list----");
        foreach(var name in weekday_list){
            Console.Write(name + " ");
        }
        Console.WriteLine($"\nContains Wednesday: {weekday_list.Contains("Wednesday")}");

        Console.WriteLine("\n----Dictionary: Key-Value Pairs----");
        Dictionary<int, string> stu_info = new Dictionary<int,string>();
        stu_info.Add(111, "Alice");
        stu_info.Add(222, "Bob");
        stu_info.Add(333, "David");
        Console.WriteLine("\n---- Iterate Key-Value Pairs----");
        foreach(var stu in stu_info){
            Console.WriteLine($"Student ID: {stu.Key}, Name: {stu.Value}");
        }
        Console.WriteLine($"The name of ID 111: {stu_info[111]}");
        Console.WriteLine($"Number of pairs: {stu_info.Count}");

        if(stu_info.ContainsKey(333)){
            stu_info.Remove(333);
        }

        Console.WriteLine("\n---Iterate Key-Value Pairs Again-----");
        foreach(var stu in stu_info){
            Console.WriteLine($"Student ID: {stu.Key}, name: {stu.Value}");
        }
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222,"Bob");
        Student cathy = new Student(333, "Cathy");

        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }
    }
    /*
       static void ArrayRank(int[] int_1d_array){
        Console.WriteLine($"The dimension of int_1d_array is: {int_1d_array.Rank}");
    }
    
    static void ArrayRank(int[] int_1d_array, int[,] int_2d_array, int[][] int_jagged_array){
        Console.WriteLine($"The dimension of int_1d_array is: {int_1d_array.Rank}");
        Console.WriteLine($"The dimension of int_2d_array is: {int_2d_array.Rank}");
        Console.WriteLine($"The dimension of int_jagged_array is: {int_jagged_array.Rank}");
    }
    static void ArraySort(int[] int_1d_array, string[] name){
        Console.WriteLine("Original order of int_1d_array: ");
        foreach(var val in int_1d_array){
            Console.Write(val+ " ");

        }
        Array.Sort(int_1d_array);
        Console.WriteLine("\nSorted int_1d_array: ");
        foreach(var val in int_1d_array){
            Console.Write(val+ " ");
        }
        Console.WriteLine("\n---------------");
        Console.WriteLine("Original order of name array: ");
        foreach(var val in name){
            Console.Write(val+ " ");
        }
        Array.Sort(name);
        Console.WriteLine("\nSorted Name array: ");
        foreach(var val in name){
            Console.Write(val+ " ");
        }
    }
    
      static void ArraySort(int[] int_1d_array){
        Array.Sort(int_1d_array);
        Console.WriteLine("\nSorted int_1d_array: ");
        foreach(var val in int_1d_array){
            Console.Write(val+ " ");
       
    }
    Console.WriteLine();
      }
    static void MaxMinSum(int[] int_1d_array){
        Console.WriteLine($"The Max value of int_1d_array is: {int_1d_array.Max()}");
        Console.WriteLine($"The Min value of int_1d_array is: {int_1d_array.Min()}");
        Console.WriteLine($"The Sum value of int_1d_array is: {int_1d_array.Sum()}");

    }
    /*
    static void ArrayLength(int[] int_1d_array, int[,] int_2d_array, int[][] int_jagged_array){
        Console.WriteLine($"The legnth of int_1d_array is: {int_1d_array.Length}");
        Console.WriteLine("Iterate values in an array based on array length in a loop");
        for(int idx = 0; idx<int_1d_array.Length; idx++){
            Console.WriteLine($"{int_1d_array[idx]}");
        }
        Console.WriteLine($"The length of int_2d_array is: {int_2d_array.Length}");
        Console.WriteLine($"The length of int_jagged_array is: {int_jagged_array.Length}");
    }
    
    static void ArrayLength(int[] int_1d_array){
        Console.WriteLine($"The length of int_1d_array is: {int_1d_array.Length}");
    }
    */
    
    
}
class Student{
    public static List<Student> student_list = new List<Student>();
    public int stuID{get;set;}
    public string stuName{get;set;}
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {stuID}, Student Name: {stuName}");
    }
    public Student(int inputID, string inputName){
        stuID = inputID;
        stuName = inputName;
        student_list.Add(this);
    }
}
