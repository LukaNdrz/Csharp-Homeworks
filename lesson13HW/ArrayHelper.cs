namespace lesson13HW
{
    internal static class ArrayHelper
    {
        public static void PrintReverse<T>(T[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static T GetFirstElement<T>(T[] array)
        {

            return array[0];
        }

        public static T GetLastElement<T>(T[] array)
        {
            return array[array.Length - 1];
        }

        public static bool ContainsElement<T>(T[] array, T element)
        {
            foreach (var item in array)
            {
                if (item.Equals(element))
                {
                    return true;
                }
            }
            return default;
        }

        public static int CountElements<T>(T[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                count++;
            }
            return count;
        }

        public static int FindIndex<T>(T[] array, T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public static T[] Swap<T>(this T[] arr, int index1, int index2)
        {
            T temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;


            return arr;
        }
    }
}
