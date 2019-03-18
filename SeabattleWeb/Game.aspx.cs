using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeabattleWeb
{
    public partial class Game : System.Web.UI.Page
    {
        // Загрузка страницы
        protected void Page_Init(object sender, EventArgs e)
        {
            for(int x=0; x<10; x++)
            {
                for (int y=0; y<10; y++)
                {
                    var b = new CellButton(x,y)
                    {
                        Height = new Unit(48),
                        Width = new Unit(48)

                    };
                    //Обработчик кнопок
                    b.Click += button_Click;
                    panel.Controls.Add(b);
                }
                var space = new Literal()
                {
                    Text = "<br/>"
                };
                panel.Controls.Add(space);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = System.Drawing.Color.CadetBlue;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Seabattle.Data.Game game;
            game = Seabattle.Data.Game.Load(@"c:\game.xml");
            // cycle all ships
            foreach (var ship in game.My.Ships)
            {
                foreach (var cell in ship.Cells)
                {
                    foreach (var control in panel.Controls)
                    {
                        //проверка на тип элемента управления
                        if (!(control is CellButton)) continue;
                        CellButton b = (CellButton)control;
                        if ((b.X == cell.X) && (b.Y == cell.Y))
                        {
                            b.BackColor = System.Drawing.Color.Gold;
                        }

                    }
                }
            }
        }
    }

}