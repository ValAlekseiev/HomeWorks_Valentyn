public class BubbleSort<T> where T : IComparable<T>
{
    public static void Sort(T[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    private static void Swap(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
