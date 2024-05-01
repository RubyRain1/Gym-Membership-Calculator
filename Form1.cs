using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Membership_Calculator
{
    public partial class Form1 : Form
    {
        double bPrice = 0;
        double aPrice = 0;
        double tax;
        double total;
        public Form1()
        {
            InitializeComponent();
        }
        
        public void CalcBaseFee()
        {
            int teen = 20;
            int youngA = 30;
            int adult = 40;
            int seniorC = 30;
            


            // this is else if chain for calculating teen base price based on chosen month.
            if (radioButtonTeen.Checked && radioButton1M.Checked)
            {
                bPrice = teen;
            } else if (radioButtonTeen.Checked && radioButton2M.Checked)
            {
                bPrice = teen * 2;
            } else if (radioButtonTeen.Checked && radioButton3M.Checked)
            {
                bPrice = teen * 3;
            } 
            else if (radioButtonTeen.Checked && radioButton4M.Checked)
            {
                bPrice = teen * 4;
            }
            else if (radioButtonTeen.Checked && radioButton5M.Checked)
            {
                bPrice = teen * 5;
            }
            else if (radioButtonTeen.Checked && radioButton6M.Checked)
            {
                bPrice = teen * 6;
            }
            else if (radioButtonTeen.Checked && radioButton7M.Checked)
            {
                bPrice = teen * 7;
            }
            else if (radioButtonTeen.Checked && radioButton8M.Checked)
            {
                bPrice = teen * 8;
            }
            else if (radioButtonTeen.Checked && radioButton9M.Checked)
            {
                bPrice = teen * 9;
            }
            else if (radioButtonTeen.Checked && radioButton10M.Checked)
            {
                bPrice = teen * 10;
            }
            else if (radioButtonTeen.Checked && radioButton11M.Checked)
            {
                bPrice = teen * 11;
            }
            else if (radioButtonTeen.Checked && radioButton12M.Checked)
            {
                bPrice = teen * 12;
            }

            // this is else if chain for calculating young adult base price based on chosen month.
            // im sure this could be done more efficiently but it will do for the purpose.
            if (radioButtonYAdult.Checked && radioButton1M.Checked)
            {
                bPrice = youngA;
            }
            else if (radioButtonYAdult.Checked && radioButton2M.Checked)
            {
                bPrice = youngA * 2;
            }
            else if (radioButtonYAdult.Checked && radioButton3M.Checked)
            {
                bPrice = youngA * 3;
            }
            else if (radioButtonYAdult.Checked && radioButton4M.Checked)
            {
                bPrice = youngA * 4;
            }
 
            else if (radioButtonYAdult.Checked && radioButton5M.Checked)
            {
                bPrice = youngA * 5;
            }
            else if (radioButtonYAdult.Checked && radioButton6M.Checked)
            {
                bPrice = youngA * 6;
            }
            else if (radioButtonYAdult.Checked && radioButton7M.Checked)
            {
                bPrice = youngA * 7;
            }
            else if (radioButtonYAdult.Checked && radioButton8M.Checked)
            {
                bPrice = youngA * 8;
            }
            else if (radioButtonYAdult.Checked && radioButton9M.Checked)
            {
                bPrice = youngA * 9;
            }
            else if (radioButtonYAdult.Checked && radioButton10M.Checked)
            {
                bPrice = youngA * 10;
            }
            else if (radioButtonYAdult.Checked && radioButton11M.Checked)
            {
                bPrice = youngA * 11;
            }
            else if (radioButtonYAdult.Checked && radioButton12M.Checked)
            {
                bPrice = youngA * 12;
            }

            // this is else if chain for calculating adult base price based on chosen month.
            if (radioButtonAdult.Checked && radioButton1M.Checked)
            {
                bPrice = adult;
            }
            else if (radioButtonAdult.Checked && radioButton2M.Checked)
            {
                bPrice = adult * 2;
            }
            else if (radioButtonAdult.Checked && radioButton3M.Checked)
            {
                bPrice = adult * 3;
            }
            else if (radioButtonAdult.Checked && radioButton4M.Checked)
            {
                bPrice = adult * 4;
            }
            else if (radioButtonAdult.Checked && radioButton5M.Checked)
            {
                bPrice = adult * 5;
            }
            else if (radioButtonAdult.Checked && radioButton6M.Checked)
            {
                bPrice = adult * 6;
            }
            else if (radioButtonAdult.Checked && radioButton7M.Checked)
            {
                bPrice = adult * 7;
            }
            else if (radioButtonAdult.Checked && radioButton8M.Checked)
            {
                bPrice = adult * 8;
            }
            else if (radioButtonAdult.Checked && radioButton9M.Checked)
            {
                bPrice = adult * 9;
            }
            else if (radioButtonAdult.Checked && radioButton10M.Checked)
            {
                bPrice = adult * 10;
            }
            else if (radioButtonAdult.Checked && radioButton11M.Checked)
            {
                bPrice = adult * 11;
            }
            else if (radioButtonAdult.Checked && radioButton12M.Checked)
            {
                bPrice = adult * 12;
            }

            // this is else if chain for calculating adult base price based on chosen month and veteran discount.
            if (radioButtonAdult.Checked && radioButton1M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = adult - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton2M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 2) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton3M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 3) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton4M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 4) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton5M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 5) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton6M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 6) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton7M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 7) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton8M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 8) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton9M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 9) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton10M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 10) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton11M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 11) - (adult * .12);
            }
            else if (radioButtonAdult.Checked && radioButton12M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (adult * 12) - (adult * .12);
            }

            // this is else if chain for calculating senior citizen base price based on chosen month.
            if (radioButtonSeniorC.Checked && radioButton1M.Checked)
            {
                bPrice = seniorC;
            }
            else if (radioButtonSeniorC.Checked && radioButton2M.Checked)
            {
                bPrice = seniorC * 2;
            }
            else if (radioButtonSeniorC.Checked && radioButton3M.Checked)
            {
                bPrice = seniorC * 3;
            }
            else if (radioButtonSeniorC.Checked && radioButton4M.Checked)
            {
                bPrice = seniorC * 4;
            }
            else if (radioButtonSeniorC.Checked && radioButton5M.Checked)
            {
                bPrice = seniorC * 5;
            }
            else if (radioButtonSeniorC.Checked && radioButton6M.Checked)
            {
                bPrice = seniorC * 6;
            }
            else if (radioButtonSeniorC.Checked && radioButton7M.Checked)
            {
                bPrice = seniorC * 7;
            }
            else if (radioButtonSeniorC.Checked && radioButton8M.Checked)
            {
                bPrice = seniorC * 8;
            }
            else if (radioButtonSeniorC.Checked && radioButton9M.Checked)
            {
                bPrice = seniorC * 9;
            }
            else if (radioButtonSeniorC.Checked && radioButton10M.Checked)
            {
                bPrice = seniorC * 10;
            }
            else if (radioButtonSeniorC.Checked && radioButton11M.Checked)
            {
                bPrice = seniorC * 11;
            }
            else if (radioButtonSeniorC.Checked && radioButton12M.Checked)
            {
                bPrice = seniorC * 12;
            }

            // this is else if chain for calculating senior base price based on chosen month and veteran discount.
            if (radioButtonSeniorC.Checked && radioButton1M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = seniorC - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton2M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 2) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton3M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 3) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton4M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 4) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton5M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 5) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton6M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 6) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton7M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 7) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton8M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 8) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton9M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 9) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton10M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 10) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton11M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 11) - (seniorC * .12);
            }
            else if (radioButtonSeniorC.Checked && radioButton12M.Checked && checkBoxVetMil.Checked)
            {
                bPrice = (seniorC * 12) - (seniorC * .12);
            }

            
        }
        
        public void CalcAdditionalFees()
        {
            
            int yoga = 15;
            int zumba = 18;
            int karate = 23;
            int waterFit = 25;
            int pTrainer = 50;

            // additional costs for yoga calculations.
            if (checkBoxYoga.Checked)
            {
                aPrice = (yoga);

            } if (checkBoxYoga.Checked && checkBoxZumba.Checked)
            {
                aPrice = (yoga + zumba);
            }
            if (checkBoxYoga.Checked && checkBoxKarate.Checked)
            {
                aPrice = (yoga + karate);
            }
            if (checkBoxYoga.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (yoga + waterFit);
            }
            if (checkBoxYoga.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (yoga + pTrainer);
            }
            //3's

            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked)
            {
                aPrice = (zumba + karate + yoga);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (zumba + waterFit + yoga);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (zumba + pTrainer + yoga);
            }
            if (checkBoxYoga.Checked && checkBoxWFitness.Checked && checkBoxKarate.Checked)
            {
                aPrice = (waterFit + karate + yoga);
            }
            if (checkBoxYoga.Checked && checkBoxPTrainer.Checked && checkBoxKarate.Checked)
            {
                aPrice = (pTrainer + karate + yoga);
            }
            if (checkBoxYoga.Checked && checkBoxPTrainer.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (pTrainer + waterFit + yoga);
            }
            //4's

            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + yoga + zumba + pTrainer);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (pTrainer + yoga + zumba + waterFit);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit);
            }
            if (checkBoxYoga.Checked && checkBoxPTrainer.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + yoga + pTrainer + waterFit);
            }
            //5's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit + pTrainer);
            }

            // additional costs for zumba calculations.
            if (checkBoxZumba.Checked)
            {
                aPrice = (zumba);

            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked)
            {
                aPrice = (yoga + zumba);
            }
            if (checkBoxZumba.Checked && checkBoxKarate.Checked)
            {
                aPrice = (zumba + karate);
            }
            if (checkBoxZumba.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (zumba + waterFit);
            }
            if (checkBoxZumba.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (zumba + pTrainer);
            }
            //3's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked)
            {
                aPrice = (zumba + karate + yoga);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (zumba + waterFit + yoga);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (zumba + pTrainer + yoga);
            }
            if (checkBoxKarate.Checked && checkBoxZumba.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (zumba + waterFit + karate);
            }
            if (checkBoxKarate.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (zumba + karate + pTrainer);
            }
            if (checkBoxPTrainer.Checked && checkBoxZumba.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (zumba + waterFit + pTrainer);
            }
            //4's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + yoga + zumba + pTrainer);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (pTrainer + yoga + zumba + waterFit);
            }

            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + yoga + zumba + pTrainer);
            }
            if (checkBoxPTrainer.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + pTrainer + zumba + waterFit);
            }
            //5's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit + pTrainer);
            }
            

            // additional costs for karate calculations.
            if (checkBoxKarate.Checked)
            {
                aPrice = (karate);
            }
            if (checkBoxYoga.Checked && checkBoxKarate.Checked)
            {
                aPrice = (yoga + karate);
            }
            if (checkBoxZumba.Checked && checkBoxKarate.Checked)
            {
                aPrice = (zumba + karate);
            }
            if (checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + waterFit);
            }
            if (checkBoxKarate.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + pTrainer);
            }

            //3's 
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked)
            {
                aPrice = (zumba + karate + yoga);
            }
            if (checkBoxYoga.Checked && checkBoxWFitness.Checked && checkBoxKarate.Checked)
            {
                aPrice = (waterFit + karate + yoga);
            }
            if (checkBoxYoga.Checked && checkBoxPTrainer.Checked && checkBoxKarate.Checked)
            {
                aPrice = (pTrainer + karate + yoga);
            }
            if (checkBoxZumba.Checked && checkBoxWFitness.Checked && checkBoxKarate.Checked)
            {
                aPrice = (waterFit + karate + zumba);
            }
            if (checkBoxZumba.Checked && checkBoxPTrainer.Checked && checkBoxKarate.Checked)
            {
                aPrice = (pTrainer + karate + zumba);
            }
            if (checkBoxPTrainer.Checked && checkBoxWFitness.Checked && checkBoxKarate.Checked)
            {
                aPrice = (waterFit + karate + pTrainer);
            }

            //4's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + yoga + zumba + pTrainer);
            }
            if (checkBoxPTrainer.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + pTrainer + zumba + waterFit);
            }

            //5's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit + pTrainer);
            }

            // additional costs for water fitness calculations.
            if (checkBoxWFitness.Checked)
            {
                aPrice = (waterFit);

            }
            if (checkBoxYoga.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (yoga + waterFit);
            }
            if (checkBoxZumba.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (zumba + waterFit);
            }
            if (checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + waterFit);
            }
            if (checkBoxWFitness.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (waterFit + pTrainer);
            }

            //3's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (waterFit + yoga + zumba);
            }
            if (checkBoxWFitness.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked)
            {
                aPrice = (waterFit + karate + yoga);
            }
            if (checkBoxWFitness.Checked && checkBoxPTrainer.Checked && checkBoxKarate.Checked)
            {
                aPrice = (waterFit + pTrainer + yoga);
            }
            if (checkBoxWFitness.Checked && checkBoxKarate.Checked && checkBoxZumba.Checked)
            {
                aPrice = (waterFit + karate + zumba);
            }
            if (checkBoxWFitness.Checked && checkBoxPTrainer.Checked && checkBoxZumba.Checked)
            {
                aPrice = (waterFit + pTrainer + zumba);
            }
            if (checkBoxWFitness.Checked && checkBoxPTrainer.Checked && checkBoxKarate.Checked)
            {
                aPrice = (waterFit + pTrainer + karate);
            }

            //4's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (pTrainer + yoga + zumba + waterFit);
            }
            if (checkBoxYoga.Checked && checkBoxPTrainer.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + yoga + pTrainer + waterFit);
            }
            if (checkBoxPTrainer.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (karate + pTrainer + zumba + waterFit);
            }

            //5's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit + pTrainer);
            }

            // additional costs for personal trainer calculations.
            if (checkBoxPTrainer.Checked)
            {
                aPrice = (pTrainer);

            }
            if (checkBoxYoga.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (yoga + pTrainer);
            }
            if (checkBoxZumba.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (zumba + pTrainer);
            }
            if (checkBoxKarate.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + pTrainer);
            }
            if (checkBoxWFitness.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (waterFit + pTrainer);
            }

            //3's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (pTrainer + yoga + zumba);
            }
            if (checkBoxPTrainer.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked)
            {
                aPrice = (pTrainer + karate + yoga);
            }
            if (checkBoxPTrainer.Checked && checkBoxWFitness.Checked && checkBoxKarate.Checked)
            {
                aPrice = (pTrainer + karate + waterFit);
            }
            if (checkBoxPTrainer.Checked && checkBoxWFitness.Checked && checkBoxKarate.Checked)
            {
                aPrice = (pTrainer + karate + waterFit);
            }
            if (checkBoxPTrainer.Checked && checkBoxWFitness.Checked && checkBoxZumba.Checked)
            {
                aPrice = (pTrainer + waterFit + zumba);
            }
            if (checkBoxPTrainer.Checked && checkBoxWFitness.Checked && checkBoxYoga.Checked)
            {
                aPrice = (pTrainer + yoga + waterFit);
            }
            if (checkBoxPTrainer.Checked && checkBoxKarate.Checked && checkBoxZumba.Checked)
            {
                aPrice = (pTrainer + zumba + karate);
            }

            //4's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked && checkBoxKarate.Checked)
            {
                aPrice = (pTrainer + yoga + zumba + karate);
            }
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (pTrainer + yoga + zumba + waterFit);
            }
            if (checkBoxKarate.Checked && checkBoxZumba.Checked && checkBoxPTrainer.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (pTrainer + karate + zumba + waterFit);
            }
            if (checkBoxYoga.Checked && checkBoxKarate.Checked && checkBoxPTrainer.Checked && checkBoxWFitness.Checked)
            {
                aPrice = (pTrainer + yoga + karate + waterFit);
            }

            //5's
            if (checkBoxYoga.Checked && checkBoxZumba.Checked && checkBoxKarate.Checked && checkBoxWFitness.Checked && checkBoxPTrainer.Checked)
            {
                aPrice = (karate + yoga + zumba + waterFit + pTrainer);
            }


            // this is else if chain for calculating yoga additional price based on chosen month.
            if (checkBoxYoga.Checked && radioButton1M.Checked)
            {
                aPrice = yoga;
            }
            else if (checkBoxYoga.Checked && radioButton2M.Checked)
            {
                bPrice = yoga * 2;
            }
            else if (checkBoxYoga.Checked && radioButton3M.Checked)
            {
                bPrice = yoga * 3;
            }
            else if (checkBoxYoga.Checked && radioButton4M.Checked)
            {
                bPrice = yoga * 4;
            }
            else if (checkBoxYoga.Checked && radioButton5M.Checked)
            {
                bPrice = yoga * 5;
            }
            else if (checkBoxYoga.Checked && radioButton6M.Checked)
            {
                bPrice = yoga * 6;
            }
            else if (checkBoxYoga.Checked && radioButton7M.Checked)
            {
                bPrice = yoga * 7;
            }
            else if (checkBoxYoga.Checked && radioButton8M.Checked)
            {
                bPrice = yoga * 8;
            }
            else if (checkBoxYoga.Checked && radioButton9M.Checked)
            {
                bPrice = yoga * 9;
            }
            else if (checkBoxYoga.Checked && radioButton10M.Checked)
            {
                bPrice = yoga * 10;
            }
            else if (checkBoxYoga.Checked && radioButton11M.Checked)
            {
                bPrice = yoga * 11;
            }
            else if (checkBoxYoga.Checked && radioButton12M.Checked)
            {
                bPrice = yoga * 12;
            }

            // this is else if chain for calculating zumba additional price based on chosen month.
            if (checkBoxZumba.Checked && radioButton1M.Checked)
            {
                aPrice = zumba;
            }
            else if (checkBoxZumba.Checked && radioButton2M.Checked)
            {
                bPrice = zumba * 2;
            }
            else if (checkBoxZumba.Checked && radioButton3M.Checked)
            {
                bPrice = zumba * 3;
            }
            else if (checkBoxZumba.Checked && radioButton4M.Checked)
            {
                bPrice = zumba * 4;
            }
            else if (checkBoxZumba.Checked && radioButton5M.Checked)
            {
                bPrice = zumba * 5;
            }
            else if (checkBoxZumba.Checked && radioButton6M.Checked)
            {
                bPrice = zumba * 6;
            }
            else if (checkBoxZumba.Checked && radioButton7M.Checked)
            {
                bPrice = zumba * 7;
            }
            else if (checkBoxZumba.Checked && radioButton8M.Checked)
            {
                bPrice = zumba * 8;
            }
            else if (checkBoxZumba.Checked && radioButton9M.Checked)
            {
                bPrice = zumba * 9;
            }
            else if (checkBoxZumba.Checked && radioButton10M.Checked)
            {
                bPrice = zumba * 10;
            }
            else if (checkBoxZumba.Checked && radioButton11M.Checked)
            {
                bPrice = zumba * 11;
            }
            else if (checkBoxZumba.Checked && radioButton12M.Checked)
            {
                bPrice = zumba * 12;
            }

            // this is else if chain for calculating zumba additional price based on chosen month.
            if (checkBoxKarate.Checked && radioButton1M.Checked)
            {
                aPrice = karate;
            }
            else if (checkBoxKarate.Checked && radioButton2M.Checked)
            {
                bPrice = karate * 2;
            }
            else if (checkBoxKarate.Checked && radioButton3M.Checked)
            {
                bPrice = karate * 3;
            }
            else if (checkBoxKarate.Checked && radioButton4M.Checked)
            {
                bPrice = karate * 4;
            }
            else if (checkBoxKarate.Checked && radioButton5M.Checked)
            {
                bPrice = karate * 5;
            }
            else if (checkBoxKarate.Checked && radioButton6M.Checked)
            {
                bPrice = karate * 6;
            }
            else if (checkBoxKarate.Checked && radioButton7M.Checked)
            {
                bPrice = karate * 7;
            }
            else if (checkBoxKarate.Checked && radioButton8M.Checked)
            {
                bPrice = karate * 8;
            }
            else if (checkBoxKarate.Checked && radioButton9M.Checked)
            {
                bPrice = karate * 9;
            }
            else if (checkBoxKarate.Checked && radioButton10M.Checked)
            {
                bPrice = karate * 10;
            }
            else if (checkBoxKarate.Checked && radioButton11M.Checked)
            {
                bPrice = karate * 11;
            }
            else if (checkBoxKarate.Checked && radioButton12M.Checked)
            {
                bPrice = karate * 12;
            }

            // this is else if chain for calculating zumba additional price based on chosen month.
            if (checkBoxWFitness.Checked && radioButton1M.Checked)
            {
                aPrice = waterFit;
            }
            else if (checkBoxWFitness.Checked && radioButton2M.Checked)
            {
                bPrice = waterFit * 2;
            }
            else if (checkBoxWFitness.Checked && radioButton3M.Checked)
            {
                bPrice = waterFit * 3;
            }
            else if (checkBoxWFitness.Checked && radioButton4M.Checked)
            {
                bPrice = waterFit * 4;
            }
            else if (checkBoxWFitness.Checked && radioButton5M.Checked)
            {
                bPrice = waterFit * 5;
            }
            else if (checkBoxWFitness.Checked && radioButton6M.Checked)
            {
                bPrice = waterFit * 6;
            }
            else if (checkBoxWFitness.Checked && radioButton7M.Checked)
            {
                bPrice = waterFit * 7;
            }
            else if (checkBoxWFitness.Checked && radioButton8M.Checked)
            {
                bPrice = waterFit * 8;
            }
            else if (checkBoxWFitness.Checked && radioButton9M.Checked)
            {
                bPrice = waterFit * 9;
            }
            else if (checkBoxWFitness.Checked && radioButton10M.Checked)
            {
                bPrice = waterFit * 10;
            }
            else if (checkBoxWFitness.Checked && radioButton11M.Checked)
            {
                bPrice = waterFit * 11;
            }
            else if (checkBoxWFitness.Checked && radioButton12M.Checked)
            {
                bPrice = waterFit * 12;
            }

            // this is else if chain for calculating zumba additional price based on chosen month.
            if (checkBoxPTrainer.Checked && radioButton1M.Checked)
            {
                aPrice = pTrainer;
            }
            else if (checkBoxPTrainer.Checked && radioButton2M.Checked)
            {
                bPrice = pTrainer * 2;
            }
            else if (checkBoxPTrainer.Checked && radioButton3M.Checked)
            {
                bPrice = pTrainer * 3;
            }
            else if (checkBoxPTrainer.Checked && radioButton4M.Checked)
            {
                bPrice = pTrainer * 4;
            }
            else if (checkBoxPTrainer.Checked && radioButton5M.Checked)
            {
                bPrice = pTrainer * 5;
            }
            else if (checkBoxPTrainer.Checked && radioButton6M.Checked)
            {
                bPrice = pTrainer * 6;
            }
            else if (checkBoxPTrainer.Checked && radioButton7M.Checked)
            {
                bPrice = pTrainer * 7;
            }
            else if (checkBoxPTrainer.Checked && radioButton8M.Checked)
            {
                bPrice = pTrainer * 8;
            }
            else if (checkBoxPTrainer.Checked && radioButton9M.Checked)
            {
                bPrice = pTrainer * 9;
            }
            else if (checkBoxPTrainer.Checked && radioButton10M.Checked)
            {
                bPrice = pTrainer * 10;
            }
            else if (checkBoxPTrainer.Checked && radioButton11M.Checked)
            {
                bPrice = pTrainer * 11;
            }
            else if (checkBoxPTrainer.Checked && radioButton12M.Checked)
            {
                bPrice = pTrainer * 12;
            }
        }

        public void CalcSalesTax()
        {
            CalcBaseFee();
            CalcAdditionalFees();
            double salesT = ((bPrice + aPrice) * .06);
            tax = salesT;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalcBaseFee();
            CalcAdditionalFees();
            CalcSalesTax();

            total = bPrice + aPrice + tax;
            MessageBox.Show($"{total}");
            
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            radioButton10M.Checked = false;
            radioButton11M.Checked = false;
            radioButton12M.Checked = false;
            radioButton1M.Checked = false;
            radioButton2M.Checked = false;
            radioButton3M.Checked = false;
            radioButton4M.Checked = false;
            radioButton5M.Checked = false;
            radioButton6M.Checked = false;
            radioButton7M.Checked = false;
            radioButton8M.Checked = false;
            radioButton9M.Checked = false;
            radioButtonAdult.Checked = false;
            radioButtonSeniorC.Checked = false;
            radioButtonTeen.Checked = false;
            radioButtonYAdult.Checked = false;
            checkBoxKarate.Checked = false;
            checkBoxPTrainer.Checked = false;
            checkBoxVetMil.Checked = false;
            checkBoxWFitness.Checked = false;
            checkBoxYoga.Checked = false;
            checkBoxZumba.Checked = false;
            total = 0;
            aPrice = 0;
            bPrice = 0;
            tax = 0;
            

        }
    }
}
