using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CinemaManagement.BL.Email;
using CinemaManagement.BL.Interfaces;
using CinemaManagement.BL.Models;
using CinemaManagement.DAL.Entities;
using CinemaManagement.DAL.Interfaces;

namespace CinemaManagement.BL.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public IEmailSender _emailSender;
        public ReservationService(IUnitOfWork unitOfWork, IMapper mapper, IEmailSender sender)
        {

            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _emailSender = sender;
        }
        public async Task<IEnumerable<ReservationModel>> GetAllAsync()
        {
            var reservations = _mapper.Map<IEnumerable<Reservation>, IEnumerable<ReservationModel>>
                (await _unitOfWork.Reservations.GetAsync(orderBy: null));
            return reservations;
        }

        public async Task<IEnumerable<ReservationModel>> GetUserReservations(string userId)
        {
            var reservations = _mapper.Map<IEnumerable<Reservation>, IEnumerable<ReservationModel>>
                (await _unitOfWork.Reservations.GetAsync(orderBy: null, filter: x => x.UserId == userId));
            return reservations.Reverse();
        }

        public async Task<ReservationModel> GetByIdAsync(int id)
        {
            var reservation =
                _mapper.Map<Reservation, ReservationModel>(
                    await _unitOfWork.Reservations.GetAsync(filter: x => x.Id.Equals(id)));
            return reservation;
        }

        public Task<bool> AddAsync(ReservationModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<Reservation> AddModelAsync(ReservationModel model)
        {
            if (model.SessionId == 0 || model.UserId == null) throw new Exception("Invalid data");
            var reservationModel = _mapper.Map<ReservationModel, Reservation>(model);
            var reservation = new Reservation()
            {
                UserId = reservationModel.UserId,
                SessionId = reservationModel.SessionId,
                BookedSeats = reservationModel.BookedSeats,
                Confirmed = reservationModel.Confirmed,
                DateTime = reservationModel.DateTime,
                Session = reservationModel.Session,
            };
            await _unitOfWork.Reservations.InsertAsync(reservation);
            await _unitOfWork.SaveAsync();

            return reservation;
        }

        public async Task<bool> UpdateAsync(ReservationModel model)
        {
            if (model.SessionId == 0 || model.UserId.Any()) throw new Exception("Invalid data");
            var reservation = _mapper.Map<ReservationModel, Reservation>(model);
            _unitOfWork.Reservations.Update(reservation);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteByIdAsync(int modelId)
        {
            var reservation = await _unitOfWork.Reservations.GetAsync(null, x => x.Id == modelId);
            if (reservation == null) throw new Exception("No data");
            var seats = await _unitOfWork.BookedSeats.GetAsync(null, null,
                x => x.ReservationId == reservation.Id);
            _unitOfWork.BookedSeats.Delete(seats);
            _unitOfWork.Reservations.Delete(reservation);

            return await _unitOfWork.SaveAsync();
        }
    }
}
