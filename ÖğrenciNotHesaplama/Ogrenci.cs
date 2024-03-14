using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciNotHesaplama
{
	public class Ogrenci
	{

		public void OgrenciNotHesaplama(string ad, string soyad, int not1, int not2, int not3) 
		{
			Console.WriteLine("Öğrenci Bilgileri Aşağıdaki Gibidir");
			Console.WriteLine("Ad : {0} , Soyad : {1} ",ad,soyad);

			decimal ortalama= NotOrtalaması(not1,not2,not3);

			if (ortalama < 45)

				Console.WriteLine("Ders Tekrarı");

			else
				Console.WriteLine("Öğrenci Dersi Geçti");


		}

		private decimal NotOrtalaması(int not1, int not2, int not3) 
		{
			decimal ort = not1 + not2 + not3 / 3;
			return ort;
			
		}
	}
}
