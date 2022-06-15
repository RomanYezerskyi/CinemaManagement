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

namespace CinemaManagement.BL.Services
{
    public class SeatService : ISeatService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SeatService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SeatModel>> GetAllAsync()
        {
            var seats = _mapper.Map<IEnumerable<Seat>, IEnumerable<SeatModel>>(
                await _unitOfWork.Seats.GetAsync(orderBy: x => x.OrderBy(y => y.Id)));
            return seats;
        }
        public async Task<SeatModel> GetByIdAsync(int id)
        {
            var seat = _mapper.Map<Seat, SeatModel>(
                await _unitOfWork.Seats.GetAsync(filter: seat1 => seat1.Id.Equals(id)));
            return seat;
        }
        public async Task<bool> AddRangeAsync(IEnumerable<SeatModel> model)
        {
            if (model == null) throw new Exception("Seats can't be null");
            //var seats = _mapper.Map<IEnumerable<SeatModel>, IEnumerable<Seat>>(model);
            var seats = new List<Seat>();
            foreach (var seatModel in model)
            {
                var seat = _mapper.Map<SeatModel, Seat>(seatModel);
                seats.Add(new Seat()
                {
                    BookedSeats = seat.BookedSeats,
                    HallId = seat.HallId,
                    Price = seat.Price,
                    RowNum = seat.RowNum,
                    SeatNum = seat.SeatNum,
                });
            }
            await _unitOfWork.Seats.InsertRangeAsync(seats);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> AddAsync(SeatModel model)
        {
            if (model.HallId == 0) throw new Exception("Invalid data");
            var seatModel = _mapper.Map<SeatModel, Seat>(model);
            var seats = _unitOfWork.Seats.GetAsync(null, null, x => x.HallId == model.HallId).Result.Count();

            var seat = new Seat()
            {
                BookedSeats = seatModel.BookedSeats,
                SeatNum = seats + 1,
                Hall = seatModel.Hall,
                Price = seatModel.Price,
                HallId = seatModel.HallId,
                RowNum = seatModel.RowNum,

            };
            await _unitOfWork.Seats.InsertAsync(seat);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> UpdateAsync(SeatModel model)
        {
            if (model.SeatNum == 0 || model.RowNum == 0 || model.HallId == 0) throw new Exception("Invalid data");
            var seat = _mapper.Map<SeatModel, Seat>(model);
            _unitOfWork.Seats.Update(seat);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteByIdAsync(int modelId)
        {
            var seat = await _unitOfWork.Seats.GetAsync(null, x => x.Id == modelId);
            if (seat == null) throw new Exception("No data");
            _unitOfWork.Seats.Delete(seat);
            return await _unitOfWork.SaveAsync();
        }
    }
}
