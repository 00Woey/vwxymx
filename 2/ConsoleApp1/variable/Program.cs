//변수는 식별자의 하나로서 변수가 선언됐을 때 지정된 형식에 맞는 저장소가 메모리에 할당돼 값을 담아 놓을 수 있는 역할

int n = 5; //메모리에 n이름을 가진 int(4바이트)용량의 저장소에 5를 넣는다.

n = 10; //언제든 그 십별자가 가리키는 값은 바뀔 수 있다.

string text; //값을 할당하지 않은 string 변수는 null값을 가진다

string text2 = null;

string name = "C#";
name = null; //또는 참조형 변수가 더는 사용되지 않음을 명시하기 위해 null을 할당하기도함.

int n1 = 5;
int n2 = n1;

Console.WriteLine(n1);
Console.WriteLine(n2);

string txt1 = "C#";
string txt2 = txt1;

Console.WriteLine(txt1);
Console.WriteLine(txt2);
//변수에 변수값을 대입가능
