using System;
using System.Net.Http.Headers;
using System.Runtime.Serialization;

namespace Objection {

    class Program {
    static void Main(string [] args) {

        
            // we create 3 new objects of class objectlist
        var azhar = new ObjectList(19, "azhar"); 
        var najib = new ObjectList(25, "najib");
        var pink = new ObjectList(20, "pink");

        //We create a list of type Objectlist to hold the objects
        var player = new List<ObjectList>{};

        //we add our object instances into the class
        player.Add(pink);
        player.Add(najib);
        player.Add(azhar);

        foreach (var item in player)
        {
            Console.WriteLine($"Player name: {item.name}"); //we print out our list of players
            Console.WriteLine($"PLayer age: {item.age}");
        }
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        player.Remove(pink); //we remove a player

        foreach (var item in player)
        {
            Console.WriteLine($"Player name{item.name}"); // we print out our new list of players
            Console.WriteLine($"Player age: {item.age}");
        }

    }
    }

    class ObjectList{ // class that creates a datatype of properties name and age
        public int age {get; set;}

        public string name { get;set;}

        public ObjectList(int ages, string names) { //constructor
            age = ages;
            name = names;
        }
    }

}