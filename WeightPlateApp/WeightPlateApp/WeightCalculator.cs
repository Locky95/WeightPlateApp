using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightPlateApp
{
    public class WeightCalculator
    {
        public double weight;
        public WeightCalculator()
        {

        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }
        public double getWeight()
        {
            return weight;
        }
        public double calcWeight(double weight)
        {
            double weightEitherSideOfBar = (weight - 20) / 2;
            return weightEitherSideOfBar;
        }         
        // recursive method
        public String calcPlatesNeeded(double weight)
        {
            String txt;
            if (weight < 20)
            {
                txt = "The desired weight is less than the bar";
            }
            else
            {
                txt = subCalcPlatesNeeded(25, calcWeight(weight));
            }
           return txt;
        }
        private String subCalcPlatesNeeded(double plate, double weight)
        {
            double weightLeft;
            String txt = "";
            if (weight == 0)
            {
                return txt;
            }
            if(plate > 5 && weight > 0)
            {
                txt += "\n" + plate + "'s : " + (int)weight / (int)plate + "\n";
                weightLeft = weight % plate;
                plate = plate - 5;    
            }
            else
            {
                txt += "\n" + plate + "'s : " + (int) weight / (int)plate + "\n";
                weightLeft = weight % plate;
                plate = plate / 2;
            }
            return txt += subCalcPlatesNeeded(plate, weightLeft);  
        }
    }
}
