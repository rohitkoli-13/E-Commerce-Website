using OnlineShoppingManagement.Services;
using OnlineShopPingManagement.Entities;

namespace OnlineShopPingManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ProjectDbContext>();
            builder.Services.AddTransient<IAdminServices, AdminServices>();
            builder.Services.AddTransient<ICategoryServices, CategoryServices>();
            builder.Services.AddTransient<ICustomerServices,CustomerServices>();
            builder.Services.AddTransient<IFavouriteServices, FavouriteServices>();
            builder.Services.AddTransient<IOrderServices, OrderServices>();
            builder.Services.AddTransient<IPaymentService, PaymentService>();
            builder.Services.AddTransient<IProductServices, ProductServices>();
            builder.Services.AddTransient<IYourOrdersServices, YourOrdersServices>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}