using System.Collections.Generic;
namespace Variant3;
public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();
    public void AddItem(T item)
    {
        _items.Add(item);
    }
    public long GetTotalSize()
    {
        long sizeTotal = 0;
        foreach (var item in _items)
        {
            sizeTotal += item.GetSize();
        }

        return sizeTotal;
    }
}
