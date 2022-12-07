//배열 - 같은 데이터 유형의 변수를 여러개 사용해야 할 떄
int [] products = new int[3];
string [] names = new string[1000]; // 배열의 경우 [](대괄호)를 사용한다

//연속적으로 할당된 요소에 대해 개별적으로 접근
products[0] = 100;
products[1] = 200; //배열 시작 번호는 1이 아닌 0부터 시작

int book = products[0];

int sum = products[0] + products[1]; //대괄호 안에 지정된 수를 index라고 한다
