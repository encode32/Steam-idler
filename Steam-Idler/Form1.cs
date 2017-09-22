using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steamworks;

namespace Steam_Idler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string appid = IsInt(textBox1.Text) ? textBox1.Text : "";
            if(!appid.Equals(""))
            {
                Environment.SetEnvironmentVariable("SteamAppId", appid, EnvironmentVariableTarget.Process);
                SteamAPI.Init();
                this.pictureBox1.Load("http://cdn.akamai.steamstatic.com/steam/apps/" + appid.ToString() + "/header_292x136.jpg");
            }
            else
            {
                MessageBox.Show("Error: appid not valid");
            }
        }

        private bool IsInt(string sVal)
        {
            foreach (char c in sVal)
            {
                int iN = (int)c;
                if ((iN > 57) || (iN < 48))
                    return false;
            }
            return true;
        }
    }
}
