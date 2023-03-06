using System;
using System.Collections.Generic;
using System.Text;

namespace team_project_parking_lot
{
    //makes all the cars
    public class parkingMeter
    {
        public int purchased_mins;

        //functions VVV
        public int purchaseMins()
        {
            int mins;
            Random rnd = new Random();
            mins = rnd.Next(0,300);
            return mins;
        }

    }

    public class simulation
    {
       
        parkingMeter meter = new parkingMeter();

        // this is what will run the final code
        public void simulate()
        {
            int x = 10; // this would be for how ever many cars we have
            //List<parkedCars> cars = new List<parkedCars>();
            //list above can be used for cars

            List<parkingMeter> mins = new List<parkingMeter>();
            for (int i = 0; i < x; i++)
            {
                // createing the cars should go here
                mins.Add(new parkingMeter());
                mins[i].purchased_mins = meter.purchaseMins();


            }
        }
    }

}
