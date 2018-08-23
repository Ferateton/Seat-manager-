using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPILabb6
{
    public enum DisplayMode
    {
        All,
        Vacant,
        Reserved
    }
    public class SeatManager
    {
        public Seat[] seats;
        private int totNumOfSeats;
        private int numOfReservedSeats = 0;
        private int numOfVacantSeats = 0;

        /// <summary>
        /// This is the constructor for this class.
        /// </summary>
        /// <param name="maxNumberOfSeats"></param>
        public SeatManager(int maxNumberOfSeats)
        {
            totNumOfSeats = maxNumberOfSeats;
            seats = new Seat[maxNumberOfSeats];
            for (int i = 0; i < maxNumberOfSeats; i++)
            {
                seats[i] = new Seat(i + 1);
            }
        }

        /// <summary>
        /// Checks so that the value is within the range of the array.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            if ((index >= 0) && (index < totNumOfSeats))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Calculates the number of seats that are reserved.
        /// </summary>
        /// <returns></returns>
        public int GetNumReserved()
        {
            numOfReservedSeats = 0;
            for (int i = 0; i < totNumOfSeats; i++)
            {
                if (seats[i].reserved)
                    numOfReservedSeats++;
            }
            return numOfReservedSeats;
        }

        /// <summary>
        /// Calculates the number of seats that are vacant.
        /// </summary>
        /// <returns></returns>
        public int GetNumVacant()
        {
            numOfVacantSeats = 0;
            for (int i = 0; i < totNumOfSeats; i++)
            {
                if (seats[i].reserved == false)
                    numOfVacantSeats++;
            }
            return numOfVacantSeats;
        }

        /// <summary>
        /// Get the total amount of seats.
        /// </summary>
        /// <returns></returns>
        public int GetNumOfSeats()
        {
            return totNumOfSeats;
        }

        /// <summary>
        /// Adds a reservation. Saves the name, price and reservation status in the seats objekt.
        /// </summary>
        /// <param name="name">Name of the customer</param>
        /// <param name="price">Price paid for the seat</param>
        /// <param name="index">Seat number (Index of the array position)</param>
        /// <returns></returns>
        public bool ReserveSeat(string name, double price, int theSeat)
        {
            if (CheckIndex(theSeat))
            {
                seats[theSeat].name = name;
                seats[theSeat].price = price;
                seats[theSeat].reserved = true;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Cancels a reservation. Assigns a "null" value in the nameList and a price of 0.0 in the priceList.
        /// </summary>
        /// <param name="index">Index of array position</param>
        /// <returns></returns>
        public bool CancelSeat(int theSeat)
        {
            if (CheckIndex(theSeat))
            {
                seats[theSeat].name = string.Empty;
                seats[theSeat].price = 0.0;
                seats[theSeat].reserved = false;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// This method prepares an array of stings that is used for inserting information about all seats.
        /// It uses the GetSeatInfoAt function for individual seats.
        /// </summary>
        /// <returns></returns>
        public string[] GetSeatInfoStrings(DisplayMode choice)
        {
            int count = GetNumOfSeats();

            if ((count <= 0))
                return null;

            string[] strSeatInfoStrings;
            if (choice == DisplayMode.All)
            {
                strSeatInfoStrings = new string[count];
                for (int index = 0; index <= totNumOfSeats - 1; index++)
                {
                    strSeatInfoStrings[index] = seats[index].ToString();
                }
            }
            else if (choice == DisplayMode.Vacant)
            {
                strSeatInfoStrings = new string[GetNumVacant()];
                int seat = 0;
                for (int index = 0; index <= totNumOfSeats - 1; index++)
                {
                    if (!seats[index].reserved)
                    {
                        strSeatInfoStrings[seat] = seats[index].ToString();
                        seat++;
                    }
                }
            }
            else
            {
                strSeatInfoStrings = new string[GetNumReserved()];
                int seat = 0;
                for (int index = 0; index <= totNumOfSeats - 1; index++)
                {
                    if (seats[index].reserved)
                    {
                        strSeatInfoStrings[seat] = seats[index].ToString();
                        seat++;
                    }
                }
            }
            return strSeatInfoStrings;
        }

        /// <summary>
        /// Checks whether the seat is reserved or not by checking if there is a name in that spot.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool IsReserved(int index)
        {
            return seats[index].reserved;
            //if (string.IsNullOrEmpty(seats[index].name))
            //    return false;
            //else
            //    return true;
        }

        public double GetRevenue()
        {
            double totalRevenue = 0.0;
            for (int i = 0; i < totNumOfSeats; i++)
            {
                totalRevenue += seats[i].price;
            }
            return totalRevenue;
        }

        /// <summary>
        /// This method is used in order to extract a number. 
        /// Gotta have this in order to reserve while "Vacant" is diplayed.
        /// </summary>
        /// <param name="toBeReplaced"></param>
        /// <returns></returns>
        public int ExtractNumber(string toBeReplaced)
        {
            int theSeat = 0;
            string seatNumber = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                if (char.IsDigit(toBeReplaced[i]))
                    seatNumber += toBeReplaced[i];
            }
            int.TryParse(seatNumber, out theSeat);
            return theSeat;
        }
    }
}
