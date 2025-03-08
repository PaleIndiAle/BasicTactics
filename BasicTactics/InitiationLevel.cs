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
        List<BlockGen> Bridgemap = new List<BlockGen>();
        List<BlockGen> Walkablemap = new List<BlockGen>();
        List<BlockGen> Seamap = new List<BlockGen>();
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        public InitiationLevel()
        {
            InitializeComponent();
            
            InitializeGame();
        }

        public void InitializeGame()
        {
            int g_y = 0;
            int g_x = 0;
            int w_y = 150;
            int w_x = 100;
            int b_y = 150;
            int b_x = 0;
            for (int g = 0; g < 48; g++)
            {
                if (g == 0)
                {
                    BlockGen Grass = new BlockGen(0, 0);
                    Walkablemap.Add(Grass);
                }
                else if (g % 16 == 0)
                {
                    g_x = 0;
                    g_y += 50;
                    BlockGen Grass = new BlockGen(g_x, g_y);
                    Walkablemap.Add(Grass);
                }
                else
                {
                    g_x += 50;
                    BlockGen Grass = new BlockGen(g_x, g_y);
                    Walkablemap.Add(Grass);
                }
            }

            for (int w = 0; w < 28; w++)
            {
                if (w == 0)
                {
                    BlockGen Water = new BlockGen(100, 150);
                    Seamap.Add(Water);
                }
                else if (w % 14 == 0)
                {
                    w_x = 100;
                    w_y += 50;
                    BlockGen Water = new BlockGen(w_x, w_y);
                    Seamap.Add(Water);
                }
                else
                {
                    w_x += 50;
                    BlockGen Water = new BlockGen(w_x, w_y);
                    Seamap.Add(Water);
                }
            }

            for (int b = 0; b < 4; b++)
            {
                if (b == 0)
                {
                    BlockGen Bridge = new BlockGen(0, 150);
                    Bridgemap.Add(Bridge);
                }
                else if (b%2 == 0)
                {
                    b_x = 0;
                    b_y += 50;
                    BlockGen Bridge = new BlockGen(b_x, b_y);
                    Bridgemap.Add(Bridge);
                }
                else
                {
                    b_x += 50;
                    BlockGen Bridge = new BlockGen(b_x, b_y);
                    Bridgemap.Add(Bridge);
                }
            }
        }

        private void InitiationLevel_Paint(object sender, PaintEventArgs e)
        {
            foreach (BlockGen Grass in Walkablemap)
            {
                e.Graphics.FillRectangle(greenBrush, Grass.x, Grass.y, Grass.size, Grass.size);
            }

            foreach (BlockGen Water in Seamap)
            {
                e.Graphics.FillRectangle(blueBrush, Water.x, Water.y, Water.size, Water.size);
            }

            foreach (BlockGen Bridge in Bridgemap)
            {
                e.Graphics.FillRectangle(blackBrush, Bridge.x, Bridge.y, Bridge.size, Bridge.size);
            }
        }
    }
}
