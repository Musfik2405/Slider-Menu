using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectone
{
    public partial class dashboardSidebar : Form
    {
        bool sidebarExpand;
        bool homeCollased;
        public dashboardSidebar()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if(sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if(sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();

                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            homeContainer.Height += 10;
            if (homeCollased)
            {
                if(homeContainer.Height == homeContainer.MaximumSize.Height)
                {
                    homeCollased = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                homeContainer.Height =- 10;
                if(homeContainer.Height == homeContainer.MinimumSize.Height)
                {
                    homeCollased = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void dashboardSidebar_Load(object sender, EventArgs e)
        {

        }
    }
}
