using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL.Data;
using CinemaManagement.DAL.Entities;
using CinemaManagement.DAL.Interfaces;

namespace CinemaManagement.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private BaseRepositoryAsync<User> _users;
        private BaseRepositoryAsync<Film> _films;
        private BaseRepositoryAsync<Hall> _halls;
        private BaseRepositoryAsync<Seat> _seats;
        private BaseRepositoryAsync<Session> _sessions;
        private BaseRepositoryAsync<Reservation> _reservations;
        private BaseRepositoryAsync<FilmImage> _filmImages;
        private BaseRepositoryAsync<Achievement> _achievements;
        private BaseRepositoryAsync<BookedSeat> _bookedSeats;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IRepositoryAsync<User> Users
        {
            get
            {
                return _users ??= new BaseRepositoryAsync<User>(_context);
            }
        }

        public IRepositoryAsync<Film> Films
        {
            get
            {
                return _films ??= new BaseRepositoryAsync<Film>(_context);
            }
        }

        public IRepositoryAsync<Hall> Halls
        {
            get
            {
                return _halls ??= new BaseRepositoryAsync<Hall>(_context);
            }
        }

        public IRepositoryAsync<Seat> Seats
        {
            get
            {
                return _seats ??= new BaseRepositoryAsync<Seat>(_context);
            }
        }

        public IRepositoryAsync<Session> Sessions
        {
            get
            {
                return _sessions ??= new BaseRepositoryAsync<Session>(_context);
            }
        }

        public IRepositoryAsync<Reservation> Reservations
        {
            get
            {
                return _reservations ??= new BaseRepositoryAsync<Reservation>(_context);
            }
        }

        public IRepositoryAsync<FilmImage> FilmImages
        {
            get
            {
                return _filmImages ??= new BaseRepositoryAsync<FilmImage>(_context);
            }
        }

        public IRepositoryAsync<Achievement> Achievements
        {
            get
            {
                return _achievements ??= new BaseRepositoryAsync<Achievement>(_context);
            }
        }

        public IRepositoryAsync<BookedSeat> BookedSeats
        {
            get
            {
                return _bookedSeats ??= new BaseRepositoryAsync<BookedSeat>(_context);
            }
        }

        public async Task<bool> SaveAsync()
        {
            return Convert.ToBoolean(await _context.SaveChangesAsync());
        }
    }
}
