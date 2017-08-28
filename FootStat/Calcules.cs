using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootStat
{
    public class Calcules
    {
        public double cal_sergent(double poids, double dissaut,double tail) {
            double result = (poids * dissaut) / tail; 
            return result;
        }
        public double cal_controledeball(double first, double second, double third)
        {
            return first+second+third;
        }
        public double cal_VO2MAX(double distances)
        {
            double new_dist = distances / 1000;
            double vit = new_dist * 12; // Km_h
            double vit2 = vit * 2.27;
            double vitF = vit2 + 13.3;
            return vitF;
        }
        public double cal_IMC(double poid, double tails)
        {
            double newTail = tails / 100;
            double result = poid / (newTail * newTail);
            return result;
        }
        public double cal_BRODIS(double test1, double testN)
        {
            double BROD;
            BROD = 100 * (testN - test1);
            BROD = BROD / (0.5 * (test1+testN));
            return BROD; // par %
        }
    }
}
