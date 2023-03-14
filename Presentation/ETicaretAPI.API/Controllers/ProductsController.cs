using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository productReadRepository;
        public ProductsController(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id =Guid.NewGuid(), Name="Product1",Price=100,CreatedDate=DateTime.UtcNow,Stock=10},
                new() {Id =Guid.NewGuid(), Name="Product2",Price=200,CreatedDate=DateTime.UtcNow,Stock=10},
                new() {Id =Guid.NewGuid(), Name="Product3",Price=300,CreatedDate=DateTime.UtcNow,Stock=10},
            });
            await _productWriteRepository.SaveAsync();
          }
    }
}
