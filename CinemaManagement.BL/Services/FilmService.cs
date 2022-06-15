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
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace CinemaManagement.BL.Services
{
    public class FilmService : IFilmService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFilmImagesService _filmImagesService;

        public FilmService(IUnitOfWork unitOfWork, IMapper mapper, IFilmImagesService filmImagesService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _filmImagesService = filmImagesService;
        }

        public async Task<IEnumerable<FilmModel>> GetAllAsync()
        {
            var films = _mapper.Map<IEnumerable<Film>, IEnumerable<FilmModel>>(await
                _unitOfWork.Films.GetAsync(orderBy: x => x.OrderBy(film => film.Name),
                    includes: x => x.Include(i => i.Images).Include(i => i.Sessions)));
            return films;
        }

        public async Task<FilmModel> GetByIdAsync(int id)
        {
            var film = _mapper.Map<Film, FilmModel>(await _unitOfWork.Films.GetAsync(filter: x => x.Id.Equals(id),
                includes: x => x.Include(i => i.Images).Include(i => i.Sessions)));
            return film;
        }
        public async Task<bool> AddAsync(FilmModel model)
        {
            if (model.Name == null) throw new Exception("The film must contain a name");
            var filmModel = _mapper.Map<FilmModel, Film>(model);
            var film = new Film()
            {
                Actors = filmModel.Actors,
                Description = filmModel.Description,
                Images = filmModel.Images,
                LinkTrailer = filmModel.LinkTrailer,
                Name = filmModel.Name,
                Producers = filmModel.Producers,
                ReleaseDate = filmModel.ReleaseDate,
                Sessions = filmModel.Sessions
            };
            await _unitOfWork.Films.InsertAsync(film);
            if (model.ImagesData != null)
            {
                var res = await _filmImagesService.AddImagesToFilm(model.ImagesData, film.Id);
                if (!res)
                {
                    throw new Exception("Something with images went wrong!");
                }
            }
            return await _unitOfWork.SaveAsync();
        }
        public async Task<bool> UpdateAsync(FilmModel model)
        {
            if (model.Name == null) throw new Exception("The film must contain a name");
            var film = await _unitOfWork.Films.GetAsync(null, x => x.Id == model.Id);
            var filmImages = await _unitOfWork.FilmImages.GetAsync(null, null, x => x.FilmId == film.Id);
            if (model.Name != film.Name)
            {
                film.Name = model.Name;
            }

            if (model.Actors != film.Actors)
            {
                film.Actors = model.Actors;
            }

            if (model.Producers != film.Producers)
            {
                film.Producers = model.Producers;
            }

            if (model.Description != film.Description)
            {
                film.Description = model.Description;
            }

            if (model.ReleaseDate != film.ReleaseDate)
            {
                film.ReleaseDate = model.ReleaseDate;
            }

            if (model.LinkTrailer != film.LinkTrailer)
            {
                film.LinkTrailer = model.LinkTrailer;
            }

            if (model.ImagesData != null)
            {
                if (filmImages.ToList().Count > 0)
                    _unitOfWork.FilmImages.Delete(filmImages);
                var res = await _filmImagesService.AddImagesToFilm(model.ImagesData, film.Id);
                if (!res)
                {
                    throw new Exception("Something with images went wrong!");
                }
            }
            else if (model.Images.ToList().Count > 0)
            {

                _unitOfWork.FilmImages.Delete(filmImages);
                foreach (var image in model.Images)
                {
                    var data = new FilmImage() { FilmId = film.Id, ImageData = image.ImageData };
                    await _unitOfWork.FilmImages.InsertAsync(data);
                }

            }
            _unitOfWork.Films.Update(film);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteByIdAsync(int modelId)
        {
            var film = await _unitOfWork.Films.GetAsync(null, x => x.Id == modelId);
            if (film == null) throw new Exception("No data");
            var sessions = await _unitOfWork.Sessions.GetAsync(null, null, x => x.FilmId == film.Id);
            if (sessions != null)
            {
                foreach (var session in sessions)
                {
                    var reservations =
                        await _unitOfWork.Reservations.GetAsync(null, null, x => x.SessionId == session.Id);
                    if (reservations != null)
                    {
                        foreach (var reservation in reservations)
                        {
                            var bookedSeats =
                                await _unitOfWork.BookedSeats.GetAsync(null, null,
                                    x => x.ReservationId == reservation.Id);
                            _unitOfWork.BookedSeats.Delete(bookedSeats);
                        }

                        _unitOfWork.Reservations.Delete(reservations);
                    }
                }
                _unitOfWork.Sessions.Delete(sessions);
            }

            _unitOfWork.Films.Delete(film);
            return await _unitOfWork.SaveAsync();
        }
    }
}
