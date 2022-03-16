// See https://aka.ms/new-console-template for more information
//Задача 19
Console.WriteLine ("Введите пятизначное число");
string palindrom = Console.ReadLine();
if (palindrom.Length ==5)
 {
  
   if (palindrom[0]==palindrom[4]&& palindrom[1]==palindrom[3])
    {
   Console.WriteLine ("Введенное число - палиндром");
    }
   else
{
  Console.WriteLine ("Введенное число не является палиндромом");
}
 }
 else
 {
Console.WriteLine ("Ошибка. Введите пятизначное число");
 }



//Задача 21
Random rnd = new Random();
int x = rnd.Next (1,10);
int y = rnd.Next (1,10);
int z = rnd.Next (1,10);
int a = rnd.Next (1,10);
int b = rnd.Next (1,10);
int c = rnd.Next (1,10);
Console.WriteLine ( " А ("+x+","+y+","+z+ ");" + "B ("+a+","+b+","+c+");");
int Podschet = ((x-a) * (x-a)) + ((y-b) * (y-b)) + ((z-c) * (z-c));
double distant_AB = Math.Sqrt (Podschet);
Console.WriteLine ( "Расстояние между точками А и В = " +distant_AB);


//Задача 23
Console.WriteLine ("Введите число:  ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Таблица кубов введенного числа: ");
for ( int i=1;i<=n;i++)
{
    int cub = i*i*i;
    
    Console.WriteLine( cub);
}


