// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int getUserData(string massage)
{
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int numberM = getUserData("Напишите сколько чисел с клавиатуры введет пользователь");
Console.WriteLine();
int count = 0;
for (int i = 0; i < numberM; i++)
{
  
    int volue = int.Parse(Console.ReadLine()!);
    if (volue >0)
    {
        count = count +1;
    }
}
    Console.WriteLine($"Пользователь ввел {count}  числа больше 0");


/*int getUserData(string massage)
{
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int EnterVolue(int number)
{
    int volue = 0;
    for (int i = 0; i < number; i++)
    {

        volue = int.Parse(Console.ReadLine()!);

    }
    return volue;
}

int Counting(int volue, int number)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        if (volue > 0)
        {
            count = count + 1;
        }
        
    }
    return count;
}


    int numberM = getUserData("Напишите сколько чисел с клавиатуры введет пользователь");
    Console.WriteLine();
    int volue1 = EnterVolue(numberM);
    int count = Counting(volue1,numberM);
    Console.WriteLine($"Пользователь ввел {count}  числа больше 0");
    */
    