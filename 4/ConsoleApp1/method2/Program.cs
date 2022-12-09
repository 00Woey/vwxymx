//메서드

namespace method2
{
    internal class Program
    {
        class Mathematics
        {
            public int GetAreaOfSquare(int x)
            {
                return x * x;
            }

            public int GetValue() //값만 반환
            {
                return 10;
            }

            
            public void Output(string prefix, int value)
            {
                Console.WriteLine(prefix + value);
            }

        }
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.GetAreaOfSquare(m.GetValue()); //getvalue가 10을 받고 getareaofsquare에서 10*10
            m.Output("결과: ", result); //결과: 100
        }
    }
}