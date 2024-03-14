using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
	internal class Müşteri
	{
		private string _tcKimlikNo;

		public string TcKimlikNo { get
			{
				return (this._tcKimlikNo).Substring(0,3);
			}
			set 
			{
				if (value.Length==11 && IsNumeric(value)) 
				{
					_tcKimlikNo = value;
				}
				else 
				{
					Console.WriteLine("Yanlış Girildi");
				}
			}
		}

		private bool IsNumeric(string value) 
		{
			foreach(char c in value) 
			{
				if (!Char.IsDigit(c)) 
				{
					return false;
				}

				

			}
			return true;
		}

		public string domainAdress = "firmam.com";

		private string _emailAdress;

		public string EmailAdres { get
			{
				return this._emailAdress;
			}
			set 
			{
				this._emailAdress = value.ToLower() + "@" + this.domainAdress;
			}
		}
	}
}
