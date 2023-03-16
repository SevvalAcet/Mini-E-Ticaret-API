using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entitites;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    //new() {Id =Guid.NewGuid(), Name="Product1",Price=100,CreatedDate=DateTime.UtcNow,Stock=10},
            //    //new() {Id =Guid.NewGuid(), Name="Product2",Price=200,CreatedDate=DateTime.UtcNow,Stock=10},
            //    //new() {Id =Guid.NewGuid(), Name="Product3",Price=300,CreatedDate=DateTime.UtcNow,Stock=10},
            //});
            //var count = await _productWriteRepository.SaveAsync();

            Product p = await _productReadRepository.GetByIdAsync("03df16cc-6642-49e0-b2b6-2cd762745610");
            p.Name = "Mehmet";
            await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
