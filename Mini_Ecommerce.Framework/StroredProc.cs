using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Framework
{
    public class StroredProc
    {
        public class Payment
        {
			public const string InsertPayment = "[dbo].[InsertPayment]";
			public const string SelectPament = "[dbo].[SelectPament]";
			
		}

        public class Register
        {
			public const string SaveRegister = "[dbo].[SaveRegisterDetails]";

        }

        public class Login
        {
            public const string GetLogin = "[dbo].[CheckEmailAndPassword]";

        }

        public class Product
        {
			public const string InsertProduct = "[Product].[InsertProduct]";
			public const string SelectProduct = "[Product].[SelectProduct]";
			public const string SelectById = "[Product].[SelectById]";
			public const string updateProduct = "[Product].[updateProduct]";
			public const string deleteProduct = "[Product].[deleteProduct]";


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
		public class Category
		{
			public const string selectCategory = "[dbo].[GetCategory]";
            public const string SaveOrUpdateCategory = " [dbo].[SaveOrUpdateCategory]";
            public const string DeleteCategory = " [dbo].[DeleteCategory]";


        } 
	}
}
