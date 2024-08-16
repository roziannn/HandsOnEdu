using HandsOnEdu.Data;
using HandsOnEdu.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.NetworkInformation;

namespace HandsOnEdu.Services
{

    public interface IMstVolunteerPostServices
    {
        Task Create(MstVolunteeringPost model);
    }

    public class MstVolunteerPostService(ApplicationDbContext dbContext) : IMstVolunteerPostServices
    {

        private readonly ApplicationDbContext _dbContext = dbContext;

        public async Task Create(MstVolunteeringPost model)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();
            var modelName = "VolunteeringPost";
            try
            {
                model.NewId = Guid.NewGuid();
                model.CreatedDate = DateTime.Now;
                model.UpdatedDate = DateTime.Now;
                model.IsActive = true;

                _dbContext.Add(model);
                await _dbContext.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new($"Error occurred during {modelName} addition.", ex);
            }
        }
    }
}
