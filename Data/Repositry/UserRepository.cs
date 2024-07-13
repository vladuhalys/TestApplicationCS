using Data.Source.Remote.Service;
using Domain.Repository;
using Domain.UseCase;

namespace Data.Repositry
{
    public class UserRepository : IUserRepository
    {
        public void GetAuthUser(UserUseCase userUse)
        {
            // Call the AuthService to get the user
            MyAuthService.Login(userUse.GetUserEmail(), userUse.GetPasswordEmail());
        }
           
    }
}
