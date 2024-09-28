using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace WinFormsSchool
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

          //System.Windows.Forms.Timer MyTimer ;
        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            //MyTimer = new();


            //MyTimer.Interval = (2000); // 45 mins
            //MyTimer.Tick += new EventHandler(MyTimer_Tick);
            //MyTimer.Start();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            //Close();
        }

        //private void MyTimer_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        MyTimer.Stop();
        //        LoginForm loginForm = new LoginForm();
        //        loginForm.Show();
        //        Close();
        //    }
        //    catch (Exception oEx)
        //    {
        //        MessageBox.Show(oEx.Message);
        //    }
           
        //}
    }
}
