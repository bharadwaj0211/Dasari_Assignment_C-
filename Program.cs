using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string con = String.Empty;
            var ch = 'q';
            var b = true;
            var i = 1;
            decimal costPerKm = 5.0m;
            decimal costPerMile = 7.0m;
            var doub=0.0;
            
            while (con==""){
                
            Console.WriteLine($"\n{i}.Press 'miles' for kilometers to miles conversion.\n");
            Console.WriteLine($"{i+1}.Press 'km' for miles to kilometers conversion.\n");
            con = Console.ReadLine();

            if(con == "miles"){
                
                Console.WriteLine("Enter distance in km : ");
                 var d = Console.ReadLine();
                doub = Convert.ToDouble(d);
                
                Console.WriteLine($"Distance in Miles : {kmtomiles(doub)}");
            }
            
            else if (con == "km"){
                Console.WriteLine("Enter distance in miles :");
                 var d = Console.ReadLine();
                 double dis = Convert.ToDouble(d);
                
                Console.WriteLine($"Distance in Miles : {milestokm(dis)}");
            }

            }
            while(b){
             Console.WriteLine("Enter 'c' for cost of fuel per km, 'p' for cost of fuel per mile");
             var s=Console.ReadLine();
             ch = Convert.ToChar(s);
              switch (ch)
             {
                 case 'c' : Console.WriteLine("Enter no of km :");
                 var k=Console.ReadLine();
                  var p = Convert.ToDecimal(k);
                 Console.WriteLine($"Cost of fule per km is {p*costPerKm}.");
                 Console.WriteLine("Thank you !");
                 break;

                 case 'p' : Console.WriteLine("Enter no of miles");
                 var l = Console.ReadLine();
                 var m = Convert.ToDecimal(l);
                 Console.WriteLine($"Cost of fuel per mile is {m*costPerMile}.");
                 Console.WriteLine("Thank You !");
                 break;

                 default: 
                 break;
                 
             }
             b = false;

        }
             

            double kmtomiles(double d)
            {
                double miles=d*0.62;
                return miles;
            }
           
           double milestokm(double d)
           {
               double km=d*1.6;
               return km;
           }

        

        
        }   
        
    }
}
    

