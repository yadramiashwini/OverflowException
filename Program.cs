namespace OverflowExceptionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int a = int.MaxValue;
                    Console.WriteLine(a + 1);
                }
            }
            catch (OverflowException ov) 
            {
                Console.WriteLine("its out of range");
            }
        }
    }
}
