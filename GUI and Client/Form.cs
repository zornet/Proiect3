using ClassLibrary4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;
using ModelAndApi;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        MediaClient MediaClient = new ModelAndApi();
        string imglocation = "";
        string fullname = "";
        string person = "";
        string eveniment = "";
        string location = "";
        string date = "";
        List<string> paths = new List<string>();
        List<string> persons = new List<string>();
        List<string> locatie = new List<string>();
        List<string> evenimente = new List<string>();
        string persons2 = "";
        string locatie2 = "";
        string evenimente2 = "";
        int index = 0;
        int maxim = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.imglocation = dialog.FileName;
                    image1.ImageLocation = imglocation;
                    textBox1.Text = this.imglocation;
                    string[] name = this.imglocation.Split('\\');
                    foreach (var element in name)
                    {
                        this.fullname = element;
                    }
                    textBox2.Text = this.fullname;
                    Random gen = new Random();
                    int range = 5 * 365; //5 years          
                    DateTime randomDate = DateTime.Today.AddDays(-gen.Next(range));
                    textBox3.Text = randomDate.ToString();
                    this.date = textBox3.Text;
                }
            }
            catch (Exception) { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var response = MediaClient.UploadPhoto(imglocation, fullname, date, location, eveniment, person);
            if (response == true)
            { MessageBox.Show("Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            { MessageBox.Show("Already exists", "Already exists", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.person = textBox4.Text;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.eveniment = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.location = textBox6.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paths.Clear();
            var response = MediaClient.LoadDb(paths, locatie, evenimente, persons, persons2, locatie2, evenimente2);
            image1.ImageLocation = paths[index];
            textBox7.Text = locatie[index];
            textBox8.Text = evenimente[index];
            textBox9.Text = persons[index];
            maxim = paths.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var response = MediaClient.RemovePhoto(imglocation);
            if (response == true)
            { MessageBox.Show("Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (index < maxim - 1)
            { index += 1; }
            else
                index = 0;
            image1.ImageLocation = paths[index];
            textBox7.Text = locatie[index];
            textBox8.Text = evenimente[index];
            textBox9.Text = persons[index];

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (index > 0)
            { index -= 1; }
            else
                index = maxim - 1;
            image1.ImageLocation = paths[index];
            textBox7.Text = locatie[index];
            textBox8.Text = evenimente[index];
            textBox9.Text = persons[index];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
