namespace Homework7;
class Program
{
    static void Main(string[ ] args)
    {
        //Customer Objects

        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);
     
        //Customer Information
        Console.WriteLine("Original Customer Information");
        customer1.PrintCustInfo();
        customer2.PrintCustInfo();

        //Updated Customer IDs
        customer1.ChangeID(220);
        customer2.ChangeID(221);

        //Updated Customer Information
        Console.WriteLine("Updated Customer Information");
        customer1.PrintCustInfo();
        customer2.PrintCustInfo();

        //Comparing Customer Ages
        string ComparedAge = customer1.CompareAge(customer2);
        Console.WriteLine($"{ComparedAge} is older.");
    }
 }


class Customer 
{
    //Private Field
    private int cus_id;

    //Public Fields
    public string cus_name;
    public int cus_age;

    //Constructor
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    //Changing Customer IDs
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    //Printing New Customer Info
    public void PrintCustInfo()
    {
        Console.WriteLine($"Customer ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    //Compare Ages and Print Older Custoomer
    public string CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            return this.cus_name;
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            return objCustomer.cus_name;
        }
        else
        {
            return "Both customers are the same age";
        }
    }
}
