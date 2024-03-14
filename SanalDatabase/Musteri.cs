using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalDatabase
{
	internal class Musteri
	{
		 static ArrayList DataBase;

		static Musteri() 
		{
			DataBase = new ArrayList();
		}

		public int ID { get; set; }
		public string İsim { get; set; }

		public string Soyisim  { get; set; }

		public string EmailAdress { get; set; }

		private string _kullanıcıAdı;
		public string KullanıcıAdı 
		{ 
			get 
			{ 
				return this._kullanıcıAdı; 
			} 
			set 
			{
				bool result=MusteriKontrol(value);
				if (result)
					Console.WriteLine("Eklemek istediğiniz kullanıcı adı mevcut");
				else 
				{
					this._kullanıcıAdı = value;
				}

			} 
		}

		public string Sifre { get; set; }

	   static bool MusteriKontrol(string kullanıcıAdı)
		{
			bool result = false;

			for (int i = 0; i < DataBase.Count; i++) 
			{
				Musteri m = (Musteri)DataBase[i];
				if(m.KullanıcıAdı==kullanıcıAdı)
				{
					result = true;
					break;
				}
			}

			return result;

		}

		static bool MusteriEmailKontrol(string email) 
		{
			bool result = false;
			for(int i=0; i<DataBase.Count; i++)
			{
				Musteri m = (Musteri)DataBase[i];

				if (m.EmailAdress == email)
					result = true;

			}
			return result;

		}

		public static void MusteriEkle(Musteri M) 
		{
			if(M !=null && !string.IsNullOrEmpty(M.KullanıcıAdı) && !string.IsNullOrEmpty(M.EmailAdress)) 
			{
				bool emailKontrol = MusteriEmailKontrol(M.EmailAdress);

				if (emailKontrol)
					Console.WriteLine("Eklemek istediğiniz mail mevcut");
				else
					DataBase.Add(M);
			}

		}
	}
}
