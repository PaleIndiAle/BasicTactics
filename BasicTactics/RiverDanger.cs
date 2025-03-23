using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicTactics
{
    public partial class RiverDanger : UserControl
    {
        int width = 50;
        int height = 50;

        bool leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        List<RifleInfantry> alliedInfantry = new List<RifleInfantry>();
        public RiverDanger()
        {
            InitializeComponent();
            InitializeGame();

            this.BackgroundImage = BasicTactics.Properties.Resources.RiverDangerMap;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox2.Image = BasicTactics.Properties.Resources.FriendlyIdle;
            pictureBox1.Image = BasicTactics.Properties.Resources.HostileCity;
        }

        public void InitializeGame()
        {
            RifleInfantry rifle = new RifleInfantry(1, 750, 400);
            alliedInfantry.Add(rifle);

            gameTimer.Enabled = true;
        }

        private void RiverDanger_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Enabled = false;
            Form1.ChangeScreen(this, new CampaignScreen());
        }

        private void RiverDanger_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = true;
                    break;
                case Keys.D:
                    rightArrowDown = true;
                    break;
                case Keys.W:
                    upArrowDown = true;
                    break;
                case Keys.S:
                    downArrowDown = true;
                    break;
            }
        }

        private void RiverDanger_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = false;
                    break;
                case Keys.D:
                    rightArrowDown = false;
                    break;
                case Keys.W:
                    upArrowDown = false;
                    break;
                case Keys.S:
                    downArrowDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Form1.RmsTime += 100;

            if (Form1.RmsTime == 1000)
            {
                Form1.RsTime += 1;
                Form1.RmsTime = 0;
            }

            textBox1.Text = "Destroy the enemy encampment on the top left.";

            foreach (RifleInfantry rifle in alliedInfantry)
            {
                if (leftArrowDown == true && rifle.x > 0)
                {
                    rifle.x -= 50;
                    pictureBox2.Image = BasicTactics.Properties.Resources.FriendlyMovingLeft;
                }
                else if (rightArrowDown == true && rifle.x < 750)
                {
                    rifle.x += 50;
                    pictureBox2.Image = BasicTactics.Properties.Resources.FriendlyMovingRight;
                }
                else if (upArrowDown == true && rifle.y > 0)
                {
                    rifle.y -= 50;
                }
                else if (downArrowDown == true && rifle.y < 450)
                {
                    rifle.y += 50;
                }
            }

            foreach (RifleInfantry rifle in alliedInfantry)
            {
                pictureBox2.Location = new Point(rifle.x, rifle.y);
            }

            if (pictureBox2.Location == pictureBox1.Location)
            {
                textBox1.Text = "You march into the enemy encampment and destroy it before they are able to return. Mission Successful";
                button1.Visible = true;
                button1.Enabled = true;
                gameTimer.Enabled = false;
            }

            Refresh();
        }
    }
}
