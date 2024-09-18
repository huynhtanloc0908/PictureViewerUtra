using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Title = "File Explorer";
            o.Filter = "File anh(*.jpg , *.png , *.gif) |*.jpg;*.png;*.gif; |All File|*.*";
            if(o.ShowDialog() == DialogResult.OK )
            {
                pictureBox1.Image= Image.FromFile( o.FileName );
            }
        }
    }
}
