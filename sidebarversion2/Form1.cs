using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sidebarversion2
{
    public partial class Form1 : Form
    {
       



        public Form1()
        {
            InitializeComponent();
            mdiProp();

        }
        bool isExpand = true ;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (isExpand)
            {
                side.Width -= 10;
                if (side.Width <= 55)
                {
                    sidebarTimer.Stop();
                    isExpand = false;
                    btnDashboard.Width = side.Width;
                    menuContainer.Width = side.Width;
                    btnMenu.Width = side.Width;
                    btnAbout.Width = side.Width;
                    btnSettings.Width = side.Width;
                    btnLogout.Width = side.Width;
                }
            }
            else {
                side.Width += 10;
                if (side.Width >= 230)
                {
                    sidebarTimer.Stop();
                    isExpand = true;
                    btnDashboard.Width = side.Width;
                         btnMenu.Width = side.Width; 
                    menuContainer.Width = side.Width;
                    btnAbout.Width = side.Width;
                    btnSettings.Width = side.Width;
                    btnLogout.Width = side.Width;
                }

            }
        }
       

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);

        }
        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        Form2 frm2;
        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void Frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm2 = null;
        }

        private void btnDashboard_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isMenuExpand = false;
        
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (isMenuExpand == false)
            {

                menuContainer.Height += 10;
                if (menuContainer.Height >= 195)
                {

                    menuTimer.Stop();
                    isMenuExpand = true;

                }

            }
            else {

                menuContainer.Height -= 10;
                if (menuContainer.Height <= 63)
                {

                    menuTimer.Stop();
                    isMenuExpand = false;

                }


            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new Form2();
                frm2.FormClosed += Frm2_FormClosed;
                frm2.MdiParent = this;
                frm2.Dock = DockStyle.Fill;

                frm2.Show();



            }
            else
            {

                frm2.Activate();
            }
        }
    }
}
