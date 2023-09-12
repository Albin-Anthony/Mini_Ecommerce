using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Framework
{
    public static class StroredProc
    {
        public static class Payment
        {
			public const string InsertPayment = "[dbo].[InsertPayment]";
			public const string SelectPament = "[dbo].[SelectPament]";
			
		}
        public static class UserDetails
        {
            public const string SelectUserById = "[User].[GetUserByID]";
            public const string InsertUser = "[User].[InsertUser]";

        }
        public static class CartDetails
        {
            public const string SelectCartById = "[ShopCarts].[GetShoppingCartByID]";
            public const string InsertCart = "[ShopCarts].[InsertsShoppingCart]"; 
            public const string DeleteCart = "[ShopCarts].[DeleteShoppingCart]";
            public const string UpdateCart = "[ShopCarts].[UpdateShoppingCart]"; 
            public const string SelectAllCart = "[ShopCarts].[SelectAllShoppingCarts]";

        }
        
    }
}
