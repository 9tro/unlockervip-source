using System;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000036 RID: 54
	internal static class Class6
	{
		// Token: 0x0600022C RID: 556 RVA: 0x00008F84 File Offset: 0x00007184
		internal static void smethod_0()
		{
			Class8.smethod_1();
			Class6.form1_0 = new Form1();
			Class6.form1_0.Show();
			Class6.form1_0.Visible = false;
			Control.CheckForIllegalCrossThreadCalls = false;
			new Thread(new ThreadStart(new Class31().method_3))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00008FDC File Offset: 0x000071DC
		internal static bool smethod_1()
		{
			return Class6.object_0 == null;
		}

		// Token: 0x04000115 RID: 277
		public static Form1 form1_0;

		// Token: 0x04000116 RID: 278
		private static object object_0;
	}
}
