using Memory_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Memory_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPictures.SelectedIndex = 0;
        }

        private void cmbPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPictures.SelectedItem.ToString().ToLower())
            {
                case "boy":
                    pictureBox1.Image = Resources.Boy;
                    lblTitle.Text = "Boy";
                    break;
                case "girl":
                    pictureBox1.Image = Resources.Girl;
                    lblTitle.Text = "Girl";
                    break;
                case "book":
                    pictureBox1.Image = Resources.Book ;
                    lblTitle.Text = "Book";
                    break;
                case "pen":
                    pictureBox1.Image = Resources.Pen;
                    lblTitle.Text = "Pen";
                    break;
            }
        }
    }
}
