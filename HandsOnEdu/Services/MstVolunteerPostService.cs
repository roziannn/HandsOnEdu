using HandsOnEdu.Data;
using HandsOnEdu.Data.Dto;
using HandsOnEdu.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.NetworkInformation;

namespace HandsOnEdu.Services
{

    public interface IMstVolunteerPostServices
    {
        Task<List<MstVolunteeringPostDto>> GetAll();
        Task Create(MstVolunteeringPost model);
        Task<MstVolunteeringPost?> GetById(int id);

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
                model.NewId = Guid.NewGuid().ToString();
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

        public async Task<List<MstVolunteeringPostDto>> GetAll()
        {
            try
            {
                var dateNow = DateTime.UtcNow.Date;

                var datas = await _dbContext.MstVolunteeringPosts
                .Where(x => x.IsActive == true)
                .Select(x => new MstVolunteeringPostDto
                {
                    Id = x.Id,
                    NewId = x.NewId.ToString(),
                    Title = x.Title,
                    Location = x.Location,
                    HeldBy = x.HeldBy,
                    PostDeadline = x.PostDeadline,
                    Status = x.PostDeadline < dateNow ? "Experied" : "Active"
                })
                .ToListAsync();


                return datas;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to fetch notifications.", ex);
            }
        }

        public async Task<MstVolunteeringPost?> GetById(int id)
        {
            try
            {
                var post = await _dbContext.MstVolunteeringPosts
                    .FirstOrDefaultAsync(m => m.Id == id);

                if (post == null)
                {
                    throw new ArgumentException($"Post with Id '{id}' not found.");
                }
                return post;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving DataTransRequest for id '{id}': {ex.Message}");
            }
        }
    }
}
