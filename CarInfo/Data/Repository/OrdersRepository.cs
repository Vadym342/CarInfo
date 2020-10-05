using CarInfo.Data.Interfaces;
using CarInfo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContext appDBContent;

        private readonly ShopCart shopCart;

        public OrdersRepository(AppDbContext appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;

        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopCart.listShopItems;

            foreach (var el in items)
            {
                var orderDet = new OrderDet()
                {
                    CarID = el.car.id,
                    orderID = order.id,
                    price = el.car.price,

                };
                appDBContent.OrderDetail.Add(orderDet);

            }

            appDBContent.SaveChanges();

        }


    }
}
