namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer(cus_id:110, cus_name:"Alice", cus_age:28);
        Customer c2 = new Customer(cus_id:111, cus_name:"Bob", cus_age:30);
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        c1.ChangeID(new_id:220);
        c2.ChangeID(new_id:221);
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        c1.CompareAge(c2);
    }

}
class Customer
{
    private int id;
    public string name;
    public int age;
    public Customer(int cus_id, string cus_name, int cus_age){
        id = cus_id;
        name = cus_name;
        age = cus_age;
    }  
    public void ChangeID(int new_id){
        id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {id}, name: {name}, age: {age}");
    }
    public void CompareAge(Customer objCustomer){
        if(this.age >= objCustomer.age){
            Console.WriteLine($"{this.name} is older");
        }
        else{
            Console.WriteLine($"{objCustomer.name} is older");
        }
    }
}
