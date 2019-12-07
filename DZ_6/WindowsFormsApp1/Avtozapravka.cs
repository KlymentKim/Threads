using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public class Avtozapravka
    {
        public string NameGas { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{NameGas}";
        }
    }

  public class Food
    {
        public string NameFood{ get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{NameFood} ";
        }

    }
}
