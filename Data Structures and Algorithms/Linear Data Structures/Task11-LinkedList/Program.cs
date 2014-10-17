namespace Task11_LinkedList
{
    using System;

    /// <summary>
    /// Implement the data structure linked list. Define a class ListItem<T> that has two 
    /// fields: value (of type T) and NextItem (of type ListItem<T>). Define additionally 
    /// a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
    /// </summary>
    public class Program
    {
        static void Main()
        {
            var count = 15;
            var list = new LinkedListCustom<int>();

            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
