
using AutoMapper;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DTO;

namespace MobileAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreate category)
        {
            var obj = _mapper.Map<Category>(category);
            await _categoryRepository.CreateAsync(obj);
            return Ok(category);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, CategoryCreate updateDTO)
        {
            var cate = await _categoryRepository.GetAsync(c => c.Id == id);
            if (cate == null)
                return BadRequest();
            //_mapper.Map(category,cate);
            //Category model = _mapper.Map<Category>(category);
            Category obj = _mapper.Map(updateDTO, cate);
            await _categoryRepository.UpdateAsync(obj);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _categoryRepository.GetAsync(c => c.Id == id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cate = await _categoryRepository.GetAsync(c => c.Id == id);
            if (cate == null)
            {
                return NotFound();
            }
            await _categoryRepository.RemoveAsync(cate);
            return Ok();
        }
    }
}
