using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CinemaManagement.BL.Interfaces;
using CinemaManagement.BL.Models;
using CinemaManagement.DAL.Entities;
using CinemaManagement.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaManagement.BL.Services
{
    public class SessionService : ISessionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SessionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SessionModel>> GetAllAsync()
        {
            var sessions = _mapper.Map<IEnumerable<Session>, IEnumerable<SessionModel>>(
                await _unitOfWork.Sessions.GetAsync(orderBy: x => x.OrderBy(x => x.Id)));
            return sessions;
        }

        public async Task<SessionModel> GetByIdAsync(int id)
        {
            var session = _mapper.Map<Session, SessionModel>(await _unitOfWork.Sessions.GetAsync(filter: x => x.Id.Equals(id)));
            return session;
        }

        public async Task<bool> AddAsync(SessionModel model)
        {
            if (model == null) throw new Exception("Session can't be null");
            var sessionModel = _mapper.Map<SessionModel, Session>(model);
            var session = new Session()
            {
                Hall = sessionModel.Hall,
                Date = sessionModel.Date,
                Film = sessionModel.Film,
                FilmId = sessionModel.FilmId,
                HallId = sessionModel.HallId,

            };
            await _unitOfWork.Sessions.InsertAsync(session);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> UpdateAsync(SessionModel model)
        {
            if (model == null) throw new Exception("Session can't be null");
            var session = _mapper.Map<SessionModel, Session>(model);
            _unitOfWork.Sessions.Update(session);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteByIdAsync(int modelId)
        {
            var session = await _unitOfWork.Sessions.GetAsync(null, x => x.Id == modelId);
            if (session == null) throw new Exception("No data");

            var reservations = await _unitOfWork.Reservations.GetAsync(null, null, x => x.SessionId == session.Id);
            if (reservations != null)
            {
                foreach (var reservation in reservations)
                {
                    var bookedSeats = await _unitOfWork.BookedSeats.GetAsync(null, null, x => x.ReservationId == reservation.Id);
                    if (bookedSeats != null)
                    {
                        _unitOfWork.BookedSeats.Delete(bookedSeats);
                    }
                }


                if (reservations != null)
                {
                    _unitOfWork.Reservations.Delete(reservations);
                }
            }

            _unitOfWork.Sessions.Delete(session);
            return await _unitOfWork.SaveAsync();
        }
    }
}
