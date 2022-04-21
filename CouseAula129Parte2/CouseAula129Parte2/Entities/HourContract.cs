﻿using System;
namespace CouseAula129Parte2.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double  ValuePorHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePorHour, int hours)
        {
            Date = date;
            ValuePorHour = valuePorHour;
            Hours = hours;
        }


        public double TotalValue()
        {
            return Hours * ValuePorHour;
        }
    }
}
