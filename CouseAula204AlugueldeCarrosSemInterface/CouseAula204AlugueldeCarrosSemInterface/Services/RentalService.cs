﻿using System;
using CouseAula204AlugueldeCarrosSemInterface.Entities;
namespace CouseAula204AlugueldeCarrosSemInterface.Services
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //Declaração para utilização da Interface - In
        private ITaxService _taxService;

        public RentalService()
        {
        }

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }


        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if(duration.TotalDays <= 12)
            {
                basicPayment = Math.Ceiling( duration.TotalHours) * PricePerHour;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays * PricePerDay);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
