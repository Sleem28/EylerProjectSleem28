// Найдите сумму всех четных элементов ряда Фибоначчи, которые не превышают четыре миллиона.
Console.Clear();
long sumEvenFibo = 0;
int  secondFibo  = 1;
int  firstFibo   = 2;
int  currentFibo = -1;

while(currentFibo < 4000000)
{
    currentFibo = firstFibo + secondFibo;
    secondFibo  = firstFibo;
    firstFibo   = currentFibo;

    if(currentFibo % 2 == 0) sumEvenFibo += currentFibo;
}
Console.WriteLine($"Сумма всех четных чисел ряда фибоначча до 4 000 000 равна {sumEvenFibo}");