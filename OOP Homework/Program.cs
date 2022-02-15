using OOP_Homework;

namespace Classes
{
    class Program
    {
        static void Main(string[]args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();


            ProductManager productManager = new ProductManager();
            productManager.Remove();



            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Bekir";
            customer.Surname = "Aslan";
            customer.City = "İstanbul";

            Customer customer2 = new Customer()
            {
                Id = 2,City = "Istanbul", Name = "Bekir ",Surname = "Aslan"
            };
            Console.WriteLine(customer2.City);




        }
    }
}