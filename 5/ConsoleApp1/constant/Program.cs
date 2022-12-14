//상수
//접근)제한자 const 상수타입 식별자 = 값;
//Readonly랑 차이점 상수는 static 예악어 허용X, 반드시 상수정의와 함계 값을 대입해야함(생성자 접근 X)등

namespace constant
{
    internal class Program
    {
        const string TEXT = "변수의 값: ";

        //상수 개별로표현
        const int Sunday = 0;
        const int Monday = 1;
        const int Tuesday = 2;
        const int Wednesday = 3;
        const int Thursday = 4;
        const int Friday = 5;
        const int Saturday = 5;

        enum Days //enum 타입 묶기
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine("x 변수의 값: " + x);
            Console.WriteLine("y 변수의 값: " + y);

            System.Console.WriteLine("x" + TEXT + x);
            System.Console.WriteLine("y" + TEXT + y);

            Console.WriteLine("sbyte: " + sbyte.MinValue + " ~ " + sbyte.MaxValue); 
            Console.WriteLine("byte: " + byte.MinValue + " ~ " + byte.MaxValue);
            Console.WriteLine("short: " + short.MinValue + " ~ " + short.MaxValue);
            Console.WriteLine("ushort: " + ushort.MinValue + " ~ " + ushort.MaxValue);
            Console.WriteLine("char: " + (int)char.MinValue + " ~ " + (int)char.MaxValue);
            Console.WriteLine("sbyte: " + sbyte.MinValue + " ~ " + sbyte.MaxValue);
            Console.WriteLine("int: " + int.MinValue + " ~ " + int.MaxValue);
            Console.WriteLine("uint: " + uint.MinValue + " ~ " + uint.MaxValue);
            Console.WriteLine("long: " + long.MinValue + " ~ " + long.MaxValue);
            Console.WriteLine("ulong: " + ulong.MinValue + " ~ " + ulong.MaxValue);
            Console.WriteLine("float: " + float.MinValue + " ~ " + float.MaxValue);
            Console.WriteLine("double: " + double.MinValue + " ~ " + double.MaxValue);
            Console.WriteLine("decimal: " + decimal.MinValue + " ~ " + decimal.MaxValue);
        }
    }
}