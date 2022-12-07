//switch문

string text = "C#";

switch (text)
{
    case "C#": //실행할 코드 없으면 break 생략가능
    case "VB.NET":
        Console.WriteLine(".Net 호환 언어");
        break;

    case "JAVA":
        Console.WriteLine("JVM 언어");
        break;

    default: //생략가능
        Console.WriteLine("알 수 없음");
        break;
}