//윤년
int intxt = 0; //입력받을 값 변환
string intxtc; //입력받을값
int num = 0; //숫자 비교용 
bool numc; //숫자인지 판단용


while (true)
{
    Console.Write("년도 입력: ");
    intxtc = Console.ReadLine();
    numc = int.TryParse(intxtc, out num);
    if (numc != true)
    {
        Console.WriteLine("숫자가 아닙니다. \n");
        continue;
    }

    intxt = Int32.Parse(intxtc);//나머지 계산을 위한 형변환

    if (intxt <= 0) //0포함 -이하 숫자를 적을시 안내
    {
        Console.WriteLine("1이상의 숫자를 적어주세요. \n");
        continue;
    }

    /*
    윤년은 4로 나눠지거나 100으로 안나눠지면 윤년
    4로 나눠지거나 100으로 나눠지면 평년
    100으로 나눠지거나 400으로도 나눠지면 윤년
    */

    if (intxt % 4 == 0 && intxt % 100 != 0)
    {
        Console.WriteLine("윤년입니다. \n");
    }
    else if (intxt % 4 == 0 && intxt % 100 == 0 && intxt % 400 == 0)
    {
        Console.WriteLine("윤년입니다. \n");
    }
    else
    {
        Console.WriteLine("윤년이 아닙니다. \n");
    }

}

