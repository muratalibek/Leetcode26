namespace Leetcode26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of an Array!");
            int arraySize = Convert.ToInt16(Console.ReadLine());
            int k = 0;
            Console.WriteLine("Array size equal to " + arraySize);

            Console.WriteLine("Enter array elements: ");
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            int[] arrayClean = array.Distinct().ToArray();
            // Manual dublicated array element searching code
            //-----------------------------------------------
            //for (int i = 0; i<arraySize; i++)
            //{
            //    for(int j = i; j < arraySize; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            k++;
            //        }
            //    }
            //}
            k = arrayClean.Length;
            for (int i = 0; i < arrayClean.Length; i++)
            {
                Console.Write(arrayClean[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}