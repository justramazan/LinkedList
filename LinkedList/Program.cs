using LinkedList;

var list = new DoublyLinkedList<int>();
list.AddLast(3);   
list.AddLast(1);   
list.AddLast(2);

list.Sort();

foreach (var item in list)
{
    Console.WriteLine(item);
}
