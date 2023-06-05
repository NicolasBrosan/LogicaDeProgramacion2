namespace SumaDeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ar = Console.ReadLine().TrimEnd().Split(',').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = simpleArraySum(ar);

            Console.WriteLine(result);
        }

        public static int simpleArraySum(List<int> ar)
        {
             return ar.Sum();
        }
    }
}