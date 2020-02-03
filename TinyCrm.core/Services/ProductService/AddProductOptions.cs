using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrm.Core
{
    public class AddProductOptions
    { /// <summary>
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
        public ProductCategory ProductCategory { get; set; }
    }
}
