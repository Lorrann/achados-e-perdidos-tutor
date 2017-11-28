using AchadosPerdidos.Business.Business;
using AchadosPerdidos.Business.Model;
using AchadosPerdidos.Data.SqlRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AchadosPerdidos.WebAPI_.Controllers
{
    public class ProductController : ApiController
    {
		public ProductBusiness ProductBusiness { get; private set; }

		public ProductController()
		{
			this.ProductBusiness = new ProductBusiness(new SqlProductRepository());
		}

		// POST: api/User
		public void Post([FromBody]Product product)
		{
			this.ProductBusiness.Create(product);
		}
	}
}
