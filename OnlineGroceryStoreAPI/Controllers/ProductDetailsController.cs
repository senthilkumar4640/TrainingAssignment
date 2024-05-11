
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryStoreAPI.Data;

namespace OnlineGroceryStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductDetailsController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public ProductDetailsController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }


        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(_dbContext.productList.ToList());
        }


        [HttpGet("{id}")]
        public IActionResult GetProductByID(int id)
        {
            var product = _dbContext.productList.FirstOrDefault(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


        [HttpPost]
        public IActionResult PostProduct([FromBody] ProductDetails product)
        {
            _dbContext.productList.Add(product);
            _dbContext.SaveChanges();
            return Ok();
        }


        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, [FromBody] ProductDetails product)
        {
            var products = _dbContext.productList.FirstOrDefault(m => m.ProductID == id);
            if (products == null)
            {
                return NotFound();
            }
           products.ProductName = product.ProductName;
           products.ProductQuantity = product.ProductQuantity;
           products.ProductPrice = product.ProductPrice;
           products.ProductPurchaseDate = product.ProductPurchaseDate;
           products.ProductExpiryDate = product.ProductExpiryDate;
           products.ProductImage = product.ProductImage;
           _dbContext.SaveChanges();
           return Ok();
        }

         [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _dbContext.productList.FirstOrDefault(m => m.ProductID == id);
            if(product == null)
            {
                return NotFound();
            }
            _dbContext.productList.Remove(product);
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
        }  

         [HttpPut("{productID}/{count}")]
        public IActionResult UpdateCount(int productID,int count)
        {
            var product=_dbContext.productList.FirstOrDefault(product=>product.ProductID==productID);
            if(product==null)
            {
                return NotFound();
            }
            product.ProductQuantity-=count;
            _dbContext.SaveChanges();
            return Ok();
        }

    }
}
