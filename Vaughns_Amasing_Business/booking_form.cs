﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vaughns_Amasing_Business
{
    public partial class booking_form : Form
    {
        public booking_form()
        {
            InitializeComponent();
        }

        private void booking_form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values entered by the user
            Random random = new Random();
            int id = random.Next(0, 9000);
            string firstName = Fname.Text;
            string lastName = Lname.Text;
            string phone = Phone.Text;
            string data = Data.Text;
            string email = Email.Text;

            // Specify the file path
            string filePath = "../../utils/data.txt";

            // Write the line to the file
            string line = string.Format($"{id}, {firstName}, {lastName}, {phone}, {data}, {email}");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);
            }

            // Close the form after adding a new entry
            ClearTextBoxes();
            this.Close();
        }



        private void ClearTextBoxes()
        {
            Fname.Text = "";
            Lname.Text = "";
            Phone.Text = "";
            Data.Text = "";
            Email.Text = "";
        }
    }
}
