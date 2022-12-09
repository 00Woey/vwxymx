//중복코드제거

namespace erase
{
    class Mathematics
    {
        public void PrintIfEven(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine(value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Mathematics m = new Mathematics();
            int x = 5;
            m.PrintIfEven(x);

            x = 10;
            m.PrintIfEven(x);
        }
    }
}