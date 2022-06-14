using System;
using Microsoft.Win32.SafeHandles;

namespace ns0
{
	// Token: 0x02000053 RID: 83
	internal interface Interface1 : IDisposable
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000261 RID: 609
		Interface0 Driver { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000262 RID: 610
		SafeFileHandle Handle { get; }

		// Token: 0x06000263 RID: 611
		EventHandler imethod_0();

		// Token: 0x06000264 RID: 612
		void imethod_1(EventHandler eventHandler_0);

		// Token: 0x06000265 RID: 613
		EventHandler imethod_2();

		// Token: 0x06000266 RID: 614
		void imethod_3(EventHandler eventHandler_0);

		// Token: 0x06000267 RID: 615
		EventHandler imethod_4();

		// Token: 0x06000268 RID: 616
		void imethod_5(EventHandler eventHandler_0);

		// Token: 0x06000269 RID: 617
		bool imethod_6();

		// Token: 0x0600026A RID: 618
		bool imethod_7();

		// Token: 0x0600026B RID: 619
		void imethod_8();

		// Token: 0x0600026C RID: 620
		void imethod_9();

		// Token: 0x0600026D RID: 621
		bool imethod_10(uint uint_0);

		// Token: 0x0600026E RID: 622
		bool imethod_11<T>(uint uint_0, T gparam_0);

		// Token: 0x0600026F RID: 623
		bool imethod_12<T>(uint uint_0, T gparam_0, int int_0);

		// Token: 0x06000270 RID: 624
		bool imethod_13<T, U>(uint uint_0, T gparam_0, out U gparam_1);

		// Token: 0x06000271 RID: 625
		bool imethod_14<T, U>(uint uint_0, T gparam_0, int int_0, out U gparam_1, int int_1);
	}
}
