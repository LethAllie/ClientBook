using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clientbook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class SQLCommandsToConnect
    {
        private string connString = "TODO Add Connection String";
        public void CreateNewPerson()
        {
            
            SqlConnection conn = new SqlConnection(connString);

            using (conn)
            {
                conn.Open();

            }

        }
    }
    public class ServiceRepo : IPersonRepo
    {
        public void AddPerson(Person person)
        {
            string firstName = person.FName;
            string lastName = person.LName;
            string address = person.Address;
            string email = person.Email;
            string phoneNumber = person.PhoneNumber;
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
    public class GeneratePersonInfo
    {
        Person person = new Person();

        public Person InfoToPerson(string firstName, string lastName, string address, string email, string phoneNumber, string clientID)
        {

            Person person = new Person();

            person.FName = firstName;
            person.LName = lastName;
            person.Address = address;
            person.Email = email;
            person.PhoneNumber = phoneNumber;
            person.ClientID = clientID;

            return person;
        }

        
    }

    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ClientID { get; set; }


    }
    public interface IPersonRepo
    {
        void AddPerson(Person person);
        IEnumerable<Person> GetPeople();
        Person GetPerson(string lastName);
        void UpdatePerson(string lastName, Person updatedPerson);
        void DeletePerson(string lastName);
        
    }
}
