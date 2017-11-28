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
    public class UserController : ApiController
    {
		public UserBusiness UserBusiness { get; private set; }

		public UserController()
		{
			this.UserBusiness = new UserBusiness(new SqlUserRepository());
		}

		// GET: api/User
		public IEnumerable<User> Get()
		{
			return this.UserBusiness.GetUsers();
		}

		// POST: api/User
		public void Post([FromBody]User user)
		{
			this.UserBusiness.Create(user);
		}
	}
}
