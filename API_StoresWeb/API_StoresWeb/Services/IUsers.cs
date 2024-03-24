using API_StoresWeb.Models;

namespace API_StoresWeb.Services
{
    public interface IUsers
    {
        public List<UsersModel> findAllUsers();
        public UsersModel findUserByID( int ID);
        public UsersModel findUserByCode(string Code);
    }
}
