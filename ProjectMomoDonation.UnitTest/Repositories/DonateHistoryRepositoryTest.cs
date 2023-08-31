
using Microsoft.EntityFrameworkCore;
using Moq;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDoanation.Core.Repository;
using ProjectMomoDonation.Core.Data;
using ProjectMomoDonation.Core.Models;

namespace FA.JustBlog.UnitTest.Repositories
{
    [TestFixture]
    public class DonateHistoryRepositoryTest
    {
        private IDonateHistoryRepository _repository;
        private Mock<MomoDbContext> _context;
        private Mock<DbSet<DonateHistory>> _dbSet;

        [SetUp]
        public void SetUp()
        {
            _dbSet = new Mock<DbSet<DonateHistory>>();
            var data = new List<DonateHistory>()
            {
                new DonateHistory() { HistoryID = 1,ProgramDonationId = 1, Id = "1", Amount = 1000, Time = DateTime.Now},
                new DonateHistory() { HistoryID = 2,ProgramDonationId = 2 ,Id = "2", Amount = 2000, Time = DateTime.Now},
                new DonateHistory() { HistoryID = 3,ProgramDonationId = 3,  Id = "3", Amount = 3000, Time = DateTime.Now},
            }.AsQueryable();
            _dbSet.As<IQueryable<DonateHistory>>().Setup(m => m.Provider).Returns(data.Provider);
            _dbSet.As<IQueryable<DonateHistory>>().Setup(m => m.Expression).Returns(data.Expression);
            _dbSet.As<IQueryable<DonateHistory>>().Setup(m => m.ElementType).Returns(data.ElementType);
            _dbSet.As<IQueryable<DonateHistory>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            _context = new Mock<MomoDbContext>();
            _context.Setup(x => x.Set<DonateHistory>()).Returns(_dbSet.Object);
            _repository = new DonateHistoryRepository(_context.Object);
        }

        [Test]
        public async Task GetAll_WhenCalled_ReturnListDonateHistory()
        {
            var result =await _repository.GetAllAsync();
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task GetDonateHistorys_WhenCalled_ReturnListDonateHistoryById()
        {
            var result = await _repository.GetByIdAsync(1);
            Assert.IsNotNull(result);
            var test = new DonateHistory() { HistoryID = 1, ProgramDonationId = 1, Id = "1", Amount = 1000, Time = DateTime.Now };
            Assert.AreEqual(test, result);
        }
    }
}