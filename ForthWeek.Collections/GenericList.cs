namespace ForthWeek.Collections;
public class GenericList<T>
{
    private List<T> _genericList = new List<T>();
    public bool Add(T input)
    {
        _genericList.Add(input);
        return true;
    }

    public T this[int index]
    {
        get { return _genericList[index]; }
    }
}

