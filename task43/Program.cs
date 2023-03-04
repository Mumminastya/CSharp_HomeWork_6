// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Promt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void IntersectionPoint(int b1, int k1, int b2, int k2)
{
    double x = (b2 * 1.0 - b1) / (k1 - k2);
    double y = k1*x + b1;
    string r = $"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({x};{y})";
    Console.WriteLine(r);
}

int b1 = Promt("Введите значение b1: ");
int k1 = Promt("Введите значение k1: ");
int b2 = Promt("Введите значение b2: ");
int k2 = Promt("Введите значение k2: ");
IntersectionPoint(b1, k1, b2, k2);