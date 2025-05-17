using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ImageSlider
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths = new List<string>
        {
            "https://static.wikia.nocookie.net/dota2_gamepedia/images/1/17/Bounty_Hunter_Full_Trading_Card.jpg/revision/latest/scale-to-width-down/150?cb=20130515204926",
            "https://static.wikia.nocookie.net/dota2_gamepedia/images/f/ff/Phantom_Lancer_Full_Trading_Card.png/revision/latest/scale-to-width-down/150?cb=20130515210040",
            "https://static.wikia.nocookie.net/dota2_gamepedia/images/d/db/Tiny_Full_Trading_Card.jpg/revision/latest/scale-to-width-down/150?cb=20130515210941"
        };

        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            ShowImage();
        }

        private void ShowImage()
        {
            pictureBox1.ImageLocation = imagePaths[currentIndex];
            UpdateLabel();

        }

        private void UpdateLabel()
        {
            labelStatus.Text = $"еда {currentIndex + 1} из {imagePaths.Count}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Count;
            ShowImage();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Count) % imagePaths.Count;
            ShowImage();
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}