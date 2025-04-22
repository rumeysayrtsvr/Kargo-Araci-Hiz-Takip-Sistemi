using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kargoAraciHizTakipUygulamasi
{
    public static class Program
    {
        public delegate void SpeedHandler(string plaka, int hız, string marka, double enlem, double boylam, double mevcutEnlem, double mevcutBoylam);

        class CargoVehicle
        {
            private string plaka;
            private string marka;
            private int hız;
            private double enlem = 0;
            private double boylam;


            public string Plaka
            {
                get
                {
                    return plaka;
                }
                set
                {
                    plaka = value;
                }

            }

            public int Speed
            {
                get
                {
                    return hız;
                }
                set
                {
                    hız = value;
                    if (hız > 110)
                    {
                        Random random = new Random();
                      //  enlem = random.NextDouble() * 180 ; 180-90
                        boylam = random.NextDouble() * 360;   //360-180

                        double saat = 0.5 ;   //Aştığı andan sonraki yarım saatlik zaman dilimi

                        double mevcutEnlem = (enlem + hız * saat);        
                        double mevcutBoylam = (boylam + hız * saat);               //Aştığı andan yarım saat sonraki mevcut konumu

                        SpeedExceeded(Plaka, hız,marka, enlem, boylam,mevcutEnlem, mevcutBoylam);


                       


                    }
                }
            }


            public string Marka
            {
                 get
                {
                    return marka;
                }
                set
                {
                    marka = value;
                }
            }



            public CargoVehicle() { }
            public CargoVehicle(string plaka, string marka)
            {
                Plaka = plaka;
                Marka = marka;
            }

            public event SpeedHandler SpeedExceeded;
        }
        static void Main(string[] args)
        {
            CargoVehicle kargo_aracı1 = new CargoVehicle("42SU1975", "Ford");
            CargoVehicle kargo_aracı2 = new CargoVehicle("06TR1923", "Mercedes");
          
            kargo_aracı1.SpeedExceeded += kargo_aracı_SpeedExceeded;
            kargo_aracı2.SpeedExceeded += kargo_aracı_SpeedExceeded;
           

            for (byte i = 80; i < 130; i += 5)
            {
                kargo_aracı1.Speed = i;
                kargo_aracı2.Speed = (i + 8);
                

                Console.WriteLine(kargo_aracı1.Plaka + " plakalı aracın hızı = " + kargo_aracı1.Speed);
                Console.WriteLine(kargo_aracı2.Plaka + " plakalı aracın hızı = " + kargo_aracı2.Speed);
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine(); 
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
        
        public static void kargo_aracı_SpeedExceeded (string plaka,int hız,string marka,double enlem,double boylam, double mevcutEnlem, double mevcutBoylam)
        {
            DateTime tarih = DateTime.Now;
            Console.WriteLine(plaka + " plakalı " + marka +" marka kargo aracı hız limitini aştı.");
            Console.WriteLine("Aracın hız limitini aştığı konum : " + enlem + "° enlem ve " + boylam + "° boylam");
            Console.WriteLine("Aracın şu anki konumu : " + mevcutEnlem + "° enlem ve " + mevcutBoylam + "° boylam");
            Console.WriteLine(tarih + " anında aracın hızı = " + hız + " olarak ölçüldü.");
            Console.WriteLine();
        }
    }

    }

