//유니코드: 다국어 지원을 위한 문자 집합
//키보드로 입력할 수 없는 문자를 표현하기 위해 이스케이프 시퀀스라는 표현을 씀

char ch1 = '\t'; //\t는 키보드의 TAB을 문자로 표현(수평 탭)
char ch2 = 'T'; //ch2변수에 문자T 저장
char ch3 = '\n'; //\n은 개행(New Line/줄바꿈) 표현
char ch4 = 'o'; //ch4변수에 문자o 저장

Console.WriteLine(ch1); //수평 탭
Console.WriteLine(ch2); //T출력
Console.WriteLine(ch3); //엔터(줄바꿈)
Console.WriteLine(ch4); //o출력