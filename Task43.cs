// See https://aka.ms/new-console-template for more information

double x = 0;
double y = 0;
Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 != k2) {
    x = (b1 - b2)/-(k1 - k2);
    y = (k2 * x) + b2;
    Console.WriteLine($"({x};{y})");
}
else {
    Console.WriteLine("Прямые параллельны");
}