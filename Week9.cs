namespace Week9;

class Program
{
    static void Main(string[] args)
    {
        /*
        int[] iArray = new int[5];
        Console.WriteLine(iArray);
        double[] dArray = new double[6];
        Console.WriteLine(dArray);
        string[] sArray = new string[10];
        Console.WriteLine(sArray);
        bool[] bArray = new bool[3];
        Console.WriteLine(bArray);
        int[] iArray = {10, 15, 20, 25, 30};
        Console.WriteLine(iArray[0]);
        Console.WriteLine(iArray[1]);
        Console.WriteLine("the initial: " +iArray[4]);
        iArray[4] = 100;
        Console.WriteLine("the new result: " +iArray[4]);
        for(int idx = 0; idx<5; idx++){
            Console.WriteLine(iArray[idx]);
        }
        int[] iArray2 = new int[5];
        for(int idx = 0; idx<5; idx++){
            iArray2[idx] = iArray[idx]*2;
        }        
        

        for(int idx = 0; idx<5; idx++){
            Console.WriteLine(iArray2[idx]);
        }

        foreach(var val in iArray2){
            Console.WriteLine(val);
        }
        string[] candidates = new string[3];

        candidates[0] = "Alice";
        candidates[1] = "Bob";
        candidates[2] = "Cathy";

        foreach(string candidate in candidates){
            Console.WriteLine(candidate);
        }

        string[] name_array = new string[5];

        name_array[0] = "Alice";
        name_array[1] = "Bob";
        name_array[2] = "Cathy";
        name_array[3] = "Tom";
        name_array[4] = "Jack"; 
        Console.WriteLine($"The second name is {name_array[1]}, and the fourth name is: {name_array[3]}");
        name_array[4] = "David";
        foreach(var name in name_array){
            Console.WriteLine(name);
        }
        int [,] arr1 = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        Even(arr1);

        Student stu1 = new Student(studentID:111, studentName:"Alice", studentGPA:3.6);
        Student stu2 = new Student(studentID:222, studentName:"Bob", studentGPA:3.5);
        Student stu3 = new Student(studentID:333, studentName:"Cathy", studentGPA:3.1);
        Student[] student_array = {stu1, stu2, stu3};
        foreach(Student stu in student_array){
            stu.printStuInfo();
        }
        //Console.WriteLine($"student 1 - ID: {student_array[0].studentID}; name: {student_array[0].studentName};");
        //Console.WriteLine($"student 3 - ID: {student_array[2].studentID}; name: {student_array[2].studentName};");
        */
        Food food1 = new Food(foodName:"Juice", foodPrice:3.49, foodType:"Drink");
        Food food2 = new Food(foodName:"Orange", foodPrice:0.99, foodType:"Fruit");
        Food food3 = new Food(foodName:"Chicken", foodPrice:8.99, foodType:"Meat");
        Food food4 = new Food(foodName:"Broccoli", foodPrice:2.49, foodType:"Vegetable");
        Food food5 = new Food(foodName:"Banana", foodPrice:0.59, foodType:"Fruit");
        Food food6 = new Food(foodName:"Beef", foodPrice:14.99, foodType:"Meat");
        Food food7 = new Food(foodName:"Carrot", foodPrice:1.29, foodType:"Vegetable");
        Food food8 = new Food(foodName:"Soda", foodPrice:2.99, foodType:"Drink");
        Food[] shopping_list = {food1, food2, food3, food4, food5, food6, food7, food8};

        TotalPrice(shopping_list);
        TotalFruitPrice(shopping_list);
        AveragePrice(shopping_list);

    }   

    class Food{
        public string foodName{get;set;} = string.Empty;
        public double foodPrice{get;set;} = 0;
        public string foodType{get;set;} = string.Empty;
        public Food(string foodName, double foodPrice, string foodType){
            this.foodName = foodName;
            this.foodPrice = foodPrice;
            this.foodType = foodType;
        }
    }
    public static void TotalPrice(Food[] shopping_list){
        double totalPrice = 0;
        foreach (Food foodItem in shopping_list){
            totalPrice += foodItem.foodPrice;
        }
        Console.WriteLine($"The total pricce of all food: {totalPrice}");
    }
    public static void TotalFruitPrice(Food[] shopping_list){
        double totalFruit = 0;
        foreach (Food foodItem in shopping_list){
            if (foodItem.foodType = "Fruit"){
              totalPrice += foodItem.foodPrice;
            }

        }
        Console.WriteLine($"The total price of all fruit: {totalFruitPrice}");


    }
    public static void AveragePrice(Food[] shopping_list){
        double totalPrice = 0;
        int countFood = 0;
        foreach(var foodItem in shopping_list){
            totalPrice += foodItem.foodPrice;
            countFood++;
        }
        if (countFood > 0){
            double averagePrice = totalPrice/countFood;
            Console.WriteLine($"The total average price of all food: {averagePrice}");

        }
    }
    /*
    class Student{
        public int studentID {get;set;} = 0;
        public string studentName{get;set;} = string.Empty;
        public double studentGPA{get;set;} = 0;
        public void printStuInfo(){
            Console.WriteLine($"Student ID: {studentID}; Student Name: {studentName}; Student GPA: {studentGPA}");
        }
        public Student(int studentID, string studentName, double studentGPA){
            this.studentID = studentID;
            this.studentName = studentName;
            this.studentGPA = studentGPA;
        }
    }

    static void Even(int [,] arr1a)
    {
        foreach(int val in arr1a){
            if(val%2==0)
            {
                Console.Write(val + " ");
            }
        }
    }
    */
}
