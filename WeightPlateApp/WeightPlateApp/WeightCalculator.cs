using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightPlateApp
{
    public class WeightCalculator
    {
        double weight = 0;

        public WeightCalculator(double weight)
        {
            setWeight(weight);
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


        public String weightToDisplay(double weightEitherSideOfBar)
        {
            String txt = "";
            double weightLeft;
            double weight;
            txt += "20 plates : " + (int)weightEitherSideOfBar / 20 + "\n";
            if (weightEitherSideOfBar % 20 > 0)
            {
                txt += "20 plates : " + (int)weightEitherSideOfBar / 20 + "\n";
                weightLeft = (int)weightEitherSideOfBar % 20;
                if(weightLeft % 20 > 0)
                {
                    txt += "15 plates : " + (int)weightLeft / 15 + "\n";
                    weightLeft = (int)weightLeft % 15;
                    if(weightLeft%15 > 0)   

                    {
                        txt += "10 plates : " + (int)weightLeft / 10 + "\n";
                        weightLeft = (int)weightLeft % 10;
                        if (weightLeft % 10 > 0)
                        {
                            txt += "5 plates : " + (int)weightLeft / 5 + "\n";
                            weightLeft = weightLeft -  5;
                            if (weightLeft == 2.5)

                            {
                                txt += "2.5 plates : 1\n" ;
                                weightLeft = weightLeft - 2.5;
                             if (weightLeft >= 1.25 )
                                {
                                    txt += "1.25 plates : 1\n";/*+ (int)weightLeft / 1.25 + "\n";*/
                                }
                            }
                        }

                    }
                }
            }
            return txt;
        }



        // recursive method
        public void calcPlatesNeeded(double weight)
        {
            subCalcPlatesNeeded(20, calcWeight(100));
        }

        private String subCalcPlatesNeeded(double plate, double weight)
        {
            String txt = "";
            double weightLeft = 0;
            txt += plate + " plates : " + (int)weight / plate + "\n";
            if(weight == 0)
            {
                return txt;
            }
            if(plate >= 5)
            {
                //calc here
                plate = plate / 2;
                subCalcPlatesNeeded(plate, weightLeft);
            }
            else
            {
               
            }
            return txt;
        }

    }
}
