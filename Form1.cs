using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testScavenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Visible = false;
            this.Hide();

            //  this.Visible = this.Visible ? true : false;
            //https://www.youtube.com/watch?v=8yfOZHMxV94&t=153s
            //https://www.youtube.com/watch?v=x4r75csMkms&t=21s
        }

        private string path = @"E:\123\";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           // this.ShowInTaskbar = false;
            Visible = false; //zapusk(); // false; //true;
            this.Hide();
           // this.Visible = this.Visible ? true : false;

            //Компьютер\HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run

            //Microsoft.Win32.RegistryKey autorun = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",true);
            //autorun.SetValue("System32", Application.ExecutablePath);

            //avtoGruz();

            //Random rand = new Random();

            //System.IO.Directory.CreateDirectory(path);

            //while(1==1)
            //{
            //    System.IO.File.WriteAllText(path + rand.NextDouble().ToString(), rand.NextDouble().ToString() + rand.NextDouble().ToString());
            //}

            // FileCreation();
            chekerAns();

        }

        private void avtoGruz()
        {
            Microsoft.Win32.RegistryKey autorun = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            autorun.SetValue("System32", Application.ExecutablePath);
        }


        //асинхорррый запуск
       private  async Task chekerAns()
        {
          await  Task.Run(() => FileCreation());
           
        }

        private  void FileCreation()
        {
            int test = 0;

            Random rand = new Random();

            System.IO.Directory.CreateDirectory(path);

            while (test!=10)
            {
                System.IO.File.WriteAllText(path + rand.NextDouble().ToString(), rand.NextDouble().ToString() + rand.NextDouble().ToString());
                
                Thread.Sleep(1000);
                
                test += 1;

                if (test ==10 )
                {
                    break;
                }
            }
        }

        private bool zapusk(bool znach = false)
        {
            return znach;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // avtoGruz();
            chekerAns();
            zapusk(false);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
