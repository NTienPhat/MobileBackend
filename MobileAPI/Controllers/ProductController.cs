using AutoMapper;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DTO;

namespace MobileAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productRepository.GetAllAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreate product)
        {
            Product obj = _mapper.Map<Product>(product);
            obj.DateCreated = DateTime.Now;
            await _productRepository.CreateAsync(obj);
            return Ok(product);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, ProductCreate updateDto)
        {
            var obj = await _productRepository.GetAsync(p => p.Id == id);
            if (obj == null)
                return NotFound();
            Product pro = _mapper.Map(updateDto, obj);
            await _productRepository.UpdateAsync(pro);
            return Ok(pro);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productRepository.GetAsync(p => p.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pro = await _productRepository.GetAsync(p => p.Id == id);
            if (pro == null)
                return NotFound();
            await _productRepository.RemoveAsync(pro);
            return Ok();
        }
    }
}
