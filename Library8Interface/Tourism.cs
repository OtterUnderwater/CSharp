using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library8Interface
{
    internal class Tourism
    {
        /// <summary>
        /// Интерфейс стоимости билетов
        /// </summary>
        interface ITicket
        {
            int TicketPrice { get; set; }
            void PrintInfo();
        }

        /// <summary>
        /// Интерфейс стран
        /// </summary>
        interface ICountry
        {
            string Country { get; set; }
            void PrintInfo();
        }

        /// <summary>
        /// Тема: Туризм
        /// </summary>
        internal class Trip : ITicket, ICountry
        {
            string? country = ""; //страна
            int discount = 0; //скидка
            int ticketCount = 0; //количество билетов
            int ticketPrice = 0; //стоимость билетов                     
            public int TicketCount { get => ticketCount; set => ticketCount = value; }
            public string Country
            {
                get
                {
                    if (country == "Россия")
                    {
                        return "Тур по городам России";
                    }
                    else
                    {
                        return "Тур в другие страны";
                    }
                }
                set
                {
                    //скидка на Россия
                    if (value == "Россия")
                    {
                        discount = 200;
                    }
                    else
                    {
                        discount = 0;
                    }
                    country = value;
                }
            }
            public int TicketPrice
            {
                get
                {
                    return ticketPrice - discount;
                }
                set
                {
                    ticketPrice = value * TicketCount;                 
                }
            }

            public Trip(string country, int count, int price)
            {
                Country = country;
                TicketCount = count;
                TicketPrice = price;
            }
            public void PrintInfo()
            {
                Console.WriteLine(Country);
                Console.WriteLine("Итоговая стоимость:" + TicketPrice);
            }
        }
    }

}
