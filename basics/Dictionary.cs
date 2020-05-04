using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ripon = new People(1, "Ripon", 1992, "Male");
            var shame = new People(2, "Shama", 1993, "Female");
            var labib = new People(3, "Labib", 2018, "Male");

            // Initialize the Dictionary with some element 
            var users = new Dictionary<int, People>
            {
                { ripon.Id, ripon },
                { shame.Id, shame },
            };

            // Adding item to the Dictionary 
            users.Add(labib.Id, labib);

            // Looping the Dictionary
            foreach (var user in users.Values)
            {
                Console.WriteLine($"Name: {user.Name}, Birth Year: {user.BirthYear}, and Gender: {user.Gender}");
            }

            // Select a item of the Dictionary
            var selectedUser = users[2];
            Console.WriteLine(selectedUser.Name);

            // Count the length of Dictionary
            Console.WriteLine(users.Count);

        }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Gender { get; set; }

        public People(int id, string name, int birthYear, string gender)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Gender = gender;
        }
    }
}
