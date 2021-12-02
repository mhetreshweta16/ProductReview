using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqueProductReview
{
  public  class ProductReview
    {
        public int productId { get; set; }
        public int userId { get; set; }
        public string review { get; set; }
        public float rating { get; set; }
        public bool isLike { get; set; }

    }
}
