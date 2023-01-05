


using System;

namespace AddressBookProgram
{
    public class AddressBook1
    {
        
        public static void Main(string[] args)
        {
            AddressBook ab = new AddressBook();
            bool choice = true;
            ab.CreateUser();
            static void Userchoice()
            {
                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine("#1 Add new Contact ");
                Console.WriteLine("#2 Edit user information");
                Console.WriteLine("#3 Delete existing user");
                Console.WriteLine("#4 Show all users in adressBook");
                Console.WriteLine("#5 Exit");
            }
            while (choice == true)
            {
                Userchoice();
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("How many Contact do yo want to Add : ");
                        int C = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= C; i++)
                        {
                            ab.CreateUser();
                        }
                        ab.ShowAllPersonsInList();
                        break;
                    case 2:
                        ab.EditUserInformation();
                        Console.WriteLine("\n ***Contact Edited***");
                        ab.ShowAllPersonsInList();
                        break;
                    case 3:
                        ab.DeleteContact();
                        Console.WriteLine("\n ***Contact Deleted***");
                        ab.ShowAllPersonsInList();
                        break;
                    case 4:
                        ab.ShowAllPersonsInList();
                        break;
                    case 5:
                        choice = false;
                        break;
                }

            }

        }
    }

}
