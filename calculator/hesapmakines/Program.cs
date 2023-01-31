// See https://aka.ms/new-console-template for more information
Console.Write("ilk sayıyı giriniz = ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("ikinci sayıyı griniz = ");
Double b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("1  Toplama");
Console.WriteLine("2  Çıkarma");
Console.WriteLine("3  Bölme");
Console.WriteLine("4  Çarpma");

Console.Write("yapmak istediğiniz işlem numarsını giriniz = ");
Double islem = Convert.ToInt32(Console.ReadLine());

if (islem == 1)
{
    Console.WriteLine(" Toplamla işlemi sonucu = "+ (a+b));
} 

else if(islem == 2)
{
    Console.WriteLine("Çıkarma işlemi Sonucu = " + (a - b));
   
}



else if (islem ==3)
{
    Console.WriteLine("Bölme işlemi sonucu = " + (a/b));

}

else if (islem == 4)
{
    Console.WriteLine("Çarpma işlemi sonucu = " + (a *b));
}

else
{
    Console.WriteLine("Geçersiz işlem numarası");
}