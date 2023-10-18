
using System.Security.Principal;

Console.WriteLine("Lütfen dizinin eleman sayısını giriniz..");

int diziLength = int.Parse(Console.ReadLine());

int[] sayilar = new int[diziLength];
for (var i = 0; i < diziLength; i++)
{
    Console.WriteLine("Lütfen dizinin {0}. elemanlarını giriniz..",i+1);
    sayilar[i] = int.Parse(Console.ReadLine());

}
int toplam =0;
foreach (var sayi in sayilar)
{
    toplam += sayi;
}
Console.WriteLine("Dizinizin ortalamsı :" + (toplam/diziLength) );