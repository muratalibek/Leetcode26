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
            string[] arrayConverted  = arrayClean.Select(x => x.ToString()).ToArray();
            for (int i = arrayClean.Length; i < array.Length; i++)
            {
                arrayConverted[i] = "_";
            }
            k = arrayClean.Length;
            for (int i = 0; i < arrayConverted.Length; i++)
            {
                Console.Write(arrayConverted[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}