using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrainSystemApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        //Buttons "Next" + Button "Buy a Ticket"
        private void btnBuy_Click(object sender, EventArgs e)
        {
            Home.Visible = false;
            Travel.Visible = true;
            TypeTicket.Visible = false;
            Users.Visible = false;
            Pay.Visible = false;
            Receipt.Visible = false;
        }

        private void btnNextTravel_Click_1(object sender, EventArgs e)
        {
            Home.Visible = false;
            Travel.Visible = false;
            TypeTicket.Visible = true;
            Users.Visible = false;
            Pay.Visible = false;
            Receipt.Visible = false;
        }

        private void NextTypeTicket_Click(object sender, EventArgs e)
        {
            Home.Visible = false;
            Travel.Visible = false;
            TypeTicket.Visible = false;
            Users.Visible = true;
            Pay.Visible = false;
            Receipt.Visible = false;
        }

        private void NextUsers_Click(object sender, EventArgs e)
        {
            Home.Visible = false;
            Travel.Visible = false;
            TypeTicket.Visible = false;
            Users.Visible = false;
            Pay.Visible = true;
            Receipt.Visible = false;
        }

        private void NextPay_Click(object sender, EventArgs e)
        {
            Home.Visible = false;
            Travel.Visible = false;
            TypeTicket.Visible = false;
            Users.Visible = false;
            Pay.Visible = false;
            Receipt.Visible = true;
        }
        //========================

        
        //Minimize Aplication
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //========================

        
        //Close Application
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //========================

        
        //Move Application with Dragging
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void Bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX,mouseY);
            }
        }
        //========================
    }
}
