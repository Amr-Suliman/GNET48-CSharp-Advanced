class FindMaxHelper
{
    public static T FindMax<T>(T first, T second) where T : IComparable<T>
    {
        if (first.CompareTo(second) > 0)
            return first;

        return second;
    }
}