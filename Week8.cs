namespace Week8;

class Program
{
    static void Main(string[] args)
    {
        Student Alice = new Student(input_id:1111, input_age:23, input_name:"Alice Smith");
        Alice.printInfo();

        Customer cus1 = new Customer(inputCustomerName:"Alice");
        Console.WriteLine($"No. of Customer: {Customer.countCustomer}");
        Customer cus2 = new Customer(inputCustomerName:"Bob");
        Console.WriteLine($"No. of Customer: {Customer.countCustomer}");
        
        Computer dell = new Computer(price:1000, brand:"Dell");
        Computer apple = new Computer(price:2000, brand: "Apple");
        dell.comparePrice(apple);
        apple.comparePrice(dell);
    }
}
class Customer{
    public static int countCustomer{get;set;} = 0;
    public string customerName{get;set;}=string.Empty; 
    public Customer(string inputCustomerName){
        customerName = inputCustomerName;
        Console.WriteLine($"Customer {inputCustomerName} created!");
        countCustomer += 1;
    }

}
class Student{
    public int id = 0;
    public int age = 0;
    public string name = string.Empty;
    public void printInfo(){
        Console.WriteLine($"Student ID: {id}");
        Console.WriteLine($"Student name: {name}");
        Console.WriteLine($"Student age: {age}");

    }

    public Student(int input_id, int input_age, string input_name){
       id = input_id;
       age = input_age;
       name = input_name;
    }
    class Computer{
        public int price{get;set;} = 0;
        public string brand {get;set;}= string.Empty;
        public Computer(int price, string brand){
            this.price = price;
            this.brand = brand;
        }
        public void ComparePrice(Computer objComputer){
            Console.WriteLine($"Current Object is: {this.brand}");
            if(this.price <= objComputer.price){
                Console.WriteLine($"{this.brand} is cheaper");
            }
            else{
                Console.WriteLine($"{objComputer.brand} is cheaper");
            }
        }
    }
}

