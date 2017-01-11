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

           
        public String weightToDisplay(double weightEitherSideOfBar)
        {
            String txt = "Put the following plates on both sides of the bar :                             ";
            double weightLeft;
            weightLeft = calcWeight(weightEitherSideOfBar);
               
               txt += "\n20 plates : " + (int) weightLeft / 20 + "     \n";
                weightLeft = weightLeft % 20;
                if(weightLeft > 0)
                { 
                    txt += "\n15 plates : " + (int)weightLeft / 15 + "      \n";
                    weightLeft = weightLeft % 15;
                    if(weightLeft> 0)   

                    {
                        txt += "\n10 plates : " + (int)weightLeft / 10 + "         \n";
                        weightLeft = weightLeft % 10;
                        if (weightLeft > 0)
                        {
                            txt += "\n5 plates : " + (int)weightLeft / 5 + "      \n";
                            weightLeft = weightLeft % 5;
                        if (weightLeft > 0)
                            {
                                txt += "\n2.5 plates : "+ (int) weightLeft / 2 + "      \n\n" ;
                                weightLeft = weightLeft % 2.5;
                            if (weightLeft >= 1.25 )
                                {
                                    txt += "\n1.25 plates : " + (int) weightLeft / 1 + "      \n";
                                weightLeft = weightLeft % 1.25;
                                if (weightLeft > 0)
                                {
                                    txt += "\nWeight left over = " + (Math.Round(weightLeft, 2)) * 2 ;
                                }
                                }
                            }
                        }

                    }
            }
            return txt;
        }



        // recursive method
        public String calcPlatesNeeded(double weight)
        {
           String txt = subCalcPlatesNeeded(20, calcWeight(weight));
            return txt;
        }

        private String subCalcPlatesNeeded(double plate, double weight)
        {
            String txt = "";
            double weightLeft = 0;
         //   txt += plate + " plates : " + (int)weight / plate + "\n";
            if(weight <= 1)
            {
                return txt;
            }
            if(plate >= 5)
            {
                txt += "\n"+plate + "'s : 1";
                plate = plate / 2;
                subCalcPlatesNeeded(plate, weightLeft);
                return txt;
            }
            else
            {
                txt += "\n" + plate + "'s : " + (int)weight/plate;
                weight = weight % plate;
                plate = plate - 5;
                subCalcPlatesNeeded(plate, weightLeft);
            }
            return txt;
        }

    }
}
