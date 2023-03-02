using System;

namespace Quest
{
    // An instance of the Adventurer class is an object that will undergo some challenges
    public class Adventurer
    {
        private string userName;

        // This is an "immutable" property. It only has a "get".
        // The only place the Name can be set is in the Adventurer constructor
        // Note: the constructor is defined below.
        public string Name { get; }
        public Robe ColorfulRobe { get; }

        public Hat Hat {get; set;}

        // This is a mutable property it has a "get" and a "set"
        //  So it can be read and changed by any code in the application
        public int Awesomeness { get; set; }

        // A constructor to make a new Adventurer object with a given name
        public Adventurer(string name, Robe colorfulrobe, Hat hat)
        {
            Name = name;
            Awesomeness = 50;
            ColorfulRobe = colorfulrobe;
            Hat = hat;
        }

        public Adventurer(string userName, Robe colorfulRobe)
        {
            this.userName = userName;
            ColorfulRobe = colorfulRobe;
        }

        public void getDescription()
        {
            Console.WriteLine($"hello {Name}, weary traveller with a {ColorfulRobe.length}inch, {string.Join(" ", ColorfulRobe.color )}... robe and {Hat.ShininessDescription()}");
        }

        // This method returns a string that describes the Adventurer's status
        // Note one way to describe what this method does is:
        //   it transforms the Awesomeness integer into a status string
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }
    }
}