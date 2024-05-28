using OnlineShoppingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public interface IAdminServices
    {
        public void Delete(string Id);
        public Admin GetAdmin(string Id);
        public List<Admin> GetAllAdmins();
        public void Register(Admin admin);
        public void Update(Admin admin);
        public Admin Validate(string email, string password);

    }
}
