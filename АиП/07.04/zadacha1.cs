// 07.04.25 задание 1
using System;
using System.Collections.Generic;

public struct CustomList<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void RemoveItem(int index)
    {
        if(!(index < 0 || index >= items.Count))
        {
            items.RemoveAt(index);
        }
        else{
          Console.WriteLine("index out of range");
        }
    }

    public T GetItem(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            Console.WriteLine("index is out of range");
        }
        return items[index];
    }
}
internal struct Program
{
    private static void Main(string[] args)
    {
        CustomList<int> customList = new CustomList<int>();

        customList.AddItem(5);
        customList.AddItem(2);
        customList.AddItem(33);

        customList.RemoveItem(1);

        Console.WriteLine(customList.GetItem(0));
        Console.WriteLine(customList.GetItem(1));
    }
}