using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaSearch.Models;

namespace MediaSearch
{
    public class DataAccess
    {
        Random rnd = new Random();
        string[] streetAddresses = new string[] { "246 Test Street", "146 HelloWorld Rd", "7745 DataAccess Lane", "9955 Hollywood Blvd", "4650 Arco Corporate Dr", "5211 Trinity Village Ln", "28255 State Hwy 10", "45 West Street", "111 North Street"};
        string[] cities = new string[] { "Walton", "Testville", "Hidden Cove", "Random Island", "Sidney", "Cannonsville", "Delhi", "Mt. Upton", "Alligator Isle", "Bluffington", "Walkinston"};
        string[] states = new string[] { "NY", "CA", "SD", "ND", "WA", "AZ", "FL", "OK", "VA", "TX", "NC"};
        string[] zipCodes = new string[] { "12345", "67890", "12212", "32234", "55643", "77193", "91280", "52632", "13346", "13820"};

        string[] firstNames = new string[] { "James", "Jeff", "Jason", "Jessica", "Jessie", "Justin", "Robert", "Rebecca", "Mandy", "Martha", "Leonard", "Atticus", "Abbie", "Allison", "Brian", "Betty", "Naomi", "Nick", "Nicholas", "Rocky"};
        string[] lastNames = new string[] { "Jefferson", "Richardson", "Smith", "Jacobs", "Washington", "Flake", "Northrup", "Townsend", "North", "Platt", "Voight", "Reed", "Balboa", "Stallone"};
        bool[] aliveStatuses = new bool[] { true, false };
        DateTime lowEndDate = new DateTime(1943, 1, 1);
        int daysFromLowDate;

        public DataAccess()
        {
            daysFromLowDate = (DateTime.Today - lowEndDate).Days;
        }

        public List<PersonModel> GetPeople(int total = 10)
        {
            List<PersonModel> output = new List<PersonModel>();

            for(int i = 0; i< total; i++)
            {
                output.Add(GetPerson(i + 1));
            }

            return output;
        }

        private PersonModel GetPerson(int id)
        {
            PersonModel output = new PersonModel { PersonId = id, FirstName = GetRandomItem(firstNames), LastName = GetRandomItem(firstNames) };

            return output;
        }
    }
}
