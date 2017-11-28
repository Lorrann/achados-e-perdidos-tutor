using AchadosPerdidos.Business.Business;
using AchadosPerdidos.Business.Model;
using AchadosPerdidos.Data.SqlRepository;
using System.Collections.Generic;
using System.Web.Http;

namespace AchadosPerdidos.WebAPI.Controllers
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

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]User user)
        {
            this.UserBusiness.Create(user);
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
