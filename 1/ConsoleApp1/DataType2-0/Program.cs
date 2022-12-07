//큰따옴표와 이스케이프 시퀀스를 사용하지 않고 순수한 문자로 취급하게 하기

//큰따옴표 표현
string text = "\"Hello World\""; //이스케이프 시퀀스를 활용한 큰따옴표 표현
string text2 = @"\tHello\nWorld"; //이스케이프 시퀀스로 간주하지 않고 순수 문자로 취급

Console.WriteLine(text); // "Hello World"
Console.WriteLine(text2); // \tHello\nWorld