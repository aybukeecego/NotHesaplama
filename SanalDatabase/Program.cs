using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalDatabase
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Musteri yeniMusteri= new Musteri();
			yeniMusteri.ID = 1;
			yeniMusteri.İsim = "Aybüke";
			yeniMusteri.Soyisim = "Cego";
			yeniMusteri.Sifre = "1234";
			yeniMusteri.KullanıcıAdı = "aybukecego";
			yeniMusteri.EmailAdress = "aybuke.cego";

			Musteri.MusteriEkle(yeniMusteri);
			Console.WriteLine(yeniMusteri);
			Console.ReadKey();

			Musteri yeniMusteri2 = new Musteri();
			yeniMusteri2.ID = 1;
			yeniMusteri2.İsim = "Aybüke";
			yeniMusteri2.Soyisim = "Cego";
			yeniMusteri2.Sifre = "1234";
			yeniMusteri2.KullanıcıAdı = "aaa";
			yeniMusteri2.EmailAdress = "aybuke";

			Musteri.MusteriEkle(yeniMusteri2);
		}
	}
}
