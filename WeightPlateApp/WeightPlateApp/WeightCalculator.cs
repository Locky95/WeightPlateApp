using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightPlateApp
{
    public class WeightCalculator
    {
        public WeightCalculator()
        {

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
  
               txt += "\n20 plates : " + (int) calcWeight(weightEitherSideOfBar) / 20 + "\n";
                weightLeft = weightEitherSideOfBar % 20;
                if(weightLeft > 0)
                {
                    txt += "15 plates : " + (int)weightLeft / 15 + "\n";
                    weightLeft = (int)weightLeft % 15;
                    if(weightLeft> 0)   

                    {
                        txt += "10 plates : " + (int)weightLeft / 10 + "\n";
                        weightLeft = (int)weightLeft % 10;
                        if (weightLeft > 0)
                        {
                            txt += "5 plates : " + (int)weightLeft / 5 + "\n";
                            weightLeft = weightLeft % 5;
                        if (weightLeft > 0)
                            {
                                txt += "2.5 plates : "+ (int) weightLeft / 2 + "\n" ;
                                weightLeft = weightLeft % 2.5;
                            if (weightLeft > 0 )
                                {
                                    txt += "1.25 plates : 1\n";
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
