﻿//식별자2
// int 1n = 5;     식별자의 시작문자는 숫자로 시작할수 없고 반드시 문자여야함
int n1 = 5; //올바른 예

int _n = 5; //특수문자중 유일하게 밑줄만 시작문자로 사용 가능

int 변수 = 5; // 유니코드 범위 문자도 허용되어 '한글' 식별자도 가능

//string @bool = "true"; //예약어를 식별자로 사용할 수 없다 @문자를 붙여 식별자로 인식하게 할수있다.

string \u0062ool = "true"; //드물지만 이스케이프 시퀀스로도 식별자 사용가능 [bool]
Console.WriteLine(\u0062ool);
