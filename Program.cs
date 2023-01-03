


namespace AddressBookProgram
{
    public class AddressBook1
    {
        public static void Main(string[] args)
        {            
            AddressBook ab = new AddressBook();                     
            for (int i = 1; i <= 2; i++)
            { 
                Console.WriteLine("\n Enter Contact Details {0}",i); 
                ab.CreateUser(); 
            }
            ab.ShowAllPersonsInList();
        }
    }
}
