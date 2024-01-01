using Microsoft.AspNetCore.Mvc;
using rwwo.webapi.rabbitmq.Models;
using rwwo.webapi.rabbitmq.RabbitMQ;
using rwwo.webapi.rabbitmq.Services;

namespace rwwo.webapi.rabbitmq.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IRabbitMQProducer _rabbitMQProducer;
        public ProductController(IProductService productService, IRabbitMQProducer rabitMQProducer)
        {
            this._productService = productService;
            _rabbitMQProducer = rabitMQProducer;
        }

        [HttpGet("productlist")]
        public IEnumerable<Product> ProductList()
        {
            var productList = _productService.GetProductList();
            return productList;
        }


        [HttpGet("getproductbyid")]
        public Product GetProductById(int Id)
        {
            return _productService.GetProductById(Id);
        }


        [HttpPost("addproduct")]
        public Product AddProduct(Product product)
        {
            var productData = _productService.AddProduct(product);

            _rabbitMQProducer.Publish("product-created", productData);
            return productData;
        }


        [HttpPut("updateproduct")]
        public Product UpdateProduct(Product product)
        {
            return _productService.UpdateProduct(product);
        }


        [HttpDelete("deleteproduct")]
        public bool DeleteProduct(int Id)
        {
            return _productService.DeleteProduct(Id);
        }
    }
}
