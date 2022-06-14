using System;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000066 RID: 102
	internal static class Program
	{
		// Token: 0x06000313 RID: 787 RVA: 0x0000DF13 File Offset: 0x0000C113
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
