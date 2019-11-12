using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles
{
    public class Hotel 
    {

        public string Name { get; set; }

        public int Room { get; set; }

        public int Floor { get; set; }

        public int Area { get; set; }


        /*public Hotel (string Name, int Room, int Floor, int Area)
        {
            this.Name = Name;

            this.Room = Room;

            this.Floor = Floor;

            this.Area = Area;

        }*/

        public static int CalculateMaintenance(int Rooms)
        {
            
            int salaryWorker = 1500;
            Double workerCapacity = (1 / 20);

            int totalCost = Convert.ToInt32(workerCapacity * Rooms * salaryWorker);
            
            return totalCost ;
           
        }


    }
}
