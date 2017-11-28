using AchadosPerdidos.Business.Model;
using AchadosPerdidos.Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Business.Business
{
	public class ProductBusiness
	{
		private IProducRepository ProductRepository { get; set; }

		public ProductBusiness(IProducRepository productRepository)
		{
			this.ProductRepository = productRepository;
		}

		public void Create(Product user)
		{
			this.ProductRepository.Create(user);
		}
	}
}
