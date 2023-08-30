using Microsoft.EntityFrameworkCore;
using Moq;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDoanation.Core.Repository;
using ProjectMomoDonation.Core.Data;
using ProjectMomoDonation.Core.Models;
using System.Security.Cryptography.X509Certificates;

namespace FA.JustBlog.UnitTest.Repositories
{
    [TestFixture]
    public class CategoryRepositoryTest
    {
        private ICategoryRepository _repository;
        private Mock<MomoDbContext> _context;
        private Mock<DbSet<Category>> _dbSet;

        [SetUp]
        public void SetUp()
        {
            _dbSet = new Mock<DbSet<Category>>();
            var data = new List<Category>()
                {
                    new Category() { CategoryId = 1, Name = "Apple",UrlSlug="Apple", Description ="Description"},
                    new Category() { CategoryId = 2, Name = "Samsung", UrlSlug="Samsung",Description ="Description"},
                    new Category() { CategoryId = 3, Name = "Oppo", UrlSlug="Oppo", Description = "Description"},
                }.AsQueryable();

            _dbSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            _context = new Mock<MomoDbContext>();
            _context.Setup(x => x.Set<Category>()).Returns(_dbSet.Object);
            _repository = new CategoryRepository(_context.Object);
        }

        [Test]
        public async Task GetAll_WhenCalled_ReturnListCategory()
        {
            var result = await _repository.GetAllAsync();
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task Find_WhenCalled_ReturnCategoryById()
        {
            var list = await _repository.GetAllAsync();
            var result = list.Where(x => x.CategoryId == 1);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }
    }
}