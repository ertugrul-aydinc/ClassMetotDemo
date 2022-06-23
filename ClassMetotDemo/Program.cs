// See https://aka.ms/new-console-template for more information


Customer c1 = new Customer();

c1.name = "John";
c1.surname = "Wick";
c1.age = 44;
c1.accountNo = "2147896";

Customer c2 = new Customer();

c2.name = "Chris";
c2.surname = "Evans";
c2.age = 33;
c2.accountNo = "4875669";

Customer[] customers = new Customer[] { c1, c2 };

CustomerManager cm1 = new CustomerManager();

cm1.Add(c1);
cm1.Delete(c2);
cm1.List(customers);



class Customer
{
    public int id { get; set; }
    public string name { get; set; }

    public string surname { get; set; }

    public int age { get; set; }

    public string accountNo { get; set; }

}


class CustomerManager
{
    public void Add(Customer customer)
    {
        Console.WriteLine("Custommer added : "+customer.name);
    }

    public void List(Customer[] array)
    {
        foreach (Customer c in array)
        {
            Console.WriteLine(c.name);
            Console.WriteLine(c.surname);
            Console.WriteLine(c.age);
            Console.WriteLine(c.accountNo);
            Console.WriteLine("*************************");
        }
    }

    public void Delete(Customer customer)
    {
        Console.WriteLine("Customer deleted");
    }
}



