using System.Collections.Generic;
using System.Linq;

public class RecursionOps
{
    public int Sum(IEnumerable<int> array)
    {
        if (array.Count() == 1)
            return array.First();
        return array.First() + Sum(array.Skip(1));
    }

    public int Count<T>(IEnumerable<T> list)
    {
        if (!list.Any())
            return 0;
        return 1 + Count(list.Skip(1));
    }

    public int FindBiggest(IEnumerable<int> array)
    {
        if (array.Count() != 1)
            return array.ElementAt(0) > array.Last() ?
                    FindBiggest(array.SkipLast(1)) : FindBiggest(array.Skip(1));

        return array.First();
    }

}