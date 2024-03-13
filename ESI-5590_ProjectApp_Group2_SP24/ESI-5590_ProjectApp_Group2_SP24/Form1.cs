using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ESI_5590_ProjectApp_Group2_SP24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartButton.BackColor = Color.Green;
            AvoidLeft.BackColor = Color.PaleTurquoise;
            AvoidRight.BackColor = Color.PaleVioletRed;
            Stop.BackColor = Color.Red;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"300\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/embed/XW7bfFmC2BM";
            this.webBrowser4.DocumentText = string.Format(embed, url);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            String interacttime = "";
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("hh:mm:ss:fff");
            textBox1.Text = timeString;
            interacttime = textBox1.Text;
            string folder = @"C:\Users\SMF23A\source\repos\ESI-5590_ProjectApp_Group2_SP24\";
            string fileName = "Collected_Data.txt";
            string fullPath = folder + fileName;
            File.AppendAllText(fullPath, interacttime + Environment.NewLine);        }

        private void AvoidLeft_Click(object sender, EventArgs e)
        {
            String interacttime = "";
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("hh:mm:ss:fff");
            textBox1.Text = timeString;
            interacttime = textBox1.Text;
            string folder = @"C:\Users\SMF23A\source\repos\ESI-5590_ProjectApp_Group2_SP24\";
            string fileName = "Collected_Data.txt";
            string fullPath = folder + fileName;
            File.AppendAllText(fullPath, interacttime + Environment.NewLine);
        }

        private void AvoidRight_Click(object sender, EventArgs e)
        {
            String interacttime = "";
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("hh:mm:ss:fff");
            textBox1.Text = timeString;
            interacttime = textBox1.Text;
            string folder = @"C:\Users\SMF23A\source\repos\ESI-5590_ProjectApp_Group2_SP24\";
            string fileName = "Collected_Data.txt";
            string fullPath = folder + fileName;
            File.AppendAllText(fullPath, interacttime + Environment.NewLine);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            String interacttime = "";
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("hh:mm:ss:fff");
            textBox1.Text = timeString;
            interacttime = textBox1.Text;
            string folder = @"C:\Users\SMF23A\source\repos\ESI-5590_ProjectApp_Group2_SP24\";
            string fileName = "Collected_Data.txt";
            string fullPath = folder + fileName;
            File.AppendAllText(fullPath, interacttime + Environment.NewLine);
        }
    }
}
