using OnlineShoppingManagement.Entities;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public class FavouriteServices : IFavouriteServices
    {
        private readonly ProjectDbContext _projectDbContext;

        public FavouriteServices(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        //public FavouriteServices()
        //{
        //    _projectDbContext = new ProjectDbContext();
        //}
        public void Add(Favourite favourite)
        {
            try
            {
                _projectDbContext.Favourites.Add(favourite);
                _projectDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(string id)
        {
            try
            {
                Favourite favourite = _projectDbContext.Favourites.Find(id);
                _projectDbContext.Favourites.Remove(favourite);
                _projectDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Favourite> GetAll()
        {
            try
            {
                List<Favourite> favourites = _projectDbContext.Favourites.ToList();
                return favourites;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
