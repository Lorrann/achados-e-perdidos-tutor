using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Business.Model
{
	public class Product
	{
		private string _type;
		public string Type {
			get{ return _type; }
			set
			{
				if (string.IsNullOrEmpty(value)) throw new Exception("Tipo é um campo obrigatório");
				this._type = value;
			}
		}

		private string _color;
		public string Color
		{
			get { return _color; }
			set
			{
				if (string.IsNullOrEmpty(value)) throw new Exception("Cor é um campo obrigatório");
			}
		}

		public string Size { get; set; }
	}
}
