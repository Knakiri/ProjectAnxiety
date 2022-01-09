using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectAnxiety.zvd;
using Emgu;
namespace ProjectAnxiety
{
    public partial class Form1 : Form
    {
        public readonly List<string> urlList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }
        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            Builder f2 = new Builder();
            f2.Show();
        }
        private void monoFlat_Button7_Click(object sender, EventArgs e)
        {
            Extract("ProjectAnxiety", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Resources", "GABB.zip");
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\GABB.zip"))
            {
                MessageBox.Show("Successfully extracted gabb to your desktop directory!");
            }
            else
            {
                MessageBox.Show("Oops! looks like something happened and couldnt extract the gabb\n please turn off your antivirus!");
            }
            
        }

        private void monoFlat_Button5_Click(object sender, EventArgs e)
        {
            Creators f2 = new Creators();
            f2.Show();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Extract("ProjectAnxiety", Path.GetTempPath(), "Resources", "Newtonsoft.Json.dll");
            monoFlat_Label2.Text = "User: " + Environment.UserName;
            
        }
    }
}
