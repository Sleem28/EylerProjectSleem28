//Какое самое маленькое число делится нацело на все числа от 1 до 20?
double divNum = 20;
bool   found  = false;
while (true)
{
    for (int i = 1; i <= 20; i++)
    {
        if(divNum % i != 0) break;
        else if(i == 20) found = true;
    }
    if(found) break;
    divNum++;
}

System.Console.WriteLine(divNum);
System.Console.WriteLine();

for (int j = 1; j <= 20; j++)
{
    System.Console.WriteLine($"{divNum} / {j} = {divNum/j}");
}

