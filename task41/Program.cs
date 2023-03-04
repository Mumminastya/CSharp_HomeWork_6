// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] Promt(string message)
{
    Console.WriteLine(message);
    var result = Console.ReadLine();
    var splitted = result.Split(",");
    int[] NewMassiv = new int[splitted.Length];
    for (int i = 0; i < splitted.Length; i++)
    {
        NewMassiv[i] = Convert.ToInt32(splitted[i]);
    }
    return NewMassiv;
}

void PrintMasssiv(int[] NewMassiv, int result)
{
    Console.WriteLine(string.Join(",",NewMassiv) + "->" + result.ToString());
}


int NumberMoreNule(int[] result)
{
   int count = 0;
   for(int i = 0; i < result.Length; i++)
   {
    if(result[i] > 0)
    {
        count++;
    }
    }
   return count;
}

int[] arr = Promt("Введите числа, сколько хотите: ");
int result = NumberMoreNule(arr);
PrintMasssiv(arr, result);