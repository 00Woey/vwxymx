//소수 구하기
int intxt = 0; //입력받을 값 변환
string intxtc; //입력받을값
int num = 0; //숫자 비교용 
bool numc; //숫자인지 판단용


while (true)
{
    Console.Write("숫자 입력: ");
    intxtc = Console.ReadLine();

    numc = int.TryParse(intxtc, out num);
    if (numc != true)
    {
        Console.WriteLine("숫자가 아닙니다. \n");
        continue;
    }

    intxt = Int32.Parse(intxtc);//소수 계산을 위한 형변환

    if (intxt <= 0) //0포함 -이하 숫자를 적을시 안내
    {
        Console.WriteLine("1이상의 숫자를 적어주세요. \n");
        continue;
    }


    for (int i = 2; i <= 10; i++) //소수: 0, 1제외 1과 자기자신으로만 나눠지는경우
    {
        if (intxt == 1 || intxt % i == 0)
        {
            Console.WriteLine("소수가 아닙니다. \n");
            break;
        }
        else
        {
            Console.WriteLine("소수가 맞습니다. \n");
            break;        
        }

    }
   
}