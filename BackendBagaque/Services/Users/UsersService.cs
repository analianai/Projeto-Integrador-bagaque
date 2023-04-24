using BackendBagaque.Date;
using Microsoft.EntityFrameworkCore;

namespace BackendBagaque.Services.Users
{
    public class UsersService
    {
        private readonly BagaqueDBContext context;

        public UsersService (BagaqueDBContext context)
        {
            this.context = context;
        }

        public List<Models.Users> GetAll()
        {
            return context.Users.ToList();
        }

        public Models.Users? GetOne(int IdUser)
        {
            var user = context.Users.Find(IdUser);
            return user;
        }

        public Models.Users Create(Models.Users user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public void Update(int IdUser, Models.Users user)
        {
            var userToUpdate = context.Users.Find(IdUser);
            if (userToUpdate != null)
            {
                userToUpdate.Names = user.Names;
                userToUpdate.CPF = user.CPF;
                userToUpdate.Phone = user.Phone;
                userToUpdate.PasswordLogin = user.PasswordLogin;
                userToUpdate.EmailLogin = user.EmailLogin;
                userToUpdate.PostalCode = user.PostalCode;
                userToUpdate.NumberAddress = user.NumberAddress;
                userToUpdate.Type = user.Type;

        context.SaveChanges();
            }
            else
            {
                throw new Exception("Usuário não encontrado para o ID" + IdUser);
            }
        }

        public void Delete(int IdUser)
        {
            var userToRemove = context.Users.Find(IdUser);
            if (userToRemove != null)
            {
                context.Users.Remove(userToRemove);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Usuário não encontrado para o id " + IdUser);
            }
        }
    }
}

