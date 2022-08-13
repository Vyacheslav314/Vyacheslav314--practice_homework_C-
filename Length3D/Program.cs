int aX = ReadInt("Введите координаты первой точки по оси х: "); 
int aY = ReadInt("Введите координаты первой точки по оси у: "); 
int aZ = ReadInt("Введите координаты первой точки по оси z: ");  
int bX = ReadInt("Введите координаты второй точки по оси х: "); 
int bY = ReadInt("Введите координаты второй точки по оси у: "); 
int bZ = ReadInt("Введите координаты второй точки по оси z: ");

int lengthX = aX - bX;
int lengthY = aY - bY;
int lengthZ = aZ - bZ;
double distance = Math.Sqrt(lengthX * lengthX + lengthY * lengthY + lengthZ * lengthZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);   
    return Convert.ToInt32(Console.ReadLine());
}
