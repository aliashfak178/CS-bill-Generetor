using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zen.Barcode;

namespace Bill_Generater_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Creating Object of GetSet classes
        GetSetValues gsv1 = new GetSetValues();
        //int MaxSize = 5;
       // int Tops = 1;
        int GrandTotal;
        //And Use it
        private void timer1_Tick(object sender, EventArgs e)
        { 
            Random rd = new Random();
            label1.ForeColor = Color.FromArgb(rd.Next(255), rd.Next(255),
                               rd.Next(255));
            lineShape1.BorderColor = Color.FromArgb(rd.Next(255),
                rd.Next(255), rd.Next(255));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AddOrderButton_MouseHover(object sender, EventArgs e)
        {
            AddOrderButton.BackColor = Color.Yellow;
            AddOrderButton.ForeColor = Color.Black;
        }

        private void AddOrderButton_MouseLeave(object sender, EventArgs e)
        {
            AddOrderButton.BackColor = Color.FromArgb(11,29,36);
            AddOrderButton.ForeColor = Color.White;
        }

        private void PrintPrevButton_MouseHover(object sender, EventArgs e)
        {
            PrintPrevButton.BackColor = Color.Yellow;
            PrintPrevButton.ForeColor = Color.Black;
        }

        private void PrintPrevButton_MouseLeave(object sender, EventArgs e)
        {
            PrintPrevButton.BackColor = Color.FromArgb(11, 29, 36);
            PrintPrevButton.ForeColor = Color.White;
        }

        private void PrintingButton_MouseHover(object sender, EventArgs e)
        {
            PrintingButton.BackColor = Color.Yellow;
            PrintingButton.ForeColor = Color.Black;
        }

        private void PrintingButton_MouseLeave(object sender, EventArgs e)
        {
            PrintingButton.BackColor = Color.FromArgb(11, 29, 36);
            PrintingButton.ForeColor = Color.White;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Yellow;
            ExitButton.ForeColor = Color.Black;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(11, 29, 36);
            ExitButton.ForeColor = Color.White;
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (QuantityComboBox.Text != "" && PriceTextBox.Text != "")
            {
                decimal totalPrice = int.Parse(QuantityComboBox.Text) * int.Parse(PriceTextBox.Text);
                TotalTextBox.Text = totalPrice.ToString();
            }
            else
            {
                TotalTextBox.Text = "0";
            }
        }

        private void QuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void PrintPrevButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ClientSize = new System.Drawing.Size(700,700);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            string ash = "My name is ashfaque";
            PictureBox pic1 = new PictureBox();
            e.Graphics.DrawImage(pic1.Image = barcode.Draw(ash, 80), 550, 300, 250, 70);
            e.Graphics.DrawString("ALI CAFE Pvt LTD...", new Font("Century751 SeBd BT", 35, FontStyle.Bold), Brushes.Fuchsia, 150, 25);
            Pen pen = new Pen(Brushes.Black, 10);
            e.Graphics.DrawLine(pen, 110, 85, 720, 85);
            e.Graphics.DrawString("Address:- Master Colony Old Mehruun Raod Jalgaon 425001 ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 30, 100);
            e.Graphics.DrawString("Mobail Number 1: 7066367203", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 30, 140);
            e.Graphics.DrawString("Mobail Number 2: 9175831706", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 400, 140);
            e.Graphics.DrawString("Email:- aliashfak178@gmail.com", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 30, 180);
            e.Graphics.DrawString("WebSite:- www.abc.com", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 400, 180);
            e.Graphics.DrawLine(pen, 10, 230, 810, 230);
            e.Graphics.DrawString("Client Name:- " + ClientNameTextBox.Text, new Font("Arial", 17, FontStyle.Bold), Brushes.Black, 30, 260);
            e.Graphics.DrawString("Date:- " + DateTime.Now, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 30, 300);
            e.Graphics.DrawString("......................................................................................................................................", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 25, 380);
            e.Graphics.DrawString("Item Description", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 55, 410);
            e.Graphics.DrawString("Peice", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 350, 410);
            e.Graphics.DrawString("Quantity", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 500, 410);
            e.Graphics.DrawString("Total", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 680, 410);
            e.Graphics.DrawString("......................................................................................................................................", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 25, 440);
            Pen pen2 = new Pen(Brushes.Black, 3);
            e.Graphics.DrawLine(pen2, 25, 399, 25, 800);
            e.Graphics.DrawLine(pen2, 810, 399, 810, 800);
            //--------------------------

            if (gsv1.Top != 0)
            {
                e.Graphics.DrawString(gsv1.SetItemName(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 55, 480);
                e.Graphics.DrawString(gsv1.SetIprice().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, 480);
                e.Graphics.DrawString(gsv1.SetQuantity().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 520, 480);
                e.Graphics.DrawString(gsv1.SetTotal().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 695, 480);
                gsv1.After_Uing();
               // GrandTotal += int.Parse(TotalTextBox.Text);
            }
            if (gsv1.Top != 0)
            {
                e.Graphics.DrawString(gsv1.SetItemName(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 55, 530);
                e.Graphics.DrawString(gsv1.SetIprice().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, 530);
                e.Graphics.DrawString(gsv1.SetQuantity().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 520, 530);
                e.Graphics.DrawString(gsv1.SetTotal().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 695, 530);
                gsv1.After_Uing();
                //GrandTotal += int.Parse(TotalTextBox.Text);
            }
            if (gsv1.Top != 0)
            {
                e.Graphics.DrawString(gsv1.SetItemName(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 55, 580);
                e.Graphics.DrawString(gsv1.SetIprice().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, 580);
                e.Graphics.DrawString(gsv1.SetQuantity().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 520, 580);
                e.Graphics.DrawString(gsv1.SetTotal().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 695, 580);
                gsv1.After_Uing();
                //GrandTotal += int.Parse(TotalTextBox.Text);
            }
            if (gsv1.Top != 0)
            {
                e.Graphics.DrawString(gsv1.SetItemName(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 55, 630);
                e.Graphics.DrawString(gsv1.SetIprice().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, 630);
                e.Graphics.DrawString(gsv1.SetQuantity().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 520, 630);
                e.Graphics.DrawString(gsv1.SetTotal().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 695, 630);
                gsv1.After_Uing();
               // GrandTotal += int.Parse(TotalTextBox.Text);
            }
            if (gsv1.Top != 0)
            {
                e.Graphics.DrawString(gsv1.SetItemName(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 55, 680);
                e.Graphics.DrawString(gsv1.SetIprice().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, 680);
                e.Graphics.DrawString(gsv1.SetQuantity().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 520, 680);
                e.Graphics.DrawString(gsv1.SetTotal().ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 695, 680);
                gsv1.After_Uing();
                //GrandTotal += int.Parse(TotalTextBox.Text);
            }

            e.Graphics.DrawString("......................................................................................................................................", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 20, 730);
            e.Graphics.DrawString("Grand Total :-", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 35, 760);
            e.Graphics.DrawString("RS.         "+GrandTotal, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 620, 760);
            e.Graphics.DrawString("......................................................................................................................................", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 20, 780);
            gsv1.After_Uing();
            //GrandTotal += int.Parse(TotalTextBox.Text);
        }

        private void PrintingButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
           
            gsv1.GetAllItem(ItemNameComboBox.Text, int.Parse(QuantityComboBox.Text), int.Parse(PriceTextBox.Text), int.Parse(TotalTextBox.Text));
            //ClientNameTextBox.Text = "";
            GrandTotal += int.Parse(TotalTextBox.Text);
            ItemNameComboBox.SelectedIndex = 0;
            QuantityComboBox.SelectedIndex = 0;
            PriceTextBox.Text = "";
            //ClientNameTextBox.Focus();
        }
    }
}