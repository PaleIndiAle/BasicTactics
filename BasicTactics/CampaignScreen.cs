using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicTactics
{
    public partial class CampaignScreen : UserControl
    {
        public CampaignScreen()
        {
            InitializeComponent();

            textBox1.Text = $"Time: {InitiationLevel.mTime}:{InitiationLevel.sTime}";
        }

        private void firstLevelButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new InitiationLevel());

            InitiationLevel.msTime = 0;
            InitiationLevel.sTime = 0;
            InitiationLevel.mTime = 0;
        }
    }
}
