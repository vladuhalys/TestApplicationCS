

using Domain.Entities;

namespace Domain.UseCase
{
    public class UserUseCase
    {
        private User user { set; get; }

        public UserUseCase()
        {
            user = new User();
        }

        public UserUseCase(int id, string name, string email, string password)
        {
            user = new User(id, name, email, password);
        }

        public string GetUserName()
        {
            return user.Name;
        }

        public string GetUserEmail()
        {
            return user.Email;
        }
        public string GetPasswordEmail()
        {
            return user.Password;
        }


    }
}
