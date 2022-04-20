using System.Collections.Generic;

namespace FormulaOne.Classes
{
    public class Driver
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Score { get; set; }
        public Team? Team { get; set; }
        public Dictionary<string, object> Stats = new();
        
        public Driver(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public Driver(Team team, string name, string lastName) : this(name, lastName)
        {
            Team = team;
        }

        public void displayInformation()
        {
            Console.WriteLine($"Name: {Name} {LastName}");
            Console.WriteLine($"Score: {Score}");
            Console.WriteLine($"Team: {Team}");
        }

    }
}