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
        private List<Person> people;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            people = new List<Person>();
            string filePath = "../../utils/data.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 6)
                        {
                            int id;
                            if (int.TryParse(parts[0], out id))
                            {
                                string firstName = parts[1];
                                string lastName = parts[2];
                                string phone = parts[3];
                                string date = parts[4];
                                string email = parts[5];
                                people.Add(new Person(id, firstName, lastName, phone, date, email));
                            }
                        }
                    }
                }
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = people;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            booking_form fm = new booking_form();
            fm.ShowDialog(); // Use ShowDialog instead of Show to wait for the form to close
            LoadData(); // Reload data after booking_form is closed
        }
    }

}

