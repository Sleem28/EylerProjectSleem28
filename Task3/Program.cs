// Каков самый большой делитель числа 600851475143, являющийся простым числом?
long num = 600851475143;
long dev = 0;

for(long i = num; i > 0; i--)
{
    if(isSimple(i) && num%i == 0)
    {
        dev = i;
        break;
    }
     
}
Console.WriteLine($"Cамый большой делитель числа {num}: " + dev);

bool isSimple(long value)
{
    for (int i = 2; i < value; i++)
    {
        if(value%i == 0) return(false);
    }
    return(true);
}