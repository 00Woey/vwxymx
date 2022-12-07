//상수 - 변수와 다르게 상수 식별자에는 값이 한 번 대입되면 그 이후로 다른 값을 대입할수없음
//사용법 - 변주를 정의하는 구문에 const 예악어를 붙여주면 됨

const bool result = false;
const int n = 5;
const string text = "Hello";

result = true; //컴파일 오류 발생

int n - Math.Max(0, 5); //프로그램을 실행할 때 n의 값이 결정된다.
                        //0과 5중에서 5가 크므로 변수 n에는 5가 대입.

const int maxN = Math.Max(0, 5); //Math.Max 메서드가 실행된 이후에 값이 결정되기때문에 미리 값을 알수 없어 오류

const int n = 5 * 100 / 2; //이러한 단순 수식은 컴파일러가 값을 계산할 수 있다