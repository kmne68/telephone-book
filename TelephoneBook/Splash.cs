using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneBook
{
    public partial class splash : Form
    {
        Timer timer;

        public splash()
        {
            InitializeComponent();
            this.Show();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            
        }

        //private void splash_Shown(object sender, EventArgs e)
        //{
            

        //}
            private void splash_Shown(object sender, EventArgs e)
            {
                timer = new Timer();
                // set time interval 5 seconds
                timer.Interval = 5000;
                timer.Start();
                timer.Tick += timer_Tick;
            }

            void timer_Tick(object sender, EventArgs e)
            {
                // after 5 seconds stop the timer
                timer.Stop();
                // display main form
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                // hide the splash screen
                this.Hide();
            }
    }
}
