//필드
//정의된 속성을 C#에서 필드라한다

namespace field
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book gulliver = new Book();
            
            //필드에 값을 대입: 객체.필드명 = 필드의타입과일치하는 표현식;
            gulliver.Author = "Jonathan Swift";
            gulliver.ISBN13 = 9788983920775m;
            gulliver.Title = "걸리버 여행기";
            gulliver.Contents = "...";
            gulliver.PageCount = 384;

            //필드로부터 값을 가져옴: 필드의타입과일치하는변수 = 객체.필드명;
            string author = gulliver.Author;
            decimal isbn13 = gulliver.ISBN13;
            string title = gulliver.Title;
            string contents = gulliver.Contents;
            int pageCount = gulliver.PageCount;
        }
    }
    class Book
    {
        public string Title;
        public decimal ISBN13;
        public string Contents;
        public string Author;
        public int PageCount;
    }

}