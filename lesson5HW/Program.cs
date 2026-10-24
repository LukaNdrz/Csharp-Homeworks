namespace me6gakvetili
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] num1 = [20, 30, 60];
            //int[] num2 = [53, 65, 90];

            //int[] resultArray = new int[num1.Length + num2.Length];
            //for (int i = 0; i < resultArray.Length; i++)
            //{
            //    resultArray[1] = num1[1];
            //}
            //for (int i = 0; i < resultArray.Length; i++)
            //{
            //    resultArray[num1.Length + i] = num2[i];
            //}



            int[] nums = [3, 5, -4, 8, 11, 1, -1, 6];
            int count = 0;

            Console.WriteLine("enter number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == number)
                    {
                        count++;

                    }
                }
            }

            int[][] result = new int[count][];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == number)
                    {
                        result[index] = [nums[i], nums[j]];
                        index++;
                    }
                }
            }

            foreach (var numbers in result)
            {
                foreach (var item in numbers)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }







        }
    }
}
