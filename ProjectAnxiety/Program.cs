using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAnxiety
{
    static class Program
    {
		public static void AntiVM()
		{

			using (var searcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				using (var items = searcher.Get())
				{
					foreach (var item in items)
					{
						string manufacturer = item["Manufacturer"].ToString().ToLower();
						if ((manufacturer == "microsoft corporation") && (item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL"))
								|| manufacturer.Contains("vmware")
								|| item["Model"].ToString() == "VirtualBox")
						{
							Environment.Exit(0);
						}
						else
                        {
								Application.EnableVisualStyles();
								Application.SetCompatibleTextRenderingDefault(false);
								Application.Run(new Form1());
						}
					}
				}
			}
		}
		[STAThread]
        static void Main()
        {
			AntiVM();
        }
    }
}
