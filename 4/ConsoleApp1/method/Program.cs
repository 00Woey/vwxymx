//메서드 - 함수
//Type에는 속성과 행위를 정의한다 속성은 필드로 표현되고 행위는 메서드로 표현된다

//제곱메서드
namespace method
{
    internal class Program
    {
        class Mathematics
        {
            public int f(int x)
            {
                return x * x;
            }
        }
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.f(5); //result는 mathematics 클래스의 5*5
            Console.WriteLine(result); //출력: 25
        }
    }
}