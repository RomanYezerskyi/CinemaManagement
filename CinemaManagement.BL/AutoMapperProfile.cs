using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CinemaManagement.BL.Models;
using CinemaManagement.BL.Models.Authorization;
using CinemaManagement.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagement.BL
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegisterModel, User>();
            //.ForMember(u => u.UserName, opt =>
            //    opt.MapFrom(ur => ur.Email));

            CreateMap<Film, FilmModel>().ReverseMap();
            CreateMap<Seat, SeatModel>().ReverseMap();
            CreateMap<Hall, HallModel>().ReverseMap();
            CreateMap<Session, SessionModel>().ReverseMap();
            CreateMap<Reservation, ReservationModel>().ReverseMap();
            CreateMap<FilmImage, FilmImagesModel>().ReverseMap();
            CreateMap<Achievement, AchievementModel>().ReverseMap();
            CreateMap<BookedSeat, BookedSeatModel>().ReverseMap();

        }
    }
}
