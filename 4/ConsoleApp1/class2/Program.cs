//Book타입
//클래스로 정의된 타입은 string처럼 모두 참조형으로 분류
//사용하려면 new 연산자로 메모리 할당을 해야함

namespace class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book gulliver = new Book(); //할당
        }
    }
}

class Book
{
    string Title;
    decimal ISBN13;
    string Contents;
    string Author;
    int PageCount;
}