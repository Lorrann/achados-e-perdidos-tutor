using AchadosPerdidos.Business.Model;
using System.Collections.Generic;

namespace AchadosPerdidos.Business.Repository
{
    public interface IUserRepository
    {
        void Create(User user);

        IEnumerable<User> GetUsers();
    }
}
