using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using KeyAuth;
using Siticone.UI.WinForms;

namespace unlockervip
{
	// Token: 0x02000067 RID: 103
	public partial class info : Form
	{
		// Token: 0x06000314 RID: 788 RVA: 0x0000DF2A File Offset: 0x0000C12A
		public info()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000DF38 File Offset: 0x0000C138
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			new Login().Show();
			base.Close();
		}
	}
}
