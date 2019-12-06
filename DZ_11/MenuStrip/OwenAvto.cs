using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuStrip
{
   public class OwenAvto
    {
        public string Surname { get; set; }
        public string Model{ get; set; }
        public int yearMade { get; set; }
        public string VinCode { get; set; }
        public string AvColor { get; set; }
        public string NumCar { get; set; }

        public string ListView { get => $"{Surname} {Model} {AvColor} {yearMade} - {VinCode} - {NumCar}"; }
        public override string ToString()
        {
            return $"{Surname} {Model} {AvColor} {yearMade} - {VinCode} - {NumCar}";
        }
        public string SurnameView { get => $"{Surname}, {VinCode} - {NumCar}"; }


    }
}
