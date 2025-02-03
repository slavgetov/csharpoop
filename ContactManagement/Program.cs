namespace ContactManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact Management Platform.");
            Contact MyNewContact = new Contact(1, "Michael", "+359896604633", "mike@email.com");
            Console.WriteLine(MyNewContact);
            MyNewContact.Name = "michael Scott";
            MyNewContact.PhoneNumber = "123-123-4567";
        }
    }
}
