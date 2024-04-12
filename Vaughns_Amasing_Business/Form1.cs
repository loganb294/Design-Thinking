using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaughns_Amasing_Business
{
    public partial class Form1 : Form
    {
        private static List<Person> people;
        public Form1()
        {
            InitializeComponent();

    

            people = new List<Person>();
            string filePath = "../../utils/Data.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {

                    string firstName, lastName, phone, date, email, line = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        string[] parts = line.Split(',');
                        firstName = parts[1];
                        lastName = parts[2];
                        phone = parts[3];
                        date = parts[4];
                        email = parts[5];

                        if (int.TryParse(parts[0], out int userID))
                        {
                            people.Add(new Person(userID, firstName, lastName, phone, date, email));
                        }

                    }
                    sr.Close();
                }
    
            }
          //This goes under the read in file section
            dataGridView1.DataSource = People;
        }

        private void button1_Click(object sender, EventArgs e) { 

         booking_form fm = new booking_form();
        fm.Show();
         this.Visible = false;
        }
    }
}

