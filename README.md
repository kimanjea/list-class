# list class
 class objects instances in a list
# ObjectList Project
* Overview
The ObjectList project is a simple C# console application that demonstrates the use of a custom class called ObjectList to create objects with properties for age and name. It includes a basic implementation of a player list, allowing you to create, add, and remove players.


* Usage
The ObjectList class is designed to store information about players, including their age and name. The Program class demonstrates the creation, addition, and removal of player objects in a list.

Creating Players:
*** var azhar = new ObjectList(19, "azhar");
var najib = new ObjectList(25, "najib");
var pink = new ObjectList(20, "pink"); ***


Adding Players to the List:
***var player = new List<ObjectList>{};
player.Add(pink);
player.Add(najib);
player.Add(azhar);***

Displaying Player Information:
***foreach (var item in player)
{
    Console.WriteLine($"Player name: {item.name}");
    Console.WriteLine($"Player age: {item.age}");
}***

Removing a Player:
***player.Remove(pink);***

Displaying Updated Player List:
***foreach (var item in player)
{
    Console.WriteLine($"Player name: {item.name}");
    Console.WriteLine($"Player age: {item.age}");
}***


