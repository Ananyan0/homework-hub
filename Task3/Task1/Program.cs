public class Contact
{
    public string Name;
    public int Phone;
    public string Email;

    public Contact(string name, int phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Phone: " + Phone);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine();
    }

}

public class Program
{
    public static void Main()
    {
        Contact[] contacts = new Contact[3];

        for (int i = 0; i < 3; i++)
        {
            string name = Console.ReadLine();
            string email = Console.ReadLine();
            int phone = int.Parse(Console.ReadLine());

            contacts[i] = new Contact(name, phone, email);
        }
        foreach (var contact in contacts)
        {
            contact.DisplayInfo();
        }

        Console.WriteLine("Search name");
        string searchName = Console.ReadLine();
        bool isFound = false;
        for (int i = 0; i < 3; i++)
        {
            if (contacts[i].Name == searchName)
            {
                contacts[i].DisplayInfo();
                isFound = true;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("There is no name like that");

        }
        Console.ReadKey();

    }
}