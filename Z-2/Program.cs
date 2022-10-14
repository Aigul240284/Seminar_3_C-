// Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int x1, y1, z1, x2, y2, z2;

x1 = Koords("Введите координату x числа А: ");
y1 = Koords("Введите координату y числа А: ");
z1 = Koords("Введите координату z числа А: ");
x2 = Koords("Введите координату x числа B: ");
y2 = Koords("Введите координату y числа B: ");
z2 = Koords("Введите координату z числа B: ");
double distanse = Distanse(x1,y1,z1,x2,y2,z2);
Console.WriteLine(distanse);

int Koords(string message)
{
    Console.Write(message);
    int result = int.Parse (Console.ReadLine() ?? "");
    return result;

}
double Distanse (int x1, int y1, int z1, int x2, int y2, int z2)

{
    double result = Math.Sqrt(Math.Pow(x2-x1,2)+
                              Math.Pow(y2-y1,2)+
                              Math.Pow(z2- z1,2));
    return result;
}