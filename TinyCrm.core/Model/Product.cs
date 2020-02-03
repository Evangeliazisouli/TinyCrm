using System;
using System.Collections.Generic;
using System.Text;
using TinyCrm.Core;

namespace TinyCrm.core
{
    public class Product
    {          /// <summary>
               /// 
               /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ProductCategory Category { get; set; }
    }
}
