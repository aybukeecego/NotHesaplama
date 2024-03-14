using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciNotHesaplama
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string ad = string.Empty;
			string soyad = string.Empty;
			int not1 = 0;
			int not2 = 0;
			int not3 = 0;

			Console.WriteLine("Öğrencinin Adını Giriniz");
			ad = Console.ReadLine();
			Console.WriteLine("Öğrencinin Soyadını Giriniz");
			soyad = Console.ReadLine();

			Console.WriteLine("Öğrencinin İlk Giriniz");
			not1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Öğrencinin İkinci Giriniz");
			not2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Öğrencinin Final Giriniz");
			not3 = Convert.ToInt32(Console.ReadLine());

			Ogrenci ogrenci = new Ogrenci();

			ogrenci.OgrenciNotHesaplama(ad, soyad, not1, not2, not3);

			Console.ReadKey();

		}
	}
}
