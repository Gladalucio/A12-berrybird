using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerryBird
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Form1 frm1;

        private void Menu_Load(object sender, EventArgs e)
        {
            frm1 = Owner as Form1;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string buttonname = btn.Name;
            int name = int.Parse(buttonname.Substring(3, 1));

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
