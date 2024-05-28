using OnlineShoppingClient.Models;

namespace OnlineShoppingClient.Services
{
    public interface IAdminServices
    {
        void Register(Admin admin);
        Admin GetAdmin(string id);
        List<Admin> GetAllAdmin();
        Admin Validate(string email, string pwd);
        void Update(Admin admin);
        void Delete(string AdminId);
    }
}
