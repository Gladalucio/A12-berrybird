using System;
using System.Windows.Forms;

namespace BerryBird
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Game frm1;

        private void Menu_Load(object sender, EventArgs e)
        {
            frm1 = Owner as Game;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var buttonname = btn.Name;
            var name = int.Parse(buttonname.Substring(3, 1));

            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("Please fill in your name first");
            }
            else
            {
                frm1.LevelSelect = name;
                frm1.PlayerName = txtPlayerName.Text;

                this.Close();
            }
        }
    }
}
