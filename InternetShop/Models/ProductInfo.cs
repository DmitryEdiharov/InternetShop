using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetShop.Models
{
    public class ProductInfo
    {
        public int Id;

        /// <summary>
        /// Описание продукта
        /// </summary>
        public string Description;

        /// <summary>
        /// Список продуктов входящих в состав конкретного продукта
        /// </summary>
        public List<int> Compounds;

    }
}