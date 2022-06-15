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

using Microsoft.AspNetCore.Http;

namespace CinemaManagement.BL.Services
{
    public class FilmImagesService : IFilmImagesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public FilmImagesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<FilmImagesModel> GetFilmImage(int imageId)
        {
            var film = _mapper.Map<FilmImage, FilmImagesModel>(
                await _unitOfWork.FilmImages.GetAsync(filter: x => x.Id == imageId));
            return film;
        }

        public async Task<IEnumerable<FilmImagesModel>> GetFilmImages(int filmId)
        {
            var films = _mapper.Map<IEnumerable<FilmImage>, IEnumerable<FilmImagesModel>>(
                await _unitOfWork.FilmImages.GetAsync(filter: x => x.FilmId == filmId, orderBy: null));
            return films;
        }

        public async Task<bool> AddImagesToFilm(ICollection<IFormFile> formFiles, int filmId)
        {
            List<FilmImagesModel> imagesModel = new List<FilmImagesModel>();
            if (formFiles.Any())
            {
                foreach (var file in formFiles)
                {
                    byte[] imageData = null;
                    using (var binaryReader = new BinaryReader(file.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)file.Length);
                    }

                    var imageDataString = Convert.ToBase64String(imageData);
                    var imageResult = $"data:image/jpeg;base64,{imageDataString}";
                    var image = new FilmImagesModel()
                    {
                        FilmId = filmId,
                        ImageData = imageResult
                    };
                    imagesModel.Add(image);
                }

                var images = _mapper.Map<List<FilmImagesModel>, List<FilmImage>>(imagesModel);
                await _unitOfWork.FilmImages.InsertRangeAsync(images);
                return await _unitOfWork.SaveAsync();
            }
            return false;
        }

        public async Task<bool> DeleteImage(int id)
        {
            var film = await _unitOfWork.FilmImages.GetAsync(null, x => x.Id == id);
            if (film == null) throw new Exception("No data");
            _unitOfWork.FilmImages.Delete(film);
            return await _unitOfWork.SaveAsync();
        }
    }
}
