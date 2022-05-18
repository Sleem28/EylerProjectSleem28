//Найдите самый большой палиндром, полученный умножением двух трехзначных чисел.
Console.Clear();

int maxPolindrom = 0;
int min3DigNum   = 100;
int max3DigNum   = 999;
int tmpMutValue  = 0;
int maxFirstNum  = 0;
int maxSecondNum = 0;

for (int i = min3DigNum; i <= max3DigNum; i++)
{
    for (int k = i; k <= max3DigNum; k++)
    {
        tmpMutValue = IsPolindromom(i * k);
        if(tmpMutValue > maxPolindrom)
        {
            maxPolindrom = tmpMutValue;
            maxFirstNum  = i;
            maxSecondNum = k;
        }
         
    }
}

Console.WriteLine($"Максимальный полиндромом число {maxPolindrom} при перемножаемых числах {maxFirstNum} и {maxSecondNum}");

int IsPolindromom(int value)
{
    string sValue  = value.ToString();
    int halfLength = sValue.Length/2;
    int counter    = sValue.Length-1;

    for (int i = 0; i < halfLength; i++)
    {
        if(sValue[i] != sValue[counter]){return(-1);}
        counter--;
    }
    
    return(value);
}
