﻿using ExceptionHandling.Entities;
using ExceptionHandling.Entities.Exceptions;
namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            { 
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine()!);
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine()!);

            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);
            Console.WriteLine();
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine()!);
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine()!);

            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);
            }

            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}