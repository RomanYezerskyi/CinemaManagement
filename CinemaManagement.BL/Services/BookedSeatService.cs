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
    public class BookedSeatService : IBookedSeatService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public IEmailSender _emailSender;
        public BookedSeatService(IUnitOfWork unitOfWork, IMapper mapper, IEmailSender sender)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _emailSender = sender;
        }

        public async Task<IEnumerable<BookedSeatModel>> GetAllAsync()
        {
            var bookedSeats = _mapper.Map<IEnumerable<BookedSeat>, IEnumerable<BookedSeatModel>>(
                await _unitOfWork.BookedSeats.GetAsync(orderBy: x => x.OrderBy(y => y.Id)));
            return bookedSeats;
        }
        public async Task<BookedSeatModel> GetByIdAsync(int id)
        {
            var BookedSeat = _mapper.Map<BookedSeat, BookedSeatModel>(
                await _unitOfWork.BookedSeats.GetAsync(filter: seat1 => seat1.Id.Equals(id)));
            return BookedSeat;
        }
        public async Task<bool> AddRangeAsync(IEnumerable<BookedSeatModel> model)
        {
            if (model == null) throw new Exception("Seats can't be null");
            var seats = new List<BookedSeat>();
            foreach (var seatModel in model)
            {
                var seat = _mapper.Map<BookedSeatModel, BookedSeat>(seatModel);
                seats.Add(new BookedSeat()
                {
                    Seat = seat.Seat,
                    Reservation = seat.Reservation,
                    ReservationId = seat.ReservationId,
                    SeatId = seat.SeatId
                });
            }
            await _unitOfWork.BookedSeats.InsertRangeAsync(seats);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> AddAsync(BookedSeatModel model)
        {
            if (model.ReservationId == 0 || model.SeatId == 0) throw new Exception("Invalid data");
            var seatModel = _mapper.Map<BookedSeatModel, BookedSeat>(model);

            var bookedseat = new BookedSeat()
            {
                Seat = seatModel.Seat,
                ReservationId = seatModel.ReservationId,
                SeatId = seatModel.SeatId,
                Reservation = seatModel.Reservation,
            };
            //var user = await _unitOfWork.Users.GetAsync(null, x => x.Id == model.UserId);

            //var sessinon = await _unitOfWork.Sessions.GetAsync(null, x => x.Id == model.SessionId);
            //var seat = await _unitOfWork.Seats.GetAsync(null, x => x.HallId == sessinon.HallId);
            //var film = await _unitOfWork.Films.GetAsync(null, x => x.Id == sessinon.FilmId);
            var reservation = await _unitOfWork.Reservations.GetAsync(null, x => x.Id == bookedseat.ReservationId);
            var sessinon = await _unitOfWork.Sessions.GetAsync(null, x => x.Id == reservation.SessionId);
            var user = await _unitOfWork.Users.GetAsync(null, x => x.Id == reservation.UserId);
            var seat = await _unitOfWork.Seats.GetAsync(null, x => x.Id == bookedseat.SeatId);
            var film = await _unitOfWork.Films.GetAsync(null, x => x.Id == sessinon.FilmId);
            string messageText = $"Hi, {user.UserName} !!!\n\n" +
                                 $"Film: {film.Name}. Date: {sessinon.Date.ToLongDateString()} {sessinon.Date.ToShortTimeString()}\n" +
                                 $"Hall {sessinon.HallId}. Seat {seat.SeatNum}\n" +
                                 $"Price: {seat.Price}\n" +
                                 $"Payment before entering the hall\n\n" +
                                 $"P.S: We look forward to seeing you";
            var message = new Message(new string[] { user.Email }, "Your ticket", messageText);
            _emailSender.SendEmail(message);
            await _unitOfWork.BookedSeats.InsertAsync(bookedseat);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> UpdateAsync(BookedSeatModel model)
        {
            if (model.ReservationId == 0 || model.SeatId == 0) throw new Exception("Invalid data");
            var bookedSeat = _mapper.Map<BookedSeatModel, BookedSeat>(model);
            _unitOfWork.BookedSeats.Update(bookedSeat);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteByIdAsync(int modelId)
        {
            var bookedSeat = await _unitOfWork.BookedSeats.GetAsync(null, x => x.Id == modelId);
            if (bookedSeat == null) throw new Exception("No data");
            _unitOfWork.BookedSeats.Delete(bookedSeat);
            return await _unitOfWork.SaveAsync();
        }
    }
}
