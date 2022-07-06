void printGipo3D(double aX, double aY, double aZ, double bX, double bY, double bZ)
{
    double dX = aX - bX;
    double dY = aY- bY;
    double dZ = aZ - bZ;
    double rangeC = Math.Sqrt(dX * dX + dY * dY + dZ*dZ);
    System.Console.WriteLine(rangeC);
}

System.Console.WriteLine("Введите координаты ");
double aX = Convert.ToInt32(Console.ReadLine());
double aY = Convert.ToInt32(Console.ReadLine());
double aZ = Convert.ToInt32(Console.ReadLine());
double bX = Convert.ToInt32(Console.ReadLine());
double bY = Convert.ToInt32(Console.ReadLine());
double bZ = Convert.ToInt32(Console.ReadLine());
printGipo3D(aX, aY, aZ, bX, bY, bZ);