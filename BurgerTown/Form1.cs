using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace BurgerTown
{

    public partial class taxOutput : Form
    {
        //variables
        const double TACO_PRICE = 3.99;
        const double BURRITO_PRICE = 4.99;
        const double FRY_PRICE = 3.49;
        const double DRINK_PRICE = 1.50;
        const double TAX = 0.13;
        int tacos;
        int fries;
        int drinks;
        int burritos;
        double subTotal;
        double taxTotal;
        double grandTotal;
        double cash;
        double change;


        public taxOutput()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                tacos = Convert.ToInt16(tacoInput.Text);
                burritos = Convert.ToInt16(burritoInput.Text);
                fries = Convert.ToInt16(fryInput.Text);
                drinks = Convert.ToInt16(drinkInput.Text);

                //maths 
                subTotal = (tacos * TACO_PRICE) + (burritos * BURRITO_PRICE) + (drinks * DRINK_PRICE) + (fries * FRY_PRICE);
                taxTotal = TAX * subTotal;
                grandTotal = taxTotal + subTotal;
                //display
                grandTotalOutput.Text = grandTotal.ToString("C");
                taxTotalLabel.Text = taxTotal.ToString("C");
                subTotalOut.Text = subTotal.ToString("C");

            }
            catch
            {
                grandTotalOutput.Text = "INVALID INPUTS";
                taxTotalLabel.Text = "INVALID INPUTS";
                subTotalOut.Text = "INVALID";
            }
        }

        private void changeDue_Click(object sender, EventArgs e)
        {
            try
            {
                //variables+maths
                cash = Convert.ToDouble(changeInput.Text);
                change = cash - grandTotal;
                //display
                changeOutput.Text = change.ToString("C");
            }

            catch
            {
                changeOutput.Text = "INVALID";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //graphics, setup
            Graphics tacog = this.CreateGraphics();
            Pen printPen = new Pen(Color.Black, 10);
            SolidBrush printBrush = new SolidBrush(Color.Black);
            //Soundplayer, setup
            SoundPlayer chaching = new SoundPlayer(Properties.Resources.Cha_Ching_Register_Muska666_173262285);
            SoundPlayer print = new SoundPlayer(Properties.Resources.Dot_Matrix_Printer_SoundBible_com_790333844);

        }
    }
}
