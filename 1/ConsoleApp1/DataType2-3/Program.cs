//명시적 변환 - 개발자가 명시적으로 형변환임을 알리는 방식
//ushort u = 65;
//char c = u; //기본적으로 char은 문자만 담을 수 있어 형변환 에러가뜸

ushort u = 65;
char c = (char)u; //의도된것으로 A가 65숫자값으로 표현이 가능해 괄호를 사용해 지정가능(명시적 변환)
Console.WriteLine(c); // A출력

int n = 40000;
short s = (short)n;
Console.WriteLine(s); //short는 -32,768 ~ 32,767의 범위를 가지고 있어 정상적으로 나오진 않는다
