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
    public partial class InitiationLevel : UserControl
    {
        List<BlockGen> map = new List<BlockGen>();
        SolidBrush greenBrush = new SolidBrush(Color.Green);

        public InitiationLevel()
        {
            InitializeComponent();
            
            InitializeGame();
        }

        public void InitializeGame()
        {
            int y = 0;
            int x = 0;
            for (int i = 0; i < 200; i++)
            {
                if (i == 0)
                {
                    BlockGen Grass = new BlockGen(0, 0);
                    map.Add(Grass);
                }
                else if (i%20 == 0)
                {
                    x = 0;
                    y  += 50;
                    BlockGen Grass = new BlockGen(x, y);
                    map.Add(Grass);
                }
                else
                {
                    x += 50;
                    BlockGen Grass = new BlockGen(x, y);
                    map.Add(Grass);
                }
            }
        }

        private void InitiationLevel_Paint(object sender, PaintEventArgs e)
        {
            foreach (BlockGen Grass in map)
            {
                e.Graphics.FillRectangle(greenBrush, Grass.x, Grass.y, Grass.size, Grass.size);
            }
        }
    }
}
