using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CinemaManagement.BL.Interfaces;
using CinemaManagement.BL.Models;
using CinemaManagement.DAL.Entities;
using CinemaManagement.DAL.Interfaces;

namespace CinemaManagement.BL.Services
{
    public class AchievementsService : IAchievementsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AchievementsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AchievementModel>> GetAllAsync()
        {
            var achievements = _mapper.Map<IEnumerable<Achievement>, IEnumerable<AchievementModel>>
                (await _unitOfWork.Achievements.GetAsync(orderBy: null));
            return achievements;
        }

        public async Task<AchievementModel> GetByIdAsync(int id)
        {
            var achievement = _mapper.Map<Achievement, AchievementModel>
                (await _unitOfWork.Achievements.GetAsync(filter: x => x.Id == id));
            return achievement;
        }

        public async Task<bool> AddAsync(AchievementModel model)
        {
            if (model.Name == null) throw new Exception("The Achievement must contain a name");
            var achievementModel = _mapper.Map<AchievementModel, Achievement>(model);
            var achievement = new Achievement()
            {
                Name = achievementModel.Name,
                UserId = achievementModel.UserId,
                Discount = achievementModel.Discount,
                Enable = achievementModel.Enable,
                Image = achievementModel.Image,
                Title = achievementModel.Title,
                User = achievementModel.User,

            };
            if (model.ImagesData != null)
            {
                byte[] imageData = null;
                using (var binaryReader = new BinaryReader(model.ImagesData.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)model.ImagesData.Length);
                }

                var imageDataString = Convert.ToBase64String(imageData);
                var imageResult = $"data:image/jpeg;base64,{imageDataString}";
                achievement.Image = imageResult;
            }
            await _unitOfWork.Achievements.InsertAsync(achievement);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> UpdateAsync(AchievementModel model)
        {
            if (model.Name == null) throw new Exception("The Achievement must contain a name");
            var achievement = _mapper.Map<AchievementModel, Achievement>(model);
            if (model.ImagesData != null)
            {
                byte[] imageData = null;
                using (var binaryReader = new BinaryReader(model.ImagesData.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)model.ImagesData.Length);
                }

                var imageDataString = Convert.ToBase64String(imageData);
                var imageResult = $"data:image/jpeg;base64,{imageDataString}";
                achievement.Image = imageResult;
            }
            _unitOfWork.Achievements.Update(achievement);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteByIdAsync(int modelId)
        {
            var achievement = await _unitOfWork.Achievements.GetAsync(null, x => x.Id == modelId);
            if (achievement == null) throw new Exception("No data");
            _unitOfWork.Achievements.Delete(achievement);
            return await _unitOfWork.SaveAsync();
        }
    }
}
