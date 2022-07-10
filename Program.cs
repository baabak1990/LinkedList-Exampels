// See https://aka.ms/new-console-template for more information
Console.WriteLine("Here Some Good Example For LinkedList Collection In C#");
string[] Names = { "baabak", "Mohammad", "ALireza", "Taghi" };

//Firstly I put The string Array We created Before if Our New LinkedList Constructor
LinkedList<string> ListName=new LinkedList<string>(Names);
foreach (string n in Names)
{
    Console.WriteLine(n);
}
Console.WriteLine("<==================================================>");
Console.ForegroundColor = ConsoleColor.Red;

//Here I Add to Elements in Az A First And Last Elements 
ListName.AddFirst("Mostafa");
ListName.AddLast("Reza");
foreach (var n1 in ListName)
{
    Console.WriteLine(n1);
}
Console.WriteLine("<==================================================>");

//As You Can See these are  most importan feathurs In LinkedList
Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine("<==================================================>");

//Lets See Some other diffrences between list and linked list by useing linkedListNode Class
LinkedListNode<string> First=ListName.First;
LinkedListNode<string> Last=ListName.Last;
Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("The First Item is {0} and The Last Itme is {1}",First.Value,Last.Value);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("<==================================================>");
Console.ForegroundColor = ConsoleColor.White;

//And Here Some Other feathurs We can AddAfter but keep that in mind you should use the linkedlistNode type for first elemnt here
ListName.AddAfter(First, "Shapor");
ListName.AddBefore(Last, "GHolom");
foreach (var n1 in ListName)
{
    Console.WriteLine(n1);
}
Console.WriteLine("<===========================================>");
