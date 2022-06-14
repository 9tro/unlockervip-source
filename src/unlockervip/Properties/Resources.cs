using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace unlockervip.Properties
{
	// Token: 0x02000068 RID: 104
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000318 RID: 792 RVA: 0x00002FA8 File Offset: 0x000011A8
		internal Resources()
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000E745 File Offset: 0x0000C945
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("unlockervip.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000E771 File Offset: 0x0000C971
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0000E778 File Offset: 0x0000C978
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000E780 File Offset: 0x0000C980
		internal static byte[] _111ㅤㅤ
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("_111ㅤㅤ", Resources.resourceCulture);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000E79B File Offset: 0x0000C99B
		internal static byte[] _11ㅤ
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("_11ㅤ", Resources.resourceCulture);
			}
		}

		// Token: 0x04000316 RID: 790
		private static ResourceManager resourceMan;

		// Token: 0x04000317 RID: 791
		private static CultureInfo resourceCulture;
	}
}
