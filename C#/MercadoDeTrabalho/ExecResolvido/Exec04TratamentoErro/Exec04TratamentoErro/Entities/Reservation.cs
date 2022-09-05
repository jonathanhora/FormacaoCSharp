﻿using System;
using Exec04TratamentoErro.Entities.Exceptions;

namespace Exec04TratamentoErro.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
            
        }

        public void UpdateDates (DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException ("Error in reservation: Reservetion date for update must be future dates");
            }
            if (checkout <= checkin)
            {
               throw new DomainException("Error in reservation: Check-out date must be after check-in date");
            }

            Checkin = checkin;
            Checkout = checkout;
       
        }

        public override string ToString()
        {
            return $"Reservation: Room {RoomNumber}, " +
                $"Check-in: {Checkin.ToString("dd/MM/yyyy")}, Check-out: {Checkout.ToString("dd/MM/yyyy")}, " +
                $"{Duration()} nights";
        }
    }
}
