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
using static System.Net.WebRequestMethods;

namespace BasicTactics
{
    public partial class InitiationLevel : UserControl
    {
        //List<BlockGen> Bridgemap = new List<BlockGen>();
        //List<BlockGen> Walkablemap = new List<BlockGen>();
        //List<BlockGen> Seamap = new List<BlockGen>();
        //SolidBrush greenBrush = new SolidBrush(Color.Green);
        //SolidBrush blueBrush = new SolidBrush(Color.Blue);
        //SolidBrush blackBrush = new SolidBrush(Color.Black);

        int width = 50;
        int height = 50;

        bool leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        List<RifleInfantry> alliedInfantry = new List<RifleInfantry>();
        public InitiationLevel()
        {
            InitializeComponent();

            this.BackgroundImage = BasicTactics.Properties.Resources.InitiationMap;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            InitializeGame();
        }

        public void InitializeGame()
        {
            RifleInfantry rifle = new RifleInfantry(1, 50, 400);
            alliedInfantry.Add(rifle);

            //for (int i = 0; i < 3; i++)
            //{
            //    int x = 0;
            //    int y = 400;

            //    if (i == 0)
            //    {
            //        RifleInfantry rifle = new RifleInfantry(1, x, y);
            //        alliedInfantry.Add(rifle);
            //    }
            //    else
            //    {
            //        x += 50;

            //        RifleInfantry rifle = new RifleInfantry(1, x, y);
            //        alliedInfantry.Add(rifle);
            //    }
            //}
        }

        private void InitiationLevel_Paint(object sender, PaintEventArgs e)
        {
            pictureBox7.Image = BasicTactics.Properties.Resources.FriendlyIdle;
            pictureBox6.Image = BasicTactics.Properties.Resources.HostileCity;
            pictureBox5.Image = BasicTactics.Properties.Resources.FriendlyCity;
            pictureBox4.Image = BasicTactics.Properties.Resources.EnemyIdle;
            pictureBox3.Image = BasicTactics.Properties.Resources.EnemyIdle;
            pictureBox2.Image = BasicTactics.Properties.Resources.HostileCity;
            pictureBox1.Image = BasicTactics.Properties.Resources.FriendlyCity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Enabled = false;
            Form1.ChangeScreen(this, new CampaignScreen());
        }

        private void InitiationLevel_KeyDown(object sender, KeyEventArgs e)
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

        private void InitiationLevel_KeyUp(object sender, KeyEventArgs e)
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
            textBox1.Text = "Capture the enemy encampment on the top right.";

            foreach (RifleInfantry rifle in alliedInfantry)
            {
                if (leftArrowDown == true && pictureBox2.Location.X > 0)
                {
                    rifle.x -= 50;
                }
                else if (rightArrowDown == true && pictureBox2.Location.X < 750)
                {
                    rifle.x += 50;
                }
                else if (upArrowDown == true && pictureBox2.Location.Y > 0)
                {
                    rifle.y -= 50;
                }
                else if (downArrowDown == true && pictureBox2.Location.Y < 500)
                {
                    rifle.y += 50;
                }
            }

            foreach (RifleInfantry rifle in alliedInfantry)
            {
                pictureBox7.Location = new Point(rifle.x, rifle.y);
            }

            if (pictureBox7.Location == pictureBox3.Location)
            {
                textBox1.Text = "The enemy sees your squad approach and prepares to engage. The two exchange fire before your squad emerges victorious.";
                pictureBox3.Visible = false;
            }
            else if (pictureBox7.Location == pictureBox4.Location)
            {
                textBox1.Text = "Your squad takes position and begin to engage the enemy. It isn't long before your squad scatters the enemy forces.";
                pictureBox4.Visible = false;
            }
            else if (pictureBox7.Location == pictureBox6.Location)
            {
                textBox1.Text = "Your squad enters the enemy camp and captures it. Your mission is complete.";
                pictureBox6.Image = pictureBox1.Image = BasicTactics.Properties.Resources.FriendlyCity;
                button1.Visible = true;
                button1.Enabled = true;
            }

            Refresh();
        }
    }
}
