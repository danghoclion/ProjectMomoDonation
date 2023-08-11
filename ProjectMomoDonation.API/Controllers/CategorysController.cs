using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.DTO;
using ProjectMomoDonation.API.ValidateHelper;
using ProjectMomoDonation.Core.Models;

namespace ProjectMomoDonation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorysController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategorysController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            var category = await unitOfWork.CategoryRepository.GetAllAsync();
            return Ok(category);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await unitOfWork.CategoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] CategoryDTO categoryDTO)
        {
            var category = mapper.Map<Category>(categoryDTO);
            var newCategory = await unitOfWork.CategoryRepository.CreateAsync(category);

            if (newCategory == null)
            {
                return NotFound();
            }

            return Ok(newCategory);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CategoryDTO categoryDTO)
        {
            var category = mapper.Map<Category>(categoryDTO);
            category.CategoryId = id;
            var updateCategory = await unitOfWork.CategoryRepository.UpdateAsync(category);

            if (updateCategory == null)
                return NotFound();
            return Ok(mapper.Map<CategoryDTO>(updateCategory));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deleteCategory = await unitOfWork.CategoryRepository.GetByIdAsync(id);
            if (deleteCategory == null)
                return NotFound();
            await unitOfWork.CategoryRepository.Deletesync(deleteCategory);
            return Ok(mapper.Map<CategoryDTO>(deleteCategory));
        }
    }
}