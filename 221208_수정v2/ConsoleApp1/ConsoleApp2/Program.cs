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
    for (int i = 2; i <= intxt+1; i++) //최대 반복범위를 입력한값보다 크게 (2이하 숫자 입력대비)
    {
       if(intxt < 2) //1이하면 소수가 아님
        {
            Console.WriteLine("소수가 아닙니다. \n");
            break;
        }  
       
       if (i < intxt) //입력한숫자-1 까지 계산하기 위한 조건
       {
            if(intxt % i == 0) //2부터 입력한값-1 까지 계산해서 0이 나오는지 확인
            {
            Console.WriteLine("소수가 아닙니다. \n"); //2부터 입력한값-1 까지 계산해서 한번이라도 나누어 떨어지면 소수가 아님
            break;
            }
       }
       else //다 계산해서 안나오면 소수
       {
            Console.WriteLine("소수가 맞습니다. \n");
            break;
       }
           

    }
       
    
   
}