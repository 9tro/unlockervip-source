using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0
{
	// Token: 0x02000003 RID: 3
	internal class Class0
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002071 File Offset: 0x00000271
		internal Class25 Driver { get; private set; }

		// Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000027A
		private void method_0(Class25 class25_1)
		{
			if (class25_1 == null)
			{
				throw new ArgumentNullException("Driver", "Driver is null");
			}
			this.Driver = class25_1;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002096 File Offset: 0x00000296
		[CompilerGenerated]
		public ulong method_1()
		{
			return this.ulong_0;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000209E File Offset: 0x0000029E
		[CompilerGenerated]
		private void method_2(ulong ulong_3)
		{
			this.ulong_0 = ulong_3;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020A7 File Offset: 0x000002A7
		[CompilerGenerated]
		public ulong method_3()
		{
			return this.ulong_1;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020AF File Offset: 0x000002AF
		[CompilerGenerated]
		private void method_4(ulong ulong_3)
		{
			this.ulong_1 = ulong_3;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020B8 File Offset: 0x000002B8
		[CompilerGenerated]
		public ulong method_5()
		{
			return this.ulong_2;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020C0 File Offset: 0x000002C0
		[CompilerGenerated]
		private void method_6(ulong ulong_3)
		{
			this.ulong_2 = ulong_3;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020C9 File Offset: 0x000002C9
		[CompilerGenerated]
		public string method_7()
		{
			return this.string_1;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020D1 File Offset: 0x000002D1
		[CompilerGenerated]
		private void method_8(string string_2)
		{
			this.string_1 = string_2;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020DC File Offset: 0x000002DC
		private bool method_9(string string_2)
		{
			if (string_2 == "")
			{
				throw new ArgumentNullException("", "Game is null");
			}
			Process[] processesByName = Process.GetProcessesByName(string_2);
			if (processesByName.Length != 0)
			{
				this.method_6((ulong)((long)processesByName[0].Id));
				this.method_8(string_2);
				return true;
			}
			return false;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000212C File Offset: 0x0000032C
		public bool method_10(string string_2)
		{
			FileInfo fileInfo_ = new FileInfo("C:\\Windows\\System32\\drivers\\wmiacpi.sys");
			Class26 @class = new Class26();
			@class.method_1(Class0.string_0);
			@class.method_5("\\\\.\\\\" + Class0.string_0);
			@class.method_3(fileInfo_);
			@class.LoadMethod = (Enum27)0;
			Class25 class2 = new Class25(@class, null);
			if (class2.imethod_9())
			{
				Class25.smethod_0(class2.Config.method_4(), class2.Config.IoMethod);
				try
				{
					if (!class2.imethod_0().imethod_6())
					{
						return false;
					}
					this.method_0(class2);
					if (this.method_9(string_2))
					{
						this.method_2(this.method_50());
						this.method_4(this.method_51());
						return true;
					}
					return false;
				}
				catch (Exception)
				{
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021FC File Offset: 0x000003FC
		public bool method_11(ulong ulong_3)
		{
			return ulong_3 != 0UL && ulong_3 > 1048576UL && ulong_3 < 36028797018963967UL;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002218 File Offset: 0x00000418
		public byte[] method_12(ulong ulong_3, int int_0, bool bool_0 = false)
		{
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			if (!this.method_11(ulong_3))
			{
				return new byte[int_0];
			}
			Struct15 gparam_ = default(Struct15);
			uint int_ = (uint)Marshal.SizeOf<Struct15>();
			GCHandle gchandle = GCHandle.Alloc(new byte[int_0], GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			if (!gchandle.IsAllocated)
			{
				throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Read(ulong Address, Int32 Size).");
			}
			gparam_.ulong_0 = this.method_5();
			gparam_.int_0 = int_0;
			gparam_.ulong_2 = (ulong)intPtr.ToInt64();
			gparam_.ulong_1 = ulong_3;
			uint num = Class0.uint_0;
			if (bool_0)
			{
				num = Class0.uint_1;
			}
			if (!this.Driver.imethod_0().imethod_12<Struct15>(num, gparam_, (int)int_))
			{
				gchandle.Free();
				return new byte[int_0];
			}
			byte[] result = (byte[])gchandle.Target;
			gchandle.Free();
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022FC File Offset: 0x000004FC
		public byte[] method_13(ulong ulong_3, int int_0 = 4, bool bool_0 = false)
		{
			return this.method_12(ulong_3, int_0, bool_0);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002307 File Offset: 0x00000507
		public byte method_14(ulong ulong_3, bool bool_0 = false)
		{
			return this.method_12(ulong_3, 1, bool_0)[0];
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002314 File Offset: 0x00000514
		public bool method_15(ulong ulong_3, bool bool_0 = false)
		{
			return this.method_12(ulong_3, 1, bool_0)[0] > 0;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002324 File Offset: 0x00000524
		public short method_16(ulong ulong_3, bool bool_0 = false)
		{
			return BitConverter.ToInt16(this.method_13(ulong_3, 2, bool_0), 0);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002335 File Offset: 0x00000535
		public int method_17(ulong ulong_3, bool bool_0 = false)
		{
			return BitConverter.ToInt32(this.method_13(ulong_3, 4, bool_0), 0);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002346 File Offset: 0x00000546
		public ulong method_18(ulong ulong_3, bool bool_0 = false)
		{
			return (ulong)BitConverter.ToInt64(this.method_13(ulong_3, 8, bool_0), 0);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002357 File Offset: 0x00000557
		public float method_19(ulong ulong_3, bool bool_0 = false)
		{
			return BitConverter.ToSingle(this.method_13(ulong_3, 4, bool_0), 0);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002368 File Offset: 0x00000568
		public Class0.Class1.Class2.Struct4 method_20(ulong ulong_3, bool bool_0 = false)
		{
			byte[] array = this.method_13(ulong_3, 8, bool_0);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new Class0.Class1.Class2.Struct4(array2[0], array2[1]);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000023A4 File Offset: 0x000005A4
		public Class0.Class1.Class3.Struct5 method_21(ulong ulong_3, bool bool_0 = false)
		{
			byte[] array = this.method_13(ulong_3, 12, bool_0);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new Class0.Class1.Class3.Struct5(array2[0], array2[1], array2[2]);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000023E4 File Offset: 0x000005E4
		public Class0.Class1.Class4.Struct6 method_22(ulong ulong_3, bool bool_0 = false)
		{
			byte[] array = this.method_13(ulong_3, 16, bool_0);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new Class0.Class1.Class4.Struct6(array2[0], array2[1], array2[2], array2[3]);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002424 File Offset: 0x00000624
		public double method_23(ulong ulong_3, bool bool_0 = false)
		{
			return BitConverter.ToDouble(this.method_13(ulong_3, 8, bool_0), 0);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002438 File Offset: 0x00000638
		public ulong method_24(params ulong[] args)
		{
			ulong num = 0UL;
			for (int i = 0; i <= args.Length - 1; i++)
			{
				if (i != args.Length - 1)
				{
					num = this.method_18(num + args[i], false);
				}
				else
				{
					num += args[i];
				}
			}
			return num;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002478 File Offset: 0x00000678
		public string method_25(ulong ulong_3, int int_0, bool bool_0 = false)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] array = this.method_13(ulong_3, int_0, bool_0);
			for (int i = 0; i < int_0; i++)
			{
				if (array[i] == 0)
				{
					byte[] array2 = new byte[i];
					Array.Copy(array, array2, array2.Length);
					return asciiencoding.GetString(array2);
				}
			}
			return asciiencoding.GetString(array);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000024C8 File Offset: 0x000006C8
		public string method_26(ulong ulong_3, int int_0, bool bool_0 = false)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] array = this.method_13(ulong_3, int_0, bool_0);
			for (int i = 0; i < int_0; i++)
			{
				if (array[i] == 0 || array[i] == 10)
				{
					byte[] array2 = new byte[i];
					Array.Copy(array, array2, array2.Length);
					return asciiencoding.GetString(array2);
				}
			}
			return asciiencoding.GetString(array);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002520 File Offset: 0x00000720
		public string method_27(ulong ulong_3, int int_0, bool bool_0 = false)
		{
			Encoding encoding = new UnicodeEncoding();
			byte[] bytes = this.method_13(ulong_3, int_0 * 2, bool_0);
			return encoding.GetString(bytes);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002544 File Offset: 0x00000744
		public Class0.Class1.Class5.Struct7 method_28(ulong ulong_3, bool bool_0 = false)
		{
			byte[] array = this.method_13(ulong_3, 64, bool_0);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new Class0.Class1.Class5.Struct7(array2[0], array2[1], array2[2], array2[3], array2[4], array2[5], array2[6], array2[7], array2[8], array2[9], array2[10], array2[11], array2[12], array2[13], array2[14], array2[15]);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000025B0 File Offset: 0x000007B0
		private void method_29(ulong ulong_3, byte[] byte_0, bool bool_0 = false)
		{
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			if (!this.method_11(ulong_3))
			{
				return;
			}
			int int_ = byte_0.Length;
			Struct16 gparam_ = default(Struct16);
			uint int_2 = (uint)Marshal.SizeOf<Struct16>();
			GCHandle gchandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
			if (!gchandle.IsAllocated)
			{
				throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Write(ulong Address, byte[] Value, bool ProtectionBypass = false).");
			}
			gparam_.ulong_0 = this.method_5();
			gparam_.int_0 = int_;
			gparam_.ulong_2 = (ulong)gchandle.AddrOfPinnedObject().ToInt64();
			gparam_.ulong_1 = ulong_3;
			uint num = Class0.uint_2;
			if (bool_0)
			{
				num = Class0.uint_3;
			}
			this.Driver.imethod_0().imethod_12<Struct16>(num, gparam_, (int)int_2);
			gchandle.Free();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002673 File Offset: 0x00000873
		public void method_30(ulong ulong_3, byte[] byte_0, bool bool_0 = false)
		{
			this.method_29(ulong_3, byte_0, bool_0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002680 File Offset: 0x00000880
		public void method_31(ulong ulong_3, byte byte_0, bool bool_0 = false)
		{
			byte[] bytes = BitConverter.GetBytes((short)byte_0);
			this.method_30(ulong_3, bytes, bool_0);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000026A0 File Offset: 0x000008A0
		public void method_32(ulong ulong_3, bool bool_0, bool bool_1 = false)
		{
			byte[] bytes = BitConverter.GetBytes(bool_0);
			this.method_30(ulong_3, bytes, bool_1);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000026C0 File Offset: 0x000008C0
		public void method_33(ulong ulong_3, short short_0, bool bool_0 = false)
		{
			byte[] bytes = BitConverter.GetBytes(short_0);
			this.method_30(ulong_3, bytes, bool_0);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000026E0 File Offset: 0x000008E0
		public void method_34(ulong ulong_3, int int_0, bool bool_0 = false)
		{
			byte[] bytes = BitConverter.GetBytes(int_0);
			this.method_30(ulong_3, bytes, bool_0);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002700 File Offset: 0x00000900
		public void method_35(ulong ulong_3, long long_0, bool bool_0 = false)
		{
			byte[] bytes = BitConverter.GetBytes(long_0);
			this.method_30(ulong_3, bytes, bool_0);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002720 File Offset: 0x00000920
		public void method_36(ulong ulong_3, float float_0, bool bool_0 = false)
		{
			byte[] bytes = BitConverter.GetBytes(float_0);
			this.method_30(ulong_3, bytes, bool_0);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002740 File Offset: 0x00000940
		public void method_37(ulong ulong_3, Class0.Class1.Class2.Struct4 struct4_0, bool bool_0 = false)
		{
			byte[] array = new byte[Class0.Class1.Class2.Struct4.int_0];
			Buffer.BlockCopy(BitConverter.GetBytes(struct4_0.float_0), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(struct4_0.float_1), 0, array, 4, 4);
			this.method_30(ulong_3, array, bool_0);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000278C File Offset: 0x0000098C
		public void method_38(ulong ulong_3, Class0.Class1.Class3.Struct5 struct5_0, bool bool_0 = false)
		{
			byte[] array = new byte[Class0.Class1.Class3.Struct5.int_0];
			Buffer.BlockCopy(BitConverter.GetBytes(struct5_0.float_0), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(struct5_0.float_1), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(struct5_0.float_2), 0, array, 8, 4);
			this.method_30(ulong_3, array, bool_0);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000027EC File Offset: 0x000009EC
		public void method_39(ulong ulong_3, Class0.Class1.Class4.Struct6 struct6_0, bool bool_0 = false)
		{
			byte[] array = new byte[Class0.Class1.Class2.Struct4.int_0];
			Buffer.BlockCopy(BitConverter.GetBytes(struct6_0.float_0), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(struct6_0.float_1), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(struct6_0.float_2), 0, array, 8, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(struct6_0.float_3), 0, array, 12, 4);
			this.method_30(ulong_3, array, bool_0);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002860 File Offset: 0x00000A60
		public void method_40(ulong ulong_3, double double_0, bool bool_0 = false)
		{
			byte[] bytes = BitConverter.GetBytes(double_0);
			this.method_30(ulong_3, bytes, bool_0);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002880 File Offset: 0x00000A80
		public void method_41(ulong ulong_3, string string_2, bool bool_0 = false)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			this.method_30(ulong_3, asciiencoding.GetBytes(string_2), bool_0);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000028A4 File Offset: 0x00000AA4
		public void method_42(ulong ulong_3, string string_2, bool bool_0 = false)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			this.method_31(ulong_3 + (ulong)((long)asciiencoding.GetBytes(string_2).Length), 0, bool_0);
			this.method_30(ulong_3, asciiencoding.GetBytes(string_2), bool_0);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000028DC File Offset: 0x00000ADC
		public void method_43(ulong ulong_3, string string_2, bool bool_0 = false)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			this.method_30(ulong_3, unicodeEncoding.GetBytes(string_2), bool_0);
			this.method_31(ulong_3 + (ulong)((long)(string_2.Length * 2)), 0, bool_0);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002914 File Offset: 0x00000B14
		public void method_44(ulong ulong_3, bool bool_0, bool bool_1 = false)
		{
			byte[] byte_;
			if (bool_0)
			{
				byte_ = new byte[]
				{
					85,
					72,
					139,
					236,
					184,
					1,
					0,
					0,
					0,
					93,
					195
				};
			}
			else
			{
				byte_ = new byte[]
				{
					85,
					72,
					139,
					236,
					184,
					0,
					0,
					0,
					0,
					93,
					195
				};
			}
			this.method_29(ulong_3, byte_, bool_1);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002955 File Offset: 0x00000B55
		private ulong method_45(ulong ulong_3, ulong ulong_4, Random random_0)
		{
			return (ulong)((long)random_0.Next((int)(ulong_3 >> 32), (int)(ulong_4 >> 32)) << 32 | (long)random_0.Next((int)ulong_3, (int)ulong_4));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002978 File Offset: 0x00000B78
		public ulong method_46()
		{
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			new Random();
			ulong num = this.method_45(1099511627776UL, 16492674416640UL, new Random());
			Class0.Struct0 @struct;
			for (ulong num2 = num; num2 < 18446744073709551615UL; num2 += @struct.ulong_2)
			{
				@struct = this.method_47(num);
				if (@struct.uint_2 == 1U && @struct.uint_1 == 65536U)
				{
					num = @struct.ulong_0;
					break;
				}
			}
			Struct16 gparam_ = default(Struct16);
			uint int_ = (uint)Marshal.SizeOf<Struct16>();
			gparam_.ulong_0 = this.method_5();
			gparam_.int_0 = 4096;
			gparam_.ulong_2 = 0UL;
			gparam_.ulong_1 = num;
			if (this.Driver.imethod_0().imethod_12<Struct16>(Class0.uint_6, gparam_, (int)int_))
			{
				return num;
			}
			return 0UL;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A58 File Offset: 0x00000C58
		public Class0.Struct0 method_47(ulong ulong_3)
		{
			Struct15 gparam_ = default(Struct15);
			uint int_ = (uint)Marshal.SizeOf<Struct15>();
			GCHandle gchandle = GCHandle.Alloc(default(Class0.Struct0), GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			if (!gchandle.IsAllocated)
			{
				throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Read(ulong Address, Int32 Size).");
			}
			gparam_.ulong_0 = this.method_5();
			gparam_.int_0 = 500;
			gparam_.ulong_2 = (ulong)intPtr.ToInt64();
			gparam_.ulong_1 = ulong_3;
			uint num = Class0.uint_7;
			if (!this.Driver.imethod_0().imethod_12<Struct15>(num, gparam_, (int)int_))
			{
				return default(Class0.Struct0);
			}
			Class0.Struct0 result = (Class0.Struct0)gchandle.Target;
			gchandle.Free();
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002B10 File Offset: 0x00000D10
		public Class0.Struct1 method_48()
		{
			Struct15 gparam_ = default(Struct15);
			uint int_ = (uint)Marshal.SizeOf<Struct15>();
			GCHandle gchandle = GCHandle.Alloc(default(Class0.Struct1), GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			if (!gchandle.IsAllocated)
			{
				throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Read(ulong Address, Int32 Size).");
			}
			gparam_.ulong_0 = this.method_5();
			gparam_.int_0 = 500;
			gparam_.ulong_2 = (ulong)intPtr.ToInt64();
			gparam_.ulong_1 = 0UL;
			uint num = Class0.uint_8;
			if (!this.Driver.imethod_0().imethod_12<Struct15>(num, gparam_, (int)int_))
			{
				return default(Class0.Struct1);
			}
			Class0.Struct1 result = (Class0.Struct1)gchandle.Target;
			gchandle.Free();
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public Class0.Struct3 method_49(string string_2)
		{
			Struct15 gparam_ = default(Struct15);
			uint int_ = (uint)Marshal.SizeOf<Struct15>();
			GCHandle gchandle = GCHandle.Alloc(new byte[555], GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			IntPtr intPtr2 = GCHandle.Alloc(string_2, GCHandleType.Pinned).AddrOfPinnedObject();
			if (!gchandle.IsAllocated)
			{
				throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Read(ulong Address, Int32 Size).");
			}
			gparam_.ulong_0 = this.method_5();
			gparam_.int_0 = string_2.Length;
			gparam_.ulong_2 = (ulong)intPtr.ToInt64();
			gparam_.ulong_1 = (ulong)intPtr2.ToInt64();
			uint num = Class0.uint_9;
			if (!this.Driver.imethod_0().imethod_12<Struct15>(num, gparam_, (int)int_))
			{
				return default(Class0.Struct3);
			}
			byte[] array = (byte[])gchandle.Target;
			gchandle.Free();
			return default(Class0.Struct3);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002CA0 File Offset: 0x00000EA0
		public ulong method_50()
		{
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			Struct15 gparam_ = default(Struct15);
			uint int_ = (uint)Marshal.SizeOf<Struct15>();
			GCHandle gchandle = GCHandle.Alloc(new byte[8], GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			gparam_.ulong_0 = this.method_5();
			gparam_.ulong_2 = (ulong)intPtr.ToInt64();
			gparam_.int_0 = 8;
			if (this.Driver.imethod_0().imethod_12<Struct15>(Class0.uint_4, gparam_, (int)int_))
			{
				return (ulong)BitConverter.ToInt64((byte[])gchandle.Target, 0);
			}
			return 0UL;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002D40 File Offset: 0x00000F40
		public ulong method_51()
		{
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			Struct15 gparam_ = default(Struct15);
			uint int_ = (uint)Marshal.SizeOf<Struct15>();
			GCHandle gchandle = GCHandle.Alloc(new byte[8], GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			gparam_.ulong_0 = this.method_5();
			gparam_.ulong_2 = (ulong)intPtr.ToInt64();
			gparam_.int_0 = 8;
			if (this.Driver.imethod_0().imethod_12<Struct15>(Class0.uint_5, gparam_, (int)int_))
			{
				return (ulong)BitConverter.ToInt64((byte[])gchandle.Target, 0);
			}
			return 0UL;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public ulong method_52(ulong ulong_3, ulong ulong_4, ulong ulong_5)
		{
			for (ulong num = ulong_3; num < ulong_4; num += 2000UL)
			{
				byte[] array = this.method_12(num, 2000, false);
				for (int i = 0; i < array.Length; i++)
				{
					ulong num2 = 0UL;
					if (array[i] == 0)
					{
						while (i <= array.Length - 1 && array[i] == 0)
						{
							num2 += 1UL;
							i++;
							if (num2 >= ulong_5)
							{
								return num + (ulong)((long)i - (long)num2);
							}
						}
					}
				}
			}
			return 0UL;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002E48 File Offset: 0x00001048
		public ulong method_53(ulong ulong_3, ulong ulong_4, byte[] byte_0, string string_2 = "", Class0.Enum8 enum8_0 = (Class0.Enum8)4919U, ulong ulong_5 = 1UL)
		{
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			if (string_2 == "")
			{
				for (int i = 0; i < byte_0.Length; i++)
				{
					string_2 += "x";
				}
			}
			if (byte_0.Length != string_2.Length)
			{
				throw new Exception("[⭐] Mask Is Incorrrect Length.");
			}
			byte[] bytes = Encoding.ASCII.GetBytes(string_2);
			ulong num = ulong_3;
			while (num < ulong_4)
			{
				Class0.Struct0 @struct = this.method_47(num);
				if (@struct.uint_2 == (uint)enum8_0)
				{
					byte[] array = Class0.class0_0.method_12(@struct.ulong_0, (int)@struct.ulong_2, false);
					ulong num2 = (ulong)((long)byte_0.Length);
					ulong num3 = 0UL;
					IL_117:
					while (num3 < @struct.ulong_2)
					{
						bool flag = true;
						ulong num4 = 0UL;
						while (num4 < num2)
						{
							if (bytes[(int)num4] != 63 && checked(byte_0[(int)((IntPtr)((long)num4))] != array[(int)((IntPtr)((long)(unchecked(num3 + num4))))]))
							{
								if (!false)
								{
									num3 += ulong_5;
									goto IL_117;
								}
								return num + num3;
							}
							else
							{
								num4 += 1UL;
							}
						}
						if (flag)
						{
							return num + num3;
						}
						num3 += ulong_5;
					}
					GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
					GC.Collect();
					num += @struct.ulong_2;
				}
				else
				{
					num += @struct.ulong_2;
				}
			}
			return 0UL;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002F9E File Offset: 0x0000119E
		internal static bool smethod_0()
		{
			return Class0.object_0 == null;
		}

		// Token: 0x04000003 RID: 3
		public static Class0 class0_0;

		// Token: 0x04000004 RID: 4
		public static uint uint_0 = 2237440U;

		// Token: 0x04000005 RID: 5
		public static uint uint_1 = 2237444U;

		// Token: 0x04000006 RID: 6
		public static uint uint_2 = 2237448U;

		// Token: 0x04000007 RID: 7
		public static uint uint_3 = 2237452U;

		// Token: 0x04000008 RID: 8
		public static uint uint_4 = 2237456U;

		// Token: 0x04000009 RID: 9
		public static uint uint_5 = 2237460U;

		// Token: 0x0400000A RID: 10
		public static uint uint_6 = 2237464U;

		// Token: 0x0400000B RID: 11
		public static uint uint_7 = 2237468U;

		// Token: 0x0400000C RID: 12
		public static uint uint_8 = 2237472U;

		// Token: 0x0400000D RID: 13
		public static uint uint_9 = 2237476U;

		// Token: 0x0400000E RID: 14
		public static string string_0 = "HyperMadeThis";

		// Token: 0x0400000F RID: 15
		[CompilerGenerated]
		private Class25 class25_0;

		// Token: 0x04000010 RID: 16
		[CompilerGenerated]
		private ulong ulong_0;

		// Token: 0x04000011 RID: 17
		[CompilerGenerated]
		private ulong ulong_1;

		// Token: 0x04000012 RID: 18
		[CompilerGenerated]
		private ulong ulong_2;

		// Token: 0x04000013 RID: 19
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000014 RID: 20
		internal static object object_0;

		// Token: 0x02000004 RID: 4
		internal enum Enum8 : uint
		{

		}

		// Token: 0x02000005 RID: 5
		internal enum Enum9 : uint
		{

		}

		// Token: 0x02000006 RID: 6
		internal enum Enum10 : uint
		{

		}

		// Token: 0x02000007 RID: 7
		internal struct Struct0
		{
			// Token: 0x04000018 RID: 24
			public ulong ulong_0;

			// Token: 0x04000019 RID: 25
			public ulong ulong_1;

			// Token: 0x0400001A RID: 26
			public uint uint_0;

			// Token: 0x0400001B RID: 27
			public ushort ushort_0;

			// Token: 0x0400001C RID: 28
			public ulong ulong_2;

			// Token: 0x0400001D RID: 29
			public uint uint_1;

			// Token: 0x0400001E RID: 30
			public uint uint_2;

			// Token: 0x0400001F RID: 31
			public uint uint_3;
		}

		// Token: 0x02000008 RID: 8
		internal struct Struct1
		{
			// Token: 0x04000020 RID: 32
			public ulong ulong_0;

			// Token: 0x04000021 RID: 33
			public ulong ulong_1;

			// Token: 0x04000022 RID: 34
			public ulong ulong_2;

			// Token: 0x04000023 RID: 35
			public ulong ulong_3;

			// Token: 0x04000024 RID: 36
			public ulong ulong_4;

			// Token: 0x04000025 RID: 37
			public ulong ulong_5;

			// Token: 0x04000026 RID: 38
			public ulong ulong_6;

			// Token: 0x04000027 RID: 39
			public IntPtr intptr_0;

			// Token: 0x04000028 RID: 40
			public IntPtr intptr_1;

			// Token: 0x04000029 RID: 41
			public IntPtr intptr_2;

			// Token: 0x0400002A RID: 42
			public int int_0;
		}

		// Token: 0x02000009 RID: 9
		internal struct Struct2
		{
			// Token: 0x0400002B RID: 43
			public IntPtr intptr_0;

			// Token: 0x0400002C RID: 44
			public IntPtr intptr_1;
		}

		// Token: 0x0200000A RID: 10
		internal struct Struct3
		{
			// Token: 0x0400002D RID: 45
			public ulong ulong_0;

			// Token: 0x0400002E RID: 46
			public ulong ulong_1;

			// Token: 0x0400002F RID: 47
			public ulong ulong_2;
		}

		// Token: 0x0200000B RID: 11
		internal class Class1
		{
			// Token: 0x0600003F RID: 63 RVA: 0x0000302B File Offset: 0x0000122B
			internal static bool smethod_0()
			{
				return Class0.Class1.object_0 == null;
			}

			// Token: 0x04000030 RID: 48
			internal static object object_0;

			// Token: 0x0200000C RID: 12
			internal class Class2
			{
				// Token: 0x06000041 RID: 65 RVA: 0x00003035 File Offset: 0x00001235
				internal static bool smethod_0()
				{
					return Class0.Class1.Class2.object_0 == null;
				}

				// Token: 0x04000031 RID: 49
				private static object object_0;

				// Token: 0x0200000D RID: 13
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				internal struct Struct4
				{
					// Token: 0x06000043 RID: 67 RVA: 0x0000303F File Offset: 0x0000123F
					public Struct4(float float_2)
					{
						this.float_0 = float_2;
						this.float_1 = float_2;
					}

					// Token: 0x06000044 RID: 68 RVA: 0x0000304F File Offset: 0x0000124F
					public Struct4(float float_2, float float_3)
					{
						this.float_0 = float_2;
						this.float_1 = float_3;
					}

					// Token: 0x06000045 RID: 69 RVA: 0x0000305F File Offset: 0x0000125F
					public bool method_0()
					{
						return this.float_0 == 0f && this.float_1 == 0f;
					}

					// Token: 0x06000046 RID: 70 RVA: 0x0000307D File Offset: 0x0000127D
					public float method_1()
					{
						return (float)Math.Sqrt((double)(this.float_0 * this.float_0 + this.float_1 * this.float_1));
					}

					// Token: 0x06000047 RID: 71 RVA: 0x000030A1 File Offset: 0x000012A1
					public float method_2()
					{
						return this.float_0 * this.float_0 + this.float_1 * this.float_1;
					}

					// Token: 0x06000048 RID: 72 RVA: 0x000030C0 File Offset: 0x000012C0
					public void method_3()
					{
						float num = this.method_1();
						if (num != 0f)
						{
							float num2 = 1f / num;
							this.float_0 *= num2;
							this.float_1 *= num2;
						}
					}

					// Token: 0x06000049 RID: 73 RVA: 0x00003100 File Offset: 0x00001300
					public float[] method_4()
					{
						return new float[]
						{
							this.float_0,
							this.float_1
						};
					}

					// Token: 0x0600004A RID: 74 RVA: 0x0000311A File Offset: 0x0000131A
					public static Class0.Class1.Class2.Struct4 smethod_0(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 + struct4_5.float_0, struct4_4.float_1 + struct4_5.float_1);
					}

					// Token: 0x0600004B RID: 75 RVA: 0x0000313B File Offset: 0x0000133B
					public static Class0.Class1.Class2.Struct4 smethod_1(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 - struct4_5.float_0, struct4_4.float_1 - struct4_5.float_1);
					}

					// Token: 0x0600004C RID: 76 RVA: 0x0000315C File Offset: 0x0000135C
					public static Class0.Class1.Class2.Struct4 smethod_2(Class0.Class1.Class2.Struct4 struct4_4, float float_2)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 * float_2, struct4_4.float_1 * float_2);
					}

					// Token: 0x0600004D RID: 77 RVA: 0x00003173 File Offset: 0x00001373
					public static Class0.Class1.Class2.Struct4 smethod_3(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 * struct4_5.float_0, struct4_4.float_1 * struct4_5.float_1);
					}

					// Token: 0x0600004E RID: 78 RVA: 0x00003194 File Offset: 0x00001394
					public static Class0.Class1.Class2.Struct4 smethod_4(Class0.Class1.Class2.Struct4 struct4_4, float float_2)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 / float_2, struct4_4.float_1 / float_2);
					}

					// Token: 0x0600004F RID: 79 RVA: 0x000031AB File Offset: 0x000013AB
					public static Class0.Class1.Class2.Struct4 smethod_5(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 / struct4_5.float_0, struct4_4.float_1 / struct4_5.float_1);
					}

					// Token: 0x06000050 RID: 80 RVA: 0x000031CC File Offset: 0x000013CC
					public static Class0.Class1.Class2.Struct4 smethod_6(Class0.Class1.Class2.Struct4 struct4_4)
					{
						return new Class0.Class1.Class2.Struct4(-struct4_4.float_0, -struct4_4.float_1);
					}

					// Token: 0x06000051 RID: 81 RVA: 0x000031E1 File Offset: 0x000013E1
					public static Class0.Class1.Class2.Struct4 smethod_7(Class0.Class1.Class2.Struct4 struct4_4)
					{
						return new Class0.Class1.Class2.Struct4((struct4_4.float_0 > 0f) ? struct4_4.float_0 : (-struct4_4.float_0), (struct4_4.float_1 > 0f) ? struct4_4.float_1 : (-struct4_4.float_1));
					}

					// Token: 0x06000052 RID: 82 RVA: 0x00003220 File Offset: 0x00001420
					public static Class0.Class1.Class2.Struct4 smethod_8(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5, Class0.Class1.Class2.Struct4 struct4_6)
					{
						float num = struct4_4.float_0;
						num = ((num > struct4_6.float_0) ? struct4_6.float_0 : num);
						num = ((num < struct4_5.float_0) ? struct4_5.float_0 : num);
						float num2 = struct4_4.float_1;
						num2 = ((num2 > struct4_6.float_1) ? struct4_6.float_1 : num2);
						num2 = ((num2 >= struct4_5.float_1) ? num2 : struct4_5.float_1);
						return new Class0.Class1.Class2.Struct4(num, num2);
					}

					// Token: 0x06000053 RID: 83 RVA: 0x00003290 File Offset: 0x00001490
					public static float smethod_9(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						float num = struct4_4.float_0 - struct4_5.float_0;
						float num2 = struct4_4.float_1 - struct4_5.float_1;
						return (float)Math.Sqrt((double)(num * num + num2 * num2));
					}

					// Token: 0x06000054 RID: 84 RVA: 0x000032C5 File Offset: 0x000014C5
					public static float smethod_10(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return struct4_4.float_0 * struct4_5.float_0 + struct4_4.float_1 * struct4_5.float_1;
					}

					// Token: 0x06000055 RID: 85 RVA: 0x0000311A File Offset: 0x0000131A
					public static Class0.Class1.Class2.Struct4 operator +(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 + struct4_5.float_0, struct4_4.float_1 + struct4_5.float_1);
					}

					// Token: 0x06000056 RID: 86 RVA: 0x00003173 File Offset: 0x00001373
					public static Class0.Class1.Class2.Struct4 operator *(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 * struct4_5.float_0, struct4_4.float_1 * struct4_5.float_1);
					}

					// Token: 0x06000057 RID: 87 RVA: 0x000032E2 File Offset: 0x000014E2
					public static Class0.Class1.Class2.Struct4 operator +(Class0.Class1.Class2.Struct4 struct4_4)
					{
						return struct4_4;
					}

					// Token: 0x06000058 RID: 88 RVA: 0x0000313B File Offset: 0x0000133B
					public static Class0.Class1.Class2.Struct4 operator -(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 - struct4_5.float_0, struct4_4.float_1 - struct4_5.float_1);
					}

					// Token: 0x06000059 RID: 89 RVA: 0x000031CC File Offset: 0x000013CC
					public static Class0.Class1.Class2.Struct4 operator -(Class0.Class1.Class2.Struct4 struct4_4)
					{
						return new Class0.Class1.Class2.Struct4(-struct4_4.float_0, -struct4_4.float_1);
					}

					// Token: 0x0600005A RID: 90 RVA: 0x000032E5 File Offset: 0x000014E5
					public static Class0.Class1.Class2.Struct4 operator *(float float_2, Class0.Class1.Class2.Struct4 struct4_4)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 * float_2, struct4_4.float_1 * float_2);
					}

					// Token: 0x0600005B RID: 91 RVA: 0x0000315C File Offset: 0x0000135C
					public static Class0.Class1.Class2.Struct4 operator *(Class0.Class1.Class2.Struct4 struct4_4, float float_2)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 * float_2, struct4_4.float_1 * float_2);
					}

					// Token: 0x0600005C RID: 92 RVA: 0x00003194 File Offset: 0x00001394
					public static Class0.Class1.Class2.Struct4 operator /(Class0.Class1.Class2.Struct4 struct4_4, float float_2)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 / float_2, struct4_4.float_1 / float_2);
					}

					// Token: 0x0600005D RID: 93 RVA: 0x000032FC File Offset: 0x000014FC
					public static Class0.Class1.Class2.Struct4 operator /(float float_2, Class0.Class1.Class2.Struct4 struct4_4)
					{
						return new Class0.Class1.Class2.Struct4(float_2 / struct4_4.float_0, float_2 / struct4_4.float_1);
					}

					// Token: 0x0600005E RID: 94 RVA: 0x000031AB File Offset: 0x000013AB
					public static Class0.Class1.Class2.Struct4 operator /(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 / struct4_5.float_0, struct4_4.float_1 / struct4_5.float_1);
					}

					// Token: 0x0600005F RID: 95 RVA: 0x00003313 File Offset: 0x00001513
					public static Class0.Class1.Class2.Struct4 operator +(Class0.Class1.Class2.Struct4 struct4_4, float float_2)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 + float_2, struct4_4.float_1 + float_2);
					}

					// Token: 0x06000060 RID: 96 RVA: 0x0000332A File Offset: 0x0000152A
					public static Class0.Class1.Class2.Struct4 operator +(float float_2, Class0.Class1.Class2.Struct4 struct4_4)
					{
						return new Class0.Class1.Class2.Struct4(float_2 + struct4_4.float_0, float_2 + struct4_4.float_1);
					}

					// Token: 0x06000061 RID: 97 RVA: 0x00003341 File Offset: 0x00001541
					public static Class0.Class1.Class2.Struct4 operator -(Class0.Class1.Class2.Struct4 struct4_4, float float_2)
					{
						return new Class0.Class1.Class2.Struct4(struct4_4.float_0 - float_2, struct4_4.float_1 - float_2);
					}

					// Token: 0x06000062 RID: 98 RVA: 0x00003358 File Offset: 0x00001558
					public static Class0.Class1.Class2.Struct4 operator -(float float_2, Class0.Class1.Class2.Struct4 struct4_4)
					{
						return new Class0.Class1.Class2.Struct4(float_2 - struct4_4.float_0, float_2 - struct4_4.float_1);
					}

					// Token: 0x06000063 RID: 99 RVA: 0x0000336F File Offset: 0x0000156F
					public static bool operator ==(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return struct4_4.float_0 == struct4_5.float_0 && struct4_4.float_1 == struct4_5.float_1;
					}

					// Token: 0x06000064 RID: 100 RVA: 0x0000338F File Offset: 0x0000158F
					public static bool operator !=(Class0.Class1.Class2.Struct4 struct4_4, Class0.Class1.Class2.Struct4 struct4_5)
					{
						return struct4_4.float_0 != struct4_5.float_0 || struct4_4.float_1 != struct4_5.float_1;
					}

					// Token: 0x06000065 RID: 101 RVA: 0x000033B2 File Offset: 0x000015B2
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1}", this.float_0, this.float_1);
					}

					// Token: 0x06000066 RID: 102 RVA: 0x000033D9 File Offset: 0x000015D9
					internal static bool smethod_11()
					{
						return Class0.Class1.Class2.Struct4.object_0 == null;
					}

					// Token: 0x04000032 RID: 50
					public float float_0;

					// Token: 0x04000033 RID: 51
					public float float_1;

					// Token: 0x04000034 RID: 52
					public static readonly int int_0 = Marshal.SizeOf<Class0.Class1.Class2.Struct4>();

					// Token: 0x04000035 RID: 53
					public static readonly Class0.Class1.Class2.Struct4 struct4_0 = new Class0.Class1.Class2.Struct4(0f);

					// Token: 0x04000036 RID: 54
					public static readonly Class0.Class1.Class2.Struct4 struct4_1 = new Class0.Class1.Class2.Struct4(1f, 0f);

					// Token: 0x04000037 RID: 55
					public static readonly Class0.Class1.Class2.Struct4 struct4_2 = new Class0.Class1.Class2.Struct4(0f, 1f);

					// Token: 0x04000038 RID: 56
					public static readonly Class0.Class1.Class2.Struct4 struct4_3 = new Class0.Class1.Class2.Struct4(1f, 1f);

					// Token: 0x04000039 RID: 57
					private static object object_0;
				}
			}

			// Token: 0x0200000E RID: 14
			internal class Class3
			{
				// Token: 0x06000068 RID: 104 RVA: 0x00003446 File Offset: 0x00001646
				internal static bool smethod_0()
				{
					return Class0.Class1.Class3.object_0 == null;
				}

				// Token: 0x0400003A RID: 58
				private static object object_0;

				// Token: 0x0200000F RID: 15
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				internal struct Struct5
				{
					// Token: 0x0600006A RID: 106 RVA: 0x00003450 File Offset: 0x00001650
					public Struct5(float float_3)
					{
						this.float_0 = float_3;
						this.float_1 = float_3;
						this.float_2 = float_3;
					}

					// Token: 0x0600006B RID: 107 RVA: 0x00003467 File Offset: 0x00001667
					public Struct5(float float_3, float float_4, float float_5)
					{
						this.float_0 = float_3;
						this.float_1 = float_4;
						this.float_2 = float_5;
					}

					// Token: 0x0600006C RID: 108 RVA: 0x0000347E File Offset: 0x0000167E
					public bool method_0()
					{
						return this.float_0 == 0f && this.float_1 == 0f && this.float_2 == 0f;
					}

					// Token: 0x0600006D RID: 109 RVA: 0x000034A9 File Offset: 0x000016A9
					public float method_1()
					{
						return (float)Math.Sqrt((double)(this.float_0 * this.float_0 + this.float_1 * this.float_1 + this.float_2 * this.float_2));
					}

					// Token: 0x0600006E RID: 110 RVA: 0x000034DB File Offset: 0x000016DB
					public float method_2()
					{
						return this.float_0 * this.float_0 + this.float_1 * this.float_1 + this.float_2 * this.float_2;
					}

					// Token: 0x0600006F RID: 111 RVA: 0x00003508 File Offset: 0x00001708
					public void method_3()
					{
						float num = this.method_1();
						if (num != 0f)
						{
							float num2 = 1f / num;
							this.float_0 *= num2;
							this.float_1 *= num2;
							this.float_2 *= num2;
						}
					}

					// Token: 0x06000070 RID: 112 RVA: 0x00003556 File Offset: 0x00001756
					public float[] method_4()
					{
						return new float[]
						{
							this.float_0,
							this.float_1,
							this.float_2
						};
					}

					// Token: 0x06000071 RID: 113 RVA: 0x00003579 File Offset: 0x00001779
					public static Class0.Class1.Class3.Struct5 smethod_0(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 + struct5_14.float_0, struct5_13.float_1 + struct5_14.float_1, struct5_13.float_2 + struct5_14.float_2);
					}

					// Token: 0x06000072 RID: 114 RVA: 0x000035A7 File Offset: 0x000017A7
					public static Class0.Class1.Class3.Struct5 smethod_1(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 - struct5_14.float_0, struct5_13.float_1 - struct5_14.float_1, struct5_13.float_2 - struct5_14.float_2);
					}

					// Token: 0x06000073 RID: 115 RVA: 0x000035D5 File Offset: 0x000017D5
					public static Class0.Class1.Class3.Struct5 smethod_2(Class0.Class1.Class3.Struct5 struct5_13, float float_3)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 * float_3, struct5_13.float_1 * float_3, struct5_13.float_2 * float_3);
					}

					// Token: 0x06000074 RID: 116 RVA: 0x000035F4 File Offset: 0x000017F4
					public static Class0.Class1.Class3.Struct5 smethod_3(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 * struct5_14.float_0, struct5_13.float_1 * struct5_14.float_1, struct5_13.float_2 * struct5_14.float_2);
					}

					// Token: 0x06000075 RID: 117 RVA: 0x00003622 File Offset: 0x00001822
					public static Class0.Class1.Class3.Struct5 smethod_4(Class0.Class1.Class3.Struct5 struct5_13, float float_3)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 / float_3, struct5_13.float_1 / float_3, struct5_13.float_2 / float_3);
					}

					// Token: 0x06000076 RID: 118 RVA: 0x00003641 File Offset: 0x00001841
					public static Class0.Class1.Class3.Struct5 smethod_5(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 / struct5_14.float_0, struct5_13.float_1 / struct5_14.float_1, struct5_13.float_2 / struct5_14.float_2);
					}

					// Token: 0x06000077 RID: 119 RVA: 0x0000366F File Offset: 0x0000186F
					public static Class0.Class1.Class3.Struct5 smethod_6(Class0.Class1.Class3.Struct5 struct5_13)
					{
						return new Class0.Class1.Class3.Struct5(-struct5_13.float_0, -struct5_13.float_1, -struct5_13.float_2);
					}

					// Token: 0x06000078 RID: 120 RVA: 0x0000368C File Offset: 0x0000188C
					public static Class0.Class1.Class3.Struct5 smethod_7(Class0.Class1.Class3.Struct5 struct5_13)
					{
						return new Class0.Class1.Class3.Struct5((struct5_13.float_0 > 0f) ? struct5_13.float_0 : (-struct5_13.float_0), (struct5_13.float_1 > 0f) ? struct5_13.float_1 : (-struct5_13.float_1), (struct5_13.float_2 > 0f) ? struct5_13.float_2 : (-struct5_13.float_2));
					}

					// Token: 0x06000079 RID: 121 RVA: 0x000036F4 File Offset: 0x000018F4
					public static Class0.Class1.Class3.Struct5 smethod_8(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14, Class0.Class1.Class3.Struct5 struct5_15)
					{
						float num = struct5_13.float_0;
						num = ((num > struct5_15.float_0) ? struct5_15.float_0 : num);
						num = ((num < struct5_14.float_0) ? struct5_14.float_0 : num);
						float num2 = struct5_13.float_1;
						num2 = ((num2 <= struct5_15.float_1) ? num2 : struct5_15.float_1);
						num2 = ((num2 < struct5_14.float_1) ? struct5_14.float_1 : num2);
						float num3 = struct5_13.float_2;
						num3 = ((num3 > struct5_15.float_2) ? struct5_15.float_2 : num3);
						num3 = ((num3 < struct5_14.float_2) ? struct5_14.float_2 : num3);
						return new Class0.Class1.Class3.Struct5(num, num2, num3);
					}

					// Token: 0x0600007A RID: 122 RVA: 0x00003790 File Offset: 0x00001990
					public static float smethod_9(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						float num = struct5_13.float_0 - struct5_14.float_0;
						float num2 = struct5_13.float_1 - struct5_14.float_1;
						float num3 = struct5_13.float_2 - struct5_14.float_2;
						return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3));
					}

					// Token: 0x0600007B RID: 123 RVA: 0x000037D7 File Offset: 0x000019D7
					public static float smethod_10(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return struct5_13.float_0 * struct5_14.float_0 + struct5_13.float_1 * struct5_14.float_1 + struct5_13.float_2 * struct5_14.float_2;
					}

					// Token: 0x0600007C RID: 124 RVA: 0x00003579 File Offset: 0x00001779
					public static Class0.Class1.Class3.Struct5 operator +(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 + struct5_14.float_0, struct5_13.float_1 + struct5_14.float_1, struct5_13.float_2 + struct5_14.float_2);
					}

					// Token: 0x0600007D RID: 125 RVA: 0x000035F4 File Offset: 0x000017F4
					public static Class0.Class1.Class3.Struct5 operator *(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 * struct5_14.float_0, struct5_13.float_1 * struct5_14.float_1, struct5_13.float_2 * struct5_14.float_2);
					}

					// Token: 0x0600007E RID: 126 RVA: 0x000032E2 File Offset: 0x000014E2
					public static Class0.Class1.Class3.Struct5 operator +(Class0.Class1.Class3.Struct5 struct5_13)
					{
						return struct5_13;
					}

					// Token: 0x0600007F RID: 127 RVA: 0x000035A7 File Offset: 0x000017A7
					public static Class0.Class1.Class3.Struct5 operator -(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 - struct5_14.float_0, struct5_13.float_1 - struct5_14.float_1, struct5_13.float_2 - struct5_14.float_2);
					}

					// Token: 0x06000080 RID: 128 RVA: 0x0000366F File Offset: 0x0000186F
					public static Class0.Class1.Class3.Struct5 operator -(Class0.Class1.Class3.Struct5 struct5_13)
					{
						return new Class0.Class1.Class3.Struct5(-struct5_13.float_0, -struct5_13.float_1, -struct5_13.float_2);
					}

					// Token: 0x06000081 RID: 129 RVA: 0x00003802 File Offset: 0x00001A02
					public static Class0.Class1.Class3.Struct5 operator *(float float_3, Class0.Class1.Class3.Struct5 struct5_13)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 * float_3, struct5_13.float_1 * float_3, struct5_13.float_2 * float_3);
					}

					// Token: 0x06000082 RID: 130 RVA: 0x000035D5 File Offset: 0x000017D5
					public static Class0.Class1.Class3.Struct5 operator *(Class0.Class1.Class3.Struct5 struct5_13, float float_3)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 * float_3, struct5_13.float_1 * float_3, struct5_13.float_2 * float_3);
					}

					// Token: 0x06000083 RID: 131 RVA: 0x00003622 File Offset: 0x00001822
					public static Class0.Class1.Class3.Struct5 operator /(Class0.Class1.Class3.Struct5 struct5_13, float float_3)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 / float_3, struct5_13.float_1 / float_3, struct5_13.float_2 / float_3);
					}

					// Token: 0x06000084 RID: 132 RVA: 0x00003821 File Offset: 0x00001A21
					public static Class0.Class1.Class3.Struct5 operator /(float float_3, Class0.Class1.Class3.Struct5 struct5_13)
					{
						return new Class0.Class1.Class3.Struct5(float_3 / struct5_13.float_0, float_3 / struct5_13.float_1, float_3 / struct5_13.float_2);
					}

					// Token: 0x06000085 RID: 133 RVA: 0x00003641 File Offset: 0x00001841
					public static Class0.Class1.Class3.Struct5 operator /(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 / struct5_14.float_0, struct5_13.float_1 / struct5_14.float_1, struct5_13.float_2 / struct5_14.float_2);
					}

					// Token: 0x06000086 RID: 134 RVA: 0x00003840 File Offset: 0x00001A40
					public static Class0.Class1.Class3.Struct5 operator +(Class0.Class1.Class3.Struct5 struct5_13, float float_3)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 + float_3, struct5_13.float_1 + float_3, struct5_13.float_2 + float_3);
					}

					// Token: 0x06000087 RID: 135 RVA: 0x0000385F File Offset: 0x00001A5F
					public static Class0.Class1.Class3.Struct5 operator +(float float_3, Class0.Class1.Class3.Struct5 struct5_13)
					{
						return new Class0.Class1.Class3.Struct5(float_3 + struct5_13.float_0, float_3 + struct5_13.float_1, float_3 + struct5_13.float_2);
					}

					// Token: 0x06000088 RID: 136 RVA: 0x0000387E File Offset: 0x00001A7E
					public static Class0.Class1.Class3.Struct5 operator -(Class0.Class1.Class3.Struct5 struct5_13, float float_3)
					{
						return new Class0.Class1.Class3.Struct5(struct5_13.float_0 - float_3, struct5_13.float_1 - float_3, struct5_13.float_2 - float_3);
					}

					// Token: 0x06000089 RID: 137 RVA: 0x0000389D File Offset: 0x00001A9D
					public static Class0.Class1.Class3.Struct5 operator -(float float_3, Class0.Class1.Class3.Struct5 struct5_13)
					{
						return new Class0.Class1.Class3.Struct5(float_3 - struct5_13.float_0, float_3 - struct5_13.float_1, float_3 - struct5_13.float_2);
					}

					// Token: 0x0600008A RID: 138 RVA: 0x000038BC File Offset: 0x00001ABC
					public static bool operator ==(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return struct5_13.float_0 == struct5_14.float_0 && struct5_13.float_1 == struct5_14.float_1 && struct5_13.float_2 == struct5_14.float_2;
					}

					// Token: 0x0600008B RID: 139 RVA: 0x000038EA File Offset: 0x00001AEA
					public static bool operator !=(Class0.Class1.Class3.Struct5 struct5_13, Class0.Class1.Class3.Struct5 struct5_14)
					{
						return struct5_13.float_0 != struct5_14.float_0 || struct5_13.float_1 != struct5_14.float_1 || struct5_13.float_2 != struct5_14.float_2;
					}

					// Token: 0x0600008C RID: 140 RVA: 0x0000391B File Offset: 0x00001B1B
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2}", this.float_0, this.float_1, this.float_2);
					}

					// Token: 0x0600008D RID: 141 RVA: 0x0000394D File Offset: 0x00001B4D
					internal static bool smethod_11()
					{
						return Class0.Class1.Class3.Struct5.object_0 == null;
					}

					// Token: 0x0400003B RID: 59
					public float float_0;

					// Token: 0x0400003C RID: 60
					public float float_1;

					// Token: 0x0400003D RID: 61
					public float float_2;

					// Token: 0x0400003E RID: 62
					public static readonly int int_0 = Marshal.SizeOf<Class0.Class1.Class3.Struct5>();

					// Token: 0x0400003F RID: 63
					public static readonly Class0.Class1.Class3.Struct5 struct5_0 = new Class0.Class1.Class3.Struct5(0f);

					// Token: 0x04000040 RID: 64
					public static readonly Class0.Class1.Class3.Struct5 struct5_1 = new Class0.Class1.Class3.Struct5(1f, 0f, 0f);

					// Token: 0x04000041 RID: 65
					public static readonly Class0.Class1.Class3.Struct5 struct5_2 = new Class0.Class1.Class3.Struct5(0f, 1f, 0f);

					// Token: 0x04000042 RID: 66
					public static readonly Class0.Class1.Class3.Struct5 struct5_3 = new Class0.Class1.Class3.Struct5(0f, 0f, 1f);

					// Token: 0x04000043 RID: 67
					public static readonly Class0.Class1.Class3.Struct5 struct5_4 = new Class0.Class1.Class3.Struct5(1f, 1f, 1f);

					// Token: 0x04000044 RID: 68
					public static readonly Class0.Class1.Class3.Struct5 struct5_5 = new Class0.Class1.Class3.Struct5(0f, 1f, 0f);

					// Token: 0x04000045 RID: 69
					public static readonly Class0.Class1.Class3.Struct5 struct5_6 = new Class0.Class1.Class3.Struct5(0f, -1f, 0f);

					// Token: 0x04000046 RID: 70
					public static readonly Class0.Class1.Class3.Struct5 struct5_7 = new Class0.Class1.Class3.Struct5(-1f, 0f, 0f);

					// Token: 0x04000047 RID: 71
					public static readonly Class0.Class1.Class3.Struct5 struct5_8 = new Class0.Class1.Class3.Struct5(1f, 0f, 0f);

					// Token: 0x04000048 RID: 72
					public static readonly Class0.Class1.Class3.Struct5 struct5_9 = new Class0.Class1.Class3.Struct5(0f, 0f, -1f);

					// Token: 0x04000049 RID: 73
					public static readonly Class0.Class1.Class3.Struct5 struct5_10 = new Class0.Class1.Class3.Struct5(0f, 0f, 1f);

					// Token: 0x0400004A RID: 74
					public static readonly Class0.Class1.Class3.Struct5 struct5_11 = new Class0.Class1.Class3.Struct5(0f, 0f, 1f);

					// Token: 0x0400004B RID: 75
					public static readonly Class0.Class1.Class3.Struct5 struct5_12 = new Class0.Class1.Class3.Struct5(0f, 0f, -1f);

					// Token: 0x0400004C RID: 76
					internal static object object_0;
				}
			}

			// Token: 0x02000010 RID: 16
			internal class Class4
			{
				// Token: 0x0600008F RID: 143 RVA: 0x00003AAA File Offset: 0x00001CAA
				internal static bool smethod_0()
				{
					return Class0.Class1.Class4.object_0 == null;
				}

				// Token: 0x0400004D RID: 77
				internal static object object_0;

				// Token: 0x02000011 RID: 17
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				internal struct Struct6
				{
					// Token: 0x06000091 RID: 145 RVA: 0x00003AB4 File Offset: 0x00001CB4
					public Struct6(float float_4)
					{
						this.float_0 = float_4;
						this.float_1 = float_4;
						this.float_2 = float_4;
						this.float_3 = float_4;
					}

					// Token: 0x06000092 RID: 146 RVA: 0x00003AD2 File Offset: 0x00001CD2
					public Struct6(float float_4, float float_5, float float_6, float float_7)
					{
						this.float_0 = float_4;
						this.float_1 = float_5;
						this.float_2 = float_6;
						this.float_3 = float_7;
					}

					// Token: 0x06000093 RID: 147 RVA: 0x00003AF1 File Offset: 0x00001CF1
					public bool method_0()
					{
						return this.float_0 == 0f && this.float_1 == 0f && this.float_2 == 0f && this.float_3 == 0f;
					}

					// Token: 0x06000094 RID: 148 RVA: 0x00003B29 File Offset: 0x00001D29
					public float method_1()
					{
						return (float)Math.Sqrt((double)(this.float_0 * this.float_0 + this.float_1 * this.float_1 + this.float_2 * this.float_2 + this.float_3 * this.float_3));
					}

					// Token: 0x06000095 RID: 149 RVA: 0x00003B69 File Offset: 0x00001D69
					public float method_2()
					{
						return this.float_0 * this.float_0 + this.float_1 * this.float_1 + this.float_2 * this.float_2 + this.float_3 * this.float_3;
					}

					// Token: 0x06000096 RID: 150 RVA: 0x00003BA4 File Offset: 0x00001DA4
					public void method_3()
					{
						float num = this.method_1();
						if (num != 0f)
						{
							float num2 = 1f / num;
							this.float_0 *= num2;
							this.float_1 *= num2;
							this.float_2 *= num2;
							this.float_3 *= num2;
						}
					}

					// Token: 0x06000097 RID: 151 RVA: 0x00003C00 File Offset: 0x00001E00
					public float[] method_4()
					{
						return new float[]
						{
							this.float_0,
							this.float_1,
							this.float_2,
							this.float_3
						};
					}

					// Token: 0x06000098 RID: 152 RVA: 0x00003C2C File Offset: 0x00001E2C
					public static Class0.Class1.Class4.Struct6 smethod_0(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 + struct6_7.float_0, struct6_6.float_1 + struct6_7.float_1, struct6_6.float_2 + struct6_7.float_2, struct6_6.float_3 + struct6_7.float_3);
					}

					// Token: 0x06000099 RID: 153 RVA: 0x00003C67 File Offset: 0x00001E67
					public static Class0.Class1.Class4.Struct6 smethod_1(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 - struct6_7.float_0, struct6_6.float_1 - struct6_7.float_1, struct6_6.float_2 - struct6_7.float_2, struct6_6.float_3 - struct6_7.float_3);
					}

					// Token: 0x0600009A RID: 154 RVA: 0x00003CA2 File Offset: 0x00001EA2
					public static Class0.Class1.Class4.Struct6 smethod_2(Class0.Class1.Class4.Struct6 struct6_6, float float_4)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 * float_4, struct6_6.float_1 * float_4, struct6_6.float_2 * float_4, struct6_6.float_3 * float_4);
					}

					// Token: 0x0600009B RID: 155 RVA: 0x00003CC9 File Offset: 0x00001EC9
					public static Class0.Class1.Class4.Struct6 smethod_3(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 * struct6_7.float_0, struct6_6.float_1 * struct6_7.float_1, struct6_6.float_2 * struct6_7.float_2, struct6_6.float_3 * struct6_7.float_3);
					}

					// Token: 0x0600009C RID: 156 RVA: 0x00003D04 File Offset: 0x00001F04
					public static Class0.Class1.Class4.Struct6 smethod_4(Class0.Class1.Class4.Struct6 struct6_6, float float_4)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 / float_4, struct6_6.float_1 / float_4, struct6_6.float_2 / float_4, struct6_6.float_3 / float_4);
					}

					// Token: 0x0600009D RID: 157 RVA: 0x00003D2B File Offset: 0x00001F2B
					public static Class0.Class1.Class4.Struct6 smethod_5(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 / struct6_7.float_0, struct6_6.float_1 / struct6_7.float_1, struct6_6.float_2 / struct6_7.float_2, struct6_6.float_3 / struct6_7.float_3);
					}

					// Token: 0x0600009E RID: 158 RVA: 0x00003D66 File Offset: 0x00001F66
					public static Class0.Class1.Class4.Struct6 smethod_6(Class0.Class1.Class4.Struct6 struct6_6)
					{
						return new Class0.Class1.Class4.Struct6(-struct6_6.float_0, -struct6_6.float_1, -struct6_6.float_2, -struct6_6.float_3);
					}

					// Token: 0x0600009F RID: 159 RVA: 0x00003D8C File Offset: 0x00001F8C
					public static Class0.Class1.Class4.Struct6 smethod_7(Class0.Class1.Class4.Struct6 struct6_6)
					{
						return new Class0.Class1.Class4.Struct6((struct6_6.float_0 > 0f) ? struct6_6.float_0 : (-struct6_6.float_0), (struct6_6.float_1 > 0f) ? struct6_6.float_1 : (-struct6_6.float_1), (struct6_6.float_2 > 0f) ? struct6_6.float_2 : (-struct6_6.float_2), (struct6_6.float_3 > 0f) ? struct6_6.float_3 : (-struct6_6.float_3));
					}

					// Token: 0x060000A0 RID: 160 RVA: 0x00003E10 File Offset: 0x00002010
					public static Class0.Class1.Class4.Struct6 smethod_8(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7, Class0.Class1.Class4.Struct6 struct6_8)
					{
						float num = struct6_6.float_0;
						num = ((num > struct6_8.float_0) ? struct6_8.float_0 : num);
						num = ((num < struct6_7.float_0) ? struct6_7.float_0 : num);
						float num2 = struct6_6.float_1;
						num2 = ((num2 <= struct6_8.float_1) ? num2 : struct6_8.float_1);
						num2 = ((num2 < struct6_7.float_1) ? struct6_7.float_1 : num2);
						float num3 = struct6_6.float_2;
						num3 = ((num3 <= struct6_8.float_2) ? num3 : struct6_8.float_2);
						num3 = ((num3 >= struct6_7.float_2) ? num3 : struct6_7.float_2);
						float num4 = struct6_6.float_3;
						num4 = ((num4 > struct6_8.float_3) ? struct6_8.float_3 : num4);
						num4 = ((num4 < struct6_7.float_3) ? struct6_7.float_3 : num4);
						return new Class0.Class1.Class4.Struct6(num, num2, num3, num4);
					}

					// Token: 0x060000A1 RID: 161 RVA: 0x00003EDC File Offset: 0x000020DC
					public static float smethod_9(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						float num = struct6_6.float_0 - struct6_7.float_0;
						float num2 = struct6_6.float_1 - struct6_7.float_1;
						float num3 = struct6_6.float_2 - struct6_7.float_2;
						float num4 = struct6_6.float_3 - struct6_7.float_3;
						return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3 + num4 * num4));
					}

					// Token: 0x060000A2 RID: 162 RVA: 0x00003F35 File Offset: 0x00002135
					public static float smethod_10(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return struct6_6.float_0 * struct6_7.float_0 + struct6_6.float_1 * struct6_7.float_1 + struct6_6.float_2 * struct6_7.float_2 + struct6_6.float_3 * struct6_7.float_3;
					}

					// Token: 0x060000A3 RID: 163 RVA: 0x00003C2C File Offset: 0x00001E2C
					public static Class0.Class1.Class4.Struct6 operator +(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 + struct6_7.float_0, struct6_6.float_1 + struct6_7.float_1, struct6_6.float_2 + struct6_7.float_2, struct6_6.float_3 + struct6_7.float_3);
					}

					// Token: 0x060000A4 RID: 164 RVA: 0x00003CC9 File Offset: 0x00001EC9
					public static Class0.Class1.Class4.Struct6 operator *(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 * struct6_7.float_0, struct6_6.float_1 * struct6_7.float_1, struct6_6.float_2 * struct6_7.float_2, struct6_6.float_3 * struct6_7.float_3);
					}

					// Token: 0x060000A5 RID: 165 RVA: 0x000032E2 File Offset: 0x000014E2
					public static Class0.Class1.Class4.Struct6 operator +(Class0.Class1.Class4.Struct6 struct6_6)
					{
						return struct6_6;
					}

					// Token: 0x060000A6 RID: 166 RVA: 0x00003C67 File Offset: 0x00001E67
					public static Class0.Class1.Class4.Struct6 operator -(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 - struct6_7.float_0, struct6_6.float_1 - struct6_7.float_1, struct6_6.float_2 - struct6_7.float_2, struct6_6.float_3 - struct6_7.float_3);
					}

					// Token: 0x060000A7 RID: 167 RVA: 0x00003D66 File Offset: 0x00001F66
					public static Class0.Class1.Class4.Struct6 operator -(Class0.Class1.Class4.Struct6 struct6_6)
					{
						return new Class0.Class1.Class4.Struct6(-struct6_6.float_0, -struct6_6.float_1, -struct6_6.float_2, -struct6_6.float_3);
					}

					// Token: 0x060000A8 RID: 168 RVA: 0x00003F6E File Offset: 0x0000216E
					public static Class0.Class1.Class4.Struct6 operator *(float float_4, Class0.Class1.Class4.Struct6 struct6_6)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 * float_4, struct6_6.float_1 * float_4, struct6_6.float_2 * float_4, struct6_6.float_3 * float_4);
					}

					// Token: 0x060000A9 RID: 169 RVA: 0x00003CA2 File Offset: 0x00001EA2
					public static Class0.Class1.Class4.Struct6 operator *(Class0.Class1.Class4.Struct6 struct6_6, float float_4)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 * float_4, struct6_6.float_1 * float_4, struct6_6.float_2 * float_4, struct6_6.float_3 * float_4);
					}

					// Token: 0x060000AA RID: 170 RVA: 0x00003D04 File Offset: 0x00001F04
					public static Class0.Class1.Class4.Struct6 operator /(Class0.Class1.Class4.Struct6 struct6_6, float float_4)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 / float_4, struct6_6.float_1 / float_4, struct6_6.float_2 / float_4, struct6_6.float_3 / float_4);
					}

					// Token: 0x060000AB RID: 171 RVA: 0x00003F95 File Offset: 0x00002195
					public static Class0.Class1.Class4.Struct6 operator /(float float_4, Class0.Class1.Class4.Struct6 struct6_6)
					{
						return new Class0.Class1.Class4.Struct6(float_4 / struct6_6.float_0, float_4 / struct6_6.float_1, float_4 / struct6_6.float_2, float_4 / struct6_6.float_3);
					}

					// Token: 0x060000AC RID: 172 RVA: 0x00003D2B File Offset: 0x00001F2B
					public static Class0.Class1.Class4.Struct6 operator /(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 / struct6_7.float_0, struct6_6.float_1 / struct6_7.float_1, struct6_6.float_2 / struct6_7.float_2, struct6_6.float_3 / struct6_7.float_3);
					}

					// Token: 0x060000AD RID: 173 RVA: 0x00003FBC File Offset: 0x000021BC
					public static Class0.Class1.Class4.Struct6 operator +(Class0.Class1.Class4.Struct6 struct6_6, float float_4)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 + float_4, struct6_6.float_1 + float_4, struct6_6.float_2 + float_4, struct6_6.float_3 + float_4);
					}

					// Token: 0x060000AE RID: 174 RVA: 0x00003FE3 File Offset: 0x000021E3
					public static Class0.Class1.Class4.Struct6 operator +(float float_4, Class0.Class1.Class4.Struct6 struct6_6)
					{
						return new Class0.Class1.Class4.Struct6(float_4 + struct6_6.float_0, float_4 + struct6_6.float_1, float_4 + struct6_6.float_2, float_4 + struct6_6.float_3);
					}

					// Token: 0x060000AF RID: 175 RVA: 0x0000400A File Offset: 0x0000220A
					public static Class0.Class1.Class4.Struct6 operator -(Class0.Class1.Class4.Struct6 struct6_6, float float_4)
					{
						return new Class0.Class1.Class4.Struct6(struct6_6.float_0 - float_4, struct6_6.float_1 - float_4, struct6_6.float_2 - float_4, struct6_6.float_3 - float_4);
					}

					// Token: 0x060000B0 RID: 176 RVA: 0x00004031 File Offset: 0x00002231
					public static Class0.Class1.Class4.Struct6 operator -(float float_4, Class0.Class1.Class4.Struct6 struct6_6)
					{
						return new Class0.Class1.Class4.Struct6(float_4 - struct6_6.float_0, float_4 - struct6_6.float_1, float_4 - struct6_6.float_2, float_4 - struct6_6.float_3);
					}

					// Token: 0x060000B1 RID: 177 RVA: 0x00004058 File Offset: 0x00002258
					public static bool operator ==(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return struct6_6.float_0 == struct6_7.float_0 && struct6_6.float_1 == struct6_7.float_1 && struct6_6.float_2 == struct6_7.float_2 && struct6_6.float_3 == struct6_7.float_3;
					}

					// Token: 0x060000B2 RID: 178 RVA: 0x00004094 File Offset: 0x00002294
					public static bool operator !=(Class0.Class1.Class4.Struct6 struct6_6, Class0.Class1.Class4.Struct6 struct6_7)
					{
						return struct6_6.float_0 != struct6_7.float_0 || struct6_6.float_1 != struct6_7.float_1 || struct6_6.float_2 != struct6_7.float_2 || struct6_6.float_3 != struct6_7.float_3;
					}

					// Token: 0x060000B3 RID: 179 RVA: 0x000040D4 File Offset: 0x000022D4
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2} W:{3}", new object[]
						{
							this.float_0,
							this.float_1,
							this.float_2,
							this.float_3
						});
					}

					// Token: 0x060000B4 RID: 180 RVA: 0x0000412E File Offset: 0x0000232E
					internal static bool smethod_11()
					{
						return Class0.Class1.Class4.Struct6.object_0 == null;
					}

					// Token: 0x0400004E RID: 78
					public float float_0;

					// Token: 0x0400004F RID: 79
					public float float_1;

					// Token: 0x04000050 RID: 80
					public float float_2;

					// Token: 0x04000051 RID: 81
					public float float_3;

					// Token: 0x04000052 RID: 82
					public static readonly int int_0 = Marshal.SizeOf<Class0.Class1.Class4.Struct6>();

					// Token: 0x04000053 RID: 83
					public static readonly Class0.Class1.Class4.Struct6 struct6_0 = default(Class0.Class1.Class4.Struct6);

					// Token: 0x04000054 RID: 84
					public static readonly Class0.Class1.Class4.Struct6 struct6_1 = new Class0.Class1.Class4.Struct6(1f, 0f, 0f, 0f);

					// Token: 0x04000055 RID: 85
					public static readonly Class0.Class1.Class4.Struct6 struct6_2 = new Class0.Class1.Class4.Struct6(0f, 1f, 0f, 0f);

					// Token: 0x04000056 RID: 86
					public static readonly Class0.Class1.Class4.Struct6 struct6_3 = new Class0.Class1.Class4.Struct6(0f, 0f, 1f, 0f);

					// Token: 0x04000057 RID: 87
					public static readonly Class0.Class1.Class4.Struct6 struct6_4 = new Class0.Class1.Class4.Struct6(0f, 0f, 0f, 1f);

					// Token: 0x04000058 RID: 88
					public static readonly Class0.Class1.Class4.Struct6 struct6_5 = new Class0.Class1.Class4.Struct6(1f, 1f, 1f, 1f);

					// Token: 0x04000059 RID: 89
					private static object object_0;
				}
			}

			// Token: 0x02000012 RID: 18
			internal class Class5
			{
				// Token: 0x060000B6 RID: 182 RVA: 0x000041F0 File Offset: 0x000023F0
				internal static bool smethod_0()
				{
					return Class0.Class1.Class5.object_0 == null;
				}

				// Token: 0x0400005A RID: 90
				private static object object_0;

				// Token: 0x02000013 RID: 19
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				internal struct Struct7
				{
					// Token: 0x060000B8 RID: 184 RVA: 0x000041FC File Offset: 0x000023FC
					public Struct7(float float_16)
					{
						this.float_0 = float_16;
						this.float_1 = float_16;
						this.float_2 = float_16;
						this.float_3 = float_16;
						this.float_4 = float_16;
						this.float_5 = float_16;
						this.float_6 = float_16;
						this.float_7 = float_16;
						this.float_8 = float_16;
						this.float_9 = float_16;
						this.float_10 = float_16;
						this.float_11 = float_16;
						this.float_12 = float_16;
						this.float_13 = float_16;
						this.float_14 = float_16;
						this.float_15 = float_16;
					}

					// Token: 0x060000B9 RID: 185 RVA: 0x0000427C File Offset: 0x0000247C
					public Struct7(float float_16, float float_17, float float_18, float float_19, float float_20, float float_21, float float_22, float float_23, float float_24, float float_25, float float_26, float float_27, float float_28, float float_29, float float_30, float float_31)
					{
						this.float_0 = float_16;
						this.float_1 = float_17;
						this.float_2 = float_18;
						this.float_3 = float_19;
						this.float_4 = float_20;
						this.float_5 = float_21;
						this.float_6 = float_22;
						this.float_7 = float_23;
						this.float_8 = float_24;
						this.float_9 = float_25;
						this.float_10 = float_26;
						this.float_11 = float_27;
						this.float_12 = float_28;
						this.float_13 = float_29;
						this.float_14 = float_30;
						this.float_15 = float_31;
					}

					// Token: 0x060000BA RID: 186 RVA: 0x00004308 File Offset: 0x00002508
					public static Class0.Class1.Class5.Struct7 smethod_0(Class0.Class1.Class5.Struct7 struct7_0)
					{
						return new Class0.Class1.Class5.Struct7
						{
							float_0 = struct7_0.float_0,
							float_1 = struct7_0.float_4,
							float_2 = struct7_0.float_8,
							float_3 = struct7_0.float_12,
							float_4 = struct7_0.float_1,
							float_5 = struct7_0.float_5,
							float_6 = struct7_0.float_9,
							float_7 = struct7_0.float_13,
							float_8 = struct7_0.float_2,
							float_9 = struct7_0.float_6,
							float_10 = struct7_0.float_10,
							float_11 = struct7_0.float_14,
							float_12 = struct7_0.float_3,
							float_13 = struct7_0.float_7,
							float_14 = struct7_0.float_11,
							float_15 = struct7_0.float_15
						};
					}

					// Token: 0x060000BB RID: 187 RVA: 0x000043F0 File Offset: 0x000025F0
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "M11:{0} M12:{1} M13:{2} M14:{3} M21:{4} M22:{5} M23:{6} M24:{7} M31:{8} M32:{9} M33:{10} M34:{11} M41:{12} M42:{13} M43:{14} M44:{15}", new object[]
						{
							this.float_0,
							this.float_1,
							this.float_2,
							this.float_3,
							this.float_4,
							this.float_5,
							this.float_6,
							this.float_7,
							this.float_8,
							this.float_9,
							this.float_10,
							this.float_11,
							this.float_12,
							this.float_13,
							this.float_14,
							this.float_15
						});
					}

					// Token: 0x060000BC RID: 188 RVA: 0x000044FA File Offset: 0x000026FA
					internal static bool smethod_1()
					{
						return Class0.Class1.Class5.Struct7.object_0 == null;
					}

					// Token: 0x0400005B RID: 91
					public float float_0;

					// Token: 0x0400005C RID: 92
					public float float_1;

					// Token: 0x0400005D RID: 93
					public float float_2;

					// Token: 0x0400005E RID: 94
					public float float_3;

					// Token: 0x0400005F RID: 95
					public float float_4;

					// Token: 0x04000060 RID: 96
					public float float_5;

					// Token: 0x04000061 RID: 97
					public float float_6;

					// Token: 0x04000062 RID: 98
					public float float_7;

					// Token: 0x04000063 RID: 99
					public float float_8;

					// Token: 0x04000064 RID: 100
					public float float_9;

					// Token: 0x04000065 RID: 101
					public float float_10;

					// Token: 0x04000066 RID: 102
					public float float_11;

					// Token: 0x04000067 RID: 103
					public float float_12;

					// Token: 0x04000068 RID: 104
					public float float_13;

					// Token: 0x04000069 RID: 105
					public float float_14;

					// Token: 0x0400006A RID: 106
					public float float_15;

					// Token: 0x0400006B RID: 107
					private static object object_0;
				}
			}
		}
	}
}
