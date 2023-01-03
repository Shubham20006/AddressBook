


namespace AddressBookProgram
{
    public class AddressBook1
    {
        public static void Main(string[] args)
        {
            AddressBook ab = new AddressBook();
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\n Enter Contact Details {0}", i);
                ab.CreateUser();
            }
            ab.ShowAllPersonsInList();
            Console.WriteLine("\n Do you want to Edit Information: if yes=1, no=2");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A == 1)
            {
                ab.EditUserInformation();
                Console.WriteLine("\n Contact Edited");
                ab.ShowAllPersonsInList();
            }
            
        }
    }
}
