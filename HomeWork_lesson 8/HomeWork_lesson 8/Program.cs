class PhoneBook
{
    private List<Person> contacts;

    public PhoneBook()
    {
        contacts = new List<Person>();
    }

    public void AddContact()
    {
        Console.WriteLine("Enter the person's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the person's phone number:");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Enter the person's address:");
        string address = Console.ReadLine();

        Person newPerson = new Person(name, phoneNumber, address);
        contacts.Add(newPerson);

        Console.WriteLine("Contact added successfully!");
    }

    public void SearchByName(string name)
    {
        bool found = false;

        foreach (Person person in contacts)
        {
            if (person.Name.ToLower() == name.ToLower())
            {
                Console.WriteLine("Contact found:");
                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("Phone number: " + person.PhoneNumber);
                Console.WriteLine("Address: " + person.Address);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Contact not found!");
        }
    }

    public void SearchByPhoneNumber(string phoneNumber)
    {
        bool found = false;

        foreach (Person person in contacts)
        {
            if (person.PhoneNumber == phoneNumber)
            {
                Console.WriteLine("Contact found:");
                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("Phone number: " + person.PhoneNumber);
                Console.WriteLine("Address: " + person.Address);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Contact not found!");
        }
    }
}

class Person
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public Person(string name, string phoneNumber, string address)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Address = address;
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Phone Book Menu:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Search by Name");
            Console.WriteLine("3. Search by Phone Number");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice (1-4):");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    phoneBook.AddContact();
                    break;
                case 2:
                    Console.WriteLine("Enter the name to search:");
                    string name = Console.ReadLine();
                    phoneBook.SearchByName(name);
                    break;
                case 3:
                    Console.WriteLine("Enter the phone number to search:");
                    string phoneNumber = Console.ReadLine();
                    phoneBook.SearchByPhoneNumber(phoneNumber);
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
