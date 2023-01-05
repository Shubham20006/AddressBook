using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    class AddressBook
    {
        public List<Person> addressBookList;
        public List<Person> AddressBookList
        {
            get { return addressBookList; }
            set { this.addressBookList = value; }
        }
        public AddressBook()
        {
            AddressBookList = new List<Person>();

        }

        public void CreateUser()
        {
            Console.WriteLine("Enter FirstName:");
            var FirstName = Console.ReadLine();

            Console.WriteLine("Enter LastName:");
            var LastName = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            var Address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            var City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            var State = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            var Zip = Console.ReadLine();

            Console.WriteLine("Enter PhoneNum:");
            var PhoneNum = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            var Email = Console.ReadLine();
            Console.WriteLine();

            Person person = new Person(FirstName, LastName, Address, City, State, Zip, PhoneNum, Email);
            AddPersonToList(person); 
        }


        private void AddPersonToList(Person person) => AddressBookList.Add(person);

        public void ShowAllPersonsInList()
        {
            foreach (var person in AddressBookList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, Adress: {2}, City : {3}, State: {4}, Zip: {5}, PhoneNum: {6}, Email: {7}", person.FirstName, person.LastName, person.Address, person.City, person.State, person.Zip, person.PhoneNum, person.Email);
            }
            Console.ReadLine();
        }

        public void EditUserInformation()
        {
            Console.WriteLine("Which information do you want to Edit?");
            Console.WriteLine("#1: Firstname, #2: Lastname, 3#: Address, 4#: City, 5#: State, 6#: Zip, 7#: PhoneNum, 8#: Email");
            var userOption = Console.ReadLine();

            Console.WriteLine("Enter firstname of existing user to be updated");
            var oldFirstName = Console.ReadLine();
            EditUserFunction(userOption, oldFirstName);
        }

        private void EditUserFunction(string userOption, string oldFirstName)
        {
            var personsWithMatchingFirstName = AddressBookList.Where(person => person.FirstName == oldFirstName);
            string newValue;

            if (userOption == "1")
            {
                Console.WriteLine("Enter a new first Name");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.FirstName = newValue;
                }
            }
            else if (userOption == "2")
            {
                Console.WriteLine("Enter a new last name");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.LastName = newValue;
                }
            }
            else if (userOption == "3")
            {
                Console.WriteLine("Enter a new address");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.Address = newValue;
                }
            }
            else if (userOption == "4")
            {
                Console.WriteLine("Enter a new City Name");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.City = newValue;
                }
            }
            else if (userOption == "5")
            {
                Console.WriteLine("Enter a new State Name");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.State = newValue;
                }
            }
            else if (userOption == "6")
            {
                Console.WriteLine("Enter a new Zip code");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.Zip = newValue;
                }
            }
            else if (userOption == "7")
            {
                Console.WriteLine("Enter a new PhoneNum");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.PhoneNum = newValue;
                }
            }
            else if (userOption == "8")
            {
                Console.WriteLine("Enter a new Email");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.Email = newValue;
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter firstName of the user you want to remove");
            var firstName = Console.ReadLine();
            AddressBookList.RemoveAll(item => item.FirstName == firstName);          
        }
    }
   
}


