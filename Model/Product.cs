using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCrm.Model
{
    public class Product
    {   /// <summary>
       /// 
      /// </summary>
        public string id { get;set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get;set;}
        /// <summary>
        /// 
        /// </summary>
        public decimal  Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ProductCategory Category { get; set; }
    }
}
