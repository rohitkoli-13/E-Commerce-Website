using OnlineShoppingManagement.Entities;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly ProjectDbContext _projectdbContext;

        public AdminServices(ProjectDbContext projectdbContext)
        {
            _projectdbContext = projectdbContext;
        }

        //public AdminServices()
        //{
        //    _projectdbContext = new ProjectDbContext();
        //}
        public void Delete(string id)
        {
            try
            {
                Admin admin = _projectdbContext.Admins.Find(id);
                _projectdbContext.Admins.Remove(admin);
                _projectdbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Admin GetAdmin(string id)
        {
            try
            {
                Admin admin = _projectdbContext.Admins.Find(id);
                return admin;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Admin> GetAllAdmins()
        {
            try
            {
                List<Admin> admins = _projectdbContext.Admins.ToList();
                return admins;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Register(Admin admin)
        {
            try
            {
                _projectdbContext.Admins.Add(admin);
                _projectdbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Admin admin)
        {
            try
            {
                _projectdbContext.Admins.Update(admin);
                _projectdbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Admin Validate(string email, string password)
        {
            Admin admin = _projectdbContext.Admins.SingleOrDefault(a => a.AdminEmail == email && a.AdminPassword == password);
            return admin;
        }
    }
}
