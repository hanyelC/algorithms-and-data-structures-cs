var list = new DataStructures.LinkedList<int>();
list.Push(1);
list.Push(2);


Console.WriteLine($"list.Size() => {list.Size()}");

Console.WriteLine($"node => {list.Pop()}");
Console.WriteLine($"node => {list.RemoveAt(0)}");

Console.WriteLine($"list.Size() => {list.Size()}");