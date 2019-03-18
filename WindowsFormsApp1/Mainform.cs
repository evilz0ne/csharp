using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seabattle
{
    public partial class Mainform : Form
  

    {
        private Data.Game game = new Data.Game();

        private int cells;
        //button of big ships
        private Data.Cell cell;
        public Mainform()
        {
            InitializeComponent();
        }
        //Обработка событий формы
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x=0; x<10; x++)
            {
                for(int y=0; y<10; y++)
                {
                    //creation button
                    var b = new CellButton(x,y);
                    b.Name = string.Format("{0,2}{1,2}", x, y);
                    b.Size = new Size(32,32);
                    //+hight of toolbox
                    b.Location = new Point(40 * x, 40 * y + menu.Height + tool.Height);
                    b.Click += B_Click; ; 
                    //add button to form
                    Controls.Add(b);
                }
                
            }
        }

        //Нажатие
        private void B_Click(object sender, EventArgs e)
        {
            try
            {

                CellButton b = (CellButton)sender;
                if (!game.My.CheckAround(b.X,b.Y))
                {
                    return;
                }
                switch (cells)
                {
                    //1 button ship 
                    case 1:
                        b.BackColor = Color.LightSkyBlue;
                        ship1.Checked = false;
                        game.My.Addship1(b.X, b.Y);
                        //возврат в осн режим
                        cells = 0;
                        break;
                    //2 button ship
                    case 2:
                        if (cell == null)
                        {
                            //1st button
                            b.BackColor = Color.OrangeRed;
                            cell = new Data.Cell(b.X, b.Y);
                        }
                        else if (!cell.CheckNear(b.X, b.Y))
                        {
                            //wrong button pressed
                            return;
                        }
                        else
                        {
                            //colour 1st button
                            getButton(cell.X, cell.Y).BackColor = Color.Orange;
                            //colour 2st button
                            b.BackColor = Color.OrangeRed;
                            //release button
                            ship2.Checked = false;
                            // add 2button ship
                            game.My.Addship2(cell, b.X, b.Y);
                            //erease marked button
                            cell = null;
                            //возврат в осн режим
                            cells = 0;
                        }
                        break;
                }
                
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Печаль");
            }
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //exit
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //расстановка однопалубного корабля
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //залипание кнопки
            ship1.Checked = true;
            cells = 1;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //залипание кнопки
            ship2.Checked = true;
            cells = 2;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                game.Save(saveFileDialog1.FileName);
            }
        }
        //savedialog
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }
        
       private CellButton getButton(int x, int y)
        {
            foreach (Control control in Controls)
            {
                //check cast type
                if (!(control is CellButton)) continue;
                // cast type
                CellButton button = (CellButton)control;
                //check same button
                if ((button.X == x) && (button.Y == y))
                {//founded right button
                    return button;
                }
            }
            return null;
        }
            
    }
}
