//연산자

//부호 연산자
string text = "Hello World"; //;(세미콜론)은 한 구문의 끝을 컴파일러에게 알리는 부호
Console.writeLine(text); 

string text2 = "Hello"; text2 = text2 + " World"; 
Console.writeLine(text2); //Hello World 출력

//대입 연산자, 산술 연산자(정수형, 실수형타입에 사용)
int n = 5;
int divider = 3;
int mod = n % divider; //%: 나누고 나머지 수 (5/3)
Console.writeLine(mod); //출력결과 2

//+(더하기)는 string 문자열과 더하는데도 사용
int n2 = 500;
Console.writeLine("n2 = " + n2); // 출력결과 n2 = 500