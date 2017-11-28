using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AchadosPerdidos.WebAPI.Controllers
{
	public class ProductController : ApiController
	{
		public ProductBusines ProductBusines { get; private set; }

		public ProductController()
		{
			this.ProductBusines = new ProductBusines(new SqlProductRepository());
		}

		// GET api/<controller>
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<controller>/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]Product product)
		{
			this.ProductBusines.Create(product);
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}