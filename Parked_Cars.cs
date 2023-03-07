using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parked_Cars_Class
{
    internal class Parked_Cars
    {
        // varabiles
        
       public string model, color;
       public int time_parked = 0, license_number = 0;
        
        //main class constructor
       public Parked_Cars(string Model, string Color, int License_number, int Time_park)
        {
           this.model = Model  ;
           this.color =Color;
           this.license_number = License_number ;
           this.time_parked = Time_park ;
        }



        // car generator
       public Parked_Cars()
        {
            // car models, in this case make was eaiser to insert 
            string[] car_makes  = {"Acura","Audi","BMW","Bentley","Buick","Cadillac","Chevrolet","Ford","GMC","Honda"
                                   ,"Hyundai","Jeep","Kia","Lexus","Lincoln","Maserati","Mazda","Mercedes-Benz","Mini"
                                   ,"Mitsubishi","Nissan","Polestar","Porsche","Ram","Subaru","Toyota","Volkswagen","Volvo" };
            // differnt colors the cars can be generated in
            string[] car_colors = {"white","black","gray","silver","blue","red","brown","green","orange","yellow","gold"};
            
            // rand is a new random object that will be used for, what else the idea of random data
            Random rand = new Random();
           
            model = car_makes[rand.Next(0,car_makes.Length)]; 
            color = car_colors[rand.Next(0,car_colors.Length)];
            license_number = rand.Next(100000000,999999999);// license numbers normally take 9 digits 
            time_parked = rand.Next(10,500); // time parked in minutes

        }

    }
}
