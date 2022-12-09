//생성자
//클래스에 생성자 메스드를 추가하면객체가 "생성"되는 시점에 해당 메서드를 자동으로 호출
using System;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("person 객체 생성되기 전.");
            Person person = new Person();
            Console.WriteLine("person 객체 생성된 후.");
        }
    }
    class Person
    {
        string name;

        public Person()
        {
            name = "홍길동";
            Console.WriteLine("생성자 호출");
        }
    }
}