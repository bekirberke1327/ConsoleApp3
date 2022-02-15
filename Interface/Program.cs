namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                 new SqlServerCustomerDal(),
                 new OracleCustomerDal(),
                 new MySql()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Update();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Bekir", LastName = "Aslan", Address = "Başakşehir" });

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Ethem",
                LastName = "Aslan"

            };
            manager.Add(student);
        }

        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " "+ person.LastName);
        }
    }
}