//goto 문
// goto문과 if문만 있으면 for/foreach/while/do를 모두 대체할 수 있다.

int sum = 0;
int n = 0;

LOOP:
    n ++;
    if (n>1000)
    {
        goto LOOPEXIT;
    }

    if ((n % 2) != 0) goto LOOP;

    sum += n;

    goto LOOP;

LOOPEXIT:
    Console.writeLine(sum);
