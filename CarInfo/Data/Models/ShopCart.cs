using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Models
{
    public class ShopCart
    {
         private readonly AppDbContext appDBContent;

        public ShopCart(AppDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCarId { get; set; }

        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; // add new session , if user don't creat basket 
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("cartId") ?? Guid.NewGuid().ToString(); //new indentificator 

            session.SetString("cartId", shopCartId);

            return new ShopCart(context) { ShopCarId = shopCartId };
        }

        public void AddToCard(Car car)
        {
            this.appDBContent.shopCartItems.Add(new ShopCartItem
            {
                ShopCarId = ShopCarId,
                car = car,
                price= (int)car.price,
            });

            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {

            return appDBContent.shopCartItems.Where(c => c.ShopCarId == ShopCarId).Include(s => s.car).ToList();
        }
    }
}
