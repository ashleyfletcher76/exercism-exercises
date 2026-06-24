public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach(var item in collection)
        {
            yield return func(item);
        }
    }
}

// using a collection we should perform an operation of each element
// return a new collection with the result of applying this operation each element