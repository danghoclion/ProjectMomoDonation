using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.DTO;
using ProjectMomoDonation.API.ValidateHelper;
using ProjectMomoDonation.Core.Models;

namespace ProjectMomoDonation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        //private readonly RoleManager<IdentityRole> roleManager;

        //private readonly IMapper mapper;

        //public RoleController(RoleManager<IdentityRole> roleManager, IMapper mapper)
        //{
        //    this.roleManager = roleManager;
        //    this.mapper = mapper;
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetALL()
        //{
        //    var roles = await roleManager.Roles.ToListAsync();
        //    return Ok(roles);
        //}
        //[HttpGet]
        //[Route("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var role = await unitOfWork.CategoryRepository.GetByIdAsync(id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(mapper.Map<CategoryDTO>(category));
        //}

        //[HttpPost]
        //[ValidateModel]
        //public async Task<IActionResult> Create([FromBody] CategoryDTO categoryDTO)
        //{
        //    var category = mapper.Map<Category>(categoryDTO);
        //    var newCategory = await unitOfWork.CategoryRepository.CreateAsync(category);

        //    if (newCategory == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(newCategory);
        //}

        //[HttpPut]
        //[Route("{id}")]
        //public async Task<IActionResult> Update(int id, [FromBody] CategoryDTO categoryDTO)
        //{
        //    var category = mapper.Map<Category>(categoryDTO);
        //    category.CategoryId = id;
        //    var updateCategory = await unitOfWork.CategoryRepository.UpdateAsync(category);

        //    if (updateCategory == null)
        //        return NotFound();
        //    return Ok(mapper.Map<CategoryDTO>(updateCategory));
        //}

        //[HttpDelete]
        //[Route("{id}")]
        //public async Task<IActionResult> Delete([FromRoute] int id)
        //{

        //    var deleteCategory = await unitOfWork.CategoryRepository.GetByIdAsync(id);
        //    if (deleteCategory == null)
        //        return NotFound();
        //    await unitOfWork.CategoryRepository.Deletesync(deleteCategory);
        //    return Ok(mapper.Map<CategoryDTO>(deleteCategory));
        //}
    }
}
