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
/// <summary>
/// This program demonstrates input, output, graphics & sounds
/// Created by Jon  Segeren, started on oct 6
/// </summary>
namespace BurgerTown
{

    public partial class form1 : Form
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


        public form1()
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
            Pen printPen = new Pen(Color.Black, 3);
            SolidBrush printBrush = new SolidBrush(Color.Black);
            Font titleFont = new Font("Vernada", 16);
            Font printFont = new Font("Vernada", 10);

            //Soundplayer, setup
            SoundPlayer chaching = new SoundPlayer(Properties.Resources.Cha_Ching_Register_Muska666_173262285);
            SoundPlayer print = new SoundPlayer(Properties.Resources.Dot_Matrix_Printer_SoundBible_com_790333844);

            //actual drawing of graphics
            chaching.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240,30);
            Thread.Sleep(300);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " + (tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            Thread.Sleep(300);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " + (tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            tacog.DrawString("Burritos       " + (burritos * BURRITO_PRICE).ToString("C"), printFont, printBrush, 250, 75);
            Thread.Sleep(300);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " + (tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            tacog.DrawString("Burritos       " + (burritos * BURRITO_PRICE).ToString("C"), printFont, printBrush, 250, 75);
            tacog.DrawString("Fries          " + (fries * FRY_PRICE).ToString("C"), printFont, printBrush, 250, 90);
            Thread.Sleep(300);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " + (tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            tacog.DrawString("Burritos       " + (burritos * BURRITO_PRICE).ToString("C"), printFont, printBrush, 250, 75);
            tacog.DrawString("Fries          " + (fries * FRY_PRICE).ToString("C"), printFont, printBrush, 250, 90);
            tacog.DrawString("Drinks         " + (drinks * DRINK_PRICE).ToString("C"), printFont, printBrush, 250, 105);
            Thread.Sleep(1000);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " + (tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            tacog.DrawString("Burritos       " + (burritos * BURRITO_PRICE).ToString("C"), printFont, printBrush, 250, 75);
            tacog.DrawString("Fries          " + (fries * FRY_PRICE).ToString("C"), printFont, printBrush, 250, 90);
            tacog.DrawString("Drinks         " + (drinks * DRINK_PRICE).ToString("C"), printFont, printBrush, 250, 105);
            tacog.DrawString("Subtotal       " + subTotal.ToString("C"), printFont, printBrush, 250, 125);
            Thread.Sleep(300);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " +(tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            tacog.DrawString("Burritos       " + (burritos * BURRITO_PRICE).ToString("C"), printFont, printBrush, 250, 75);
            tacog.DrawString("Fries          " + (fries * FRY_PRICE).ToString("C"), printFont, printBrush, 250, 90);
            tacog.DrawString("Drinks         " + (drinks * DRINK_PRICE).ToString("C"), printFont, printBrush, 250, 105);
            tacog.DrawString("Subtotal       " + subTotal.ToString("C"), printFont, printBrush, 250, 125);
            tacog.DrawString("Tax            " + taxTotal.ToString("C"), printFont, printBrush, 250, 140);
            Thread.Sleep(300);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " + (tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            tacog.DrawString("Burritos       " + (burritos * BURRITO_PRICE).ToString("C"), printFont, printBrush, 250, 75);
            tacog.DrawString("Fries          " + (fries * FRY_PRICE).ToString("C"), printFont, printBrush, 250, 90);
            tacog.DrawString("Drinks         " + (drinks * DRINK_PRICE).ToString("C"), printFont, printBrush, 250, 105);
            tacog.DrawString("Subtotal       " + subTotal.ToString("C"), printFont, printBrush, 250, 125);
            tacog.DrawString("Tax            " + taxTotal.ToString("C"), printFont, printBrush, 250, 140);
            tacog.DrawString("Total          " + grandTotal.ToString("C"), printFont, printBrush, 250, 155);
            Thread.Sleep(1000);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " + (tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            tacog.DrawString("Burritos       " + (burritos * BURRITO_PRICE).ToString("C"), printFont, printBrush, 250, 75);
            tacog.DrawString("Fries          " + (fries * FRY_PRICE).ToString("C"), printFont, printBrush, 250, 90);
            tacog.DrawString("Drinks         " + (drinks * DRINK_PRICE).ToString("C"), printFont, printBrush, 250, 105);
            tacog.DrawString("Subtotal       " + subTotal.ToString("C"), printFont, printBrush, 250, 125);
            tacog.DrawString("Tax            " + taxTotal.ToString("C"), printFont, printBrush, 250, 140);
            tacog.DrawString("Total          " + grandTotal.ToString("C"), printFont, printBrush, 250, 155);
            tacog.DrawString("Cash Tendered  " + cash.ToString("C"), printFont, printBrush, 250, 175);
            Thread.Sleep(300);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " + (tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            tacog.DrawString("Burritos       " + (burritos * BURRITO_PRICE).ToString("C"), printFont, printBrush, 250, 75);
            tacog.DrawString("Fries          " + (fries * FRY_PRICE).ToString("C"), printFont, printBrush, 250, 90);
            tacog.DrawString("Drinks         " + (drinks * DRINK_PRICE).ToString("C"), printFont, printBrush, 250, 105);
            tacog.DrawString("Subtotal       " + subTotal.ToString("C"), printFont, printBrush, 250, 125);
            tacog.DrawString("Tax            " + taxTotal.ToString("C"), printFont, printBrush, 250, 140);
            tacog.DrawString("Total          " + grandTotal.ToString("C"), printFont, printBrush, 250, 155);
            tacog.DrawString("Cash Tendered  " + cash.ToString("C"), printFont, printBrush, 250, 175);
            tacog.DrawString("Change Due     " + change.ToString("C"), printFont, printBrush, 250, 190);
            Thread.Sleep(1000);
            tacog.Clear(Color.White);

            print.Play();
            tacog.DrawRectangle(printPen, 230, 30, 210, 350);
            tacog.DrawString("Tim's Taco Tavern", titleFont, printBrush, 240, 30);
            tacog.DrawString("Tacos          " + (tacos * TACO_PRICE).ToString("C"), printFont, printBrush, 250, 60);
            tacog.DrawString("Burritos       " + (burritos * BURRITO_PRICE).ToString("C"), printFont, printBrush, 250, 75);
            tacog.DrawString("Fries          " + (fries * FRY_PRICE).ToString("C"), printFont, printBrush, 250, 90);
            tacog.DrawString("Drinks         " + (drinks * DRINK_PRICE).ToString("C"), printFont, printBrush, 250, 105);
            tacog.DrawString("Subtotal       " + subTotal.ToString("C"), printFont, printBrush, 250, 125);
            tacog.DrawString("Tax            " + taxTotal.ToString("C"), printFont, printBrush, 250, 140);
            tacog.DrawString("Total          " + grandTotal.ToString("C"), printFont, printBrush, 250, 155);
            tacog.DrawString("Cash Tendered  " + cash.ToString("C"), printFont, printBrush, 250, 175);
            tacog.DrawString("Change Due     " + change.ToString("C"), printFont, printBrush, 250, 190);
            tacog.DrawString("Have a Great Day!",titleFont,printBrush,250,330);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //soundplayer setup... what is an easier way?
            SoundPlayer chaching = new SoundPlayer(Properties.Resources.Cha_Ching_Register_Muska666_173262285);
           
            //screen clearing
            Graphics tacog = this.CreateGraphics();
            tacog.Clear(Color.White);
            chaching.Play();

            //set all inputs to 0
            tacoInput.Text = "0";
            burritoInput.Text = "0"; 
            fryInput.Text = "0";
            drinkInput.Text = "0";
            changeInput.Text = "0";
        }
    }
}
