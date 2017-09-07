using AchadosPerdidos.Business.Model;
using AchadosPerdidos.Business.Repository;

namespace AchadosPerdidos.Business.Business
{
    public class UserBusiness
    {
        private IUserRepository UserRepository { get; set; }

        public UserBusiness(IUserRepository userRepository)
        {
            this.UserRepository = userRepository;
        }

        public void Create(User user)
        {
            this.UserRepository.Create(user);
        }
    }
}
