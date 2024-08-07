using m2w1d2.Task1;
using m2w1d2.Task2;
using m2w1d2.Task3;
using m2w1d2.Task4;




//Task-1
Console.WriteLine();
Console.WriteLine("---------------------------Task-1---------------------------");
Console.WriteLine();
Task1 task1 = new Task1();
int a = 10;
int b = 20;
task1.Swap(ref a, ref b);

//Task-2
Console.WriteLine();
Console.WriteLine("---------------------------Task-2---------------------------");
Console.WriteLine();
System.Collections.Generic.Stack<int> stack1 = new System.Collections.Generic.Stack<int>();
System.Collections.Generic.Stack<string> stack2 = new System.Collections.Generic.Stack<string>();

stack1.Push(1);
stack1.Push(2);
stack1.Push(3);
Console.WriteLine($"{stack1.Peek()}");
Console.WriteLine($"{stack1.Pop()}");
Console.WriteLine($"{stack1.Pop()}");
foreach(int i in stack1)
{
    Console.WriteLine("Осталось : " + i);
}

stack2.Push("ab");
stack2.Push("bc");
stack2.Push("cd");
Console.WriteLine($"{stack2.Peek()}");
Console.WriteLine($"{stack2.Pop()}");
Console.WriteLine($"{stack2.Pop()}");
foreach (var item in stack2)
{
    Console.WriteLine("Осталось : " + item);
}

//Task-3
Console.WriteLine();
Console.WriteLine("---------------------------Task-3---------------------------");
Console.WriteLine();
IRepository<Person> repository = new InMemoryRepository<Person>();

var person1=new Person {Id=1, Name="Komron", Age=19};
var person2 = new Person { Id = 2, Name = "Shahrom", Age = 20 };
var person3 = new Person { Id = 3, Name = "Ikrom", Age = 21 };
repository.Add(person1);
repository.Add(person2);
repository.Add(person3);
foreach (var person in repository.GetAll())
{
    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
}
repository.Remove(person1);
Console.WriteLine();

foreach (var person in repository.GetAll())
{
    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
}
Console.WriteLine();
var e=repository.GetById(2);
Console.WriteLine($"Id : {e.Id}, Name : {e.Name} Age : {e.Age}");

//Task-4
Console.WriteLine();
Console.WriteLine("---------------------------Task-4---------------------------");
Console.WriteLine();
Console.WriteLine("Int");
var list1 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
var (Min1, Max1) = Task4.FindMinMax(list1);
Console.WriteLine($"Min = {Min1} Max = {Max1}");

Console.WriteLine();
Console.WriteLine("Double");
var list2 = new List<double> { 3.1, 1.2, 4.3, 1.4, 5.5, 9.6, 2.7, 6.8, 5.9 };
var (doubleMin, doubleMax) = Task4.FindMinMax(list2);
Console.WriteLine($"Min = {doubleMin} Max = {doubleMax}");

Console.WriteLine();
Console.WriteLine("String");
var list3 = new List<string> { "Komron", "Eshon", "shahrom", "ehson"};
var (stringMin, stringMax) =Task4.FindMinMax(list3);
Console.WriteLine($"Min = \"{stringMin}\", Max = \"{stringMax}\"");
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.ReadKey();

