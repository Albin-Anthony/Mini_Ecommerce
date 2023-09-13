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

        public class Product
        {
			public const string InsertProduct = "[Product].[InsertProduct]";
			public const string SelectProduct = "[Product].[SelectProduct]";
			public const string SelectById = "[Product].[SelectById]";
			public const string updateProduct = "[Product].[updateProduct]";
			public const string deleteProduct = "[Product].[deleteProduct]";


		}
		public class Category
		{
			public const string selectCategory = "[dbo].[GetCategory]";
            public const string SaveOrUpdateCategory = " [dbo].[SaveOrUpdateCategory]";
            public const string DeleteCategory = " [dbo].[DeleteCategory]";


        } 
	}
}
