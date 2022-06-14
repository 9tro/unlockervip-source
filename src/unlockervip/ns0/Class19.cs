using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0
{
	// Token: 0x02000021 RID: 33
	internal class Class19
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000055B8 File Offset: 0x000037B8
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000055C0 File Offset: 0x000037C0
		internal Class25 Driver { get; private set; }

		// Token: 0x0600010A RID: 266 RVA: 0x000055C9 File Offset: 0x000037C9
		[CompilerGenerated]
		public ulong method_0()
		{
			return this.ulong_0;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000055D1 File Offset: 0x000037D1
		[CompilerGenerated]
		private void method_1(ulong ulong_2)
		{
			this.ulong_0 = ulong_2;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000055DA File Offset: 0x000037DA
		[CompilerGenerated]
		public string method_2()
		{
			return this.string_0;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000055E2 File Offset: 0x000037E2
		[CompilerGenerated]
		private void method_3(string string_2)
		{
			this.string_0 = string_2;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000055EC File Offset: 0x000037EC
		public Class19(string string_2, Class19.Class20 class20_0)
		{
			this.uint_0 = class20_0.uint_0;
			this.uint_1 = class20_0.uint_1;
			this.uint_2 = class20_0.uint_2;
			this.uint_3 = class20_0.uint_3;
			this.uint_4 = class20_0.uint_4;
			this.uint_5 = class20_0.uint_5;
			this.string_1 = class20_0.string_0;
			this.method_12(string_2);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000056A7 File Offset: 0x000038A7
		private void method_4(Class25 class25_1)
		{
			if (class25_1 == null)
			{
				throw new ArgumentNullException("Driver", "Driver is null");
			}
			this.Driver = class25_1;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000056C3 File Offset: 0x000038C3
		private void method_5(ulong ulong_2)
		{
			this.method_1(ulong_2);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000056CC File Offset: 0x000038CC
		private void method_6(string string_2)
		{
			this.method_3(string_2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000056D5 File Offset: 0x000038D5
		public static bool smethod_0(ulong ulong_2)
		{
			return ulong_2 != 0UL && ulong_2 > 1048576UL && ulong_2 < 36028797018963967UL;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000056F4 File Offset: 0x000038F4
		private byte[] method_7(ulong ulong_2, int int_0)
		{
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("Driver is disconnected.");
			}
			if (!Class19.smethod_0(ulong_2))
			{
				return new byte[int_0];
			}
			Struct15 gparam_ = default(Struct15);
			uint int_ = (uint)Marshal.SizeOf<Struct15>();
			byte[] array = new byte[int_0];
			GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			if (gchandle.IsAllocated)
			{
				gparam_.ulong_0 = this.method_0();
				gparam_.int_0 = int_0;
				gparam_.ulong_2 = (ulong)intPtr.ToInt64();
				gparam_.ulong_1 = ulong_2;
				bool flag = this.Driver.imethod_0().imethod_12<Struct15>(this.uint_2, gparam_, (int)int_);
				if (flag)
				{
					array = (byte[])gchandle.Target;
				}
				gchandle.Free();
				if (!flag)
				{
					array = null;
				}
				return array;
			}
			throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Read(ProcessId, Address, Size).");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000057C8 File Offset: 0x000039C8
		private void method_8(ulong ulong_2, byte[] byte_0, bool bool_1 = false)
		{
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("Driver is disconnected.");
			}
			if (!Class19.smethod_0(ulong_2))
			{
				return;
			}
			int int_ = byte_0.Length;
			Struct16 gparam_ = default(Struct16);
			uint int_2 = (uint)Marshal.SizeOf<Struct16>();
			GCHandle gchandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
			if (!gchandle.IsAllocated)
			{
				throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Write<T>(Address, Value, UseBaseAddress).");
			}
			gparam_.ulong_0 = this.method_0();
			gparam_.int_0 = int_;
			gparam_.ulong_2 = (ulong)gchandle.AddrOfPinnedObject().ToInt64();
			gparam_.ulong_1 = ulong_2;
			bool flag;
			if (bool_1)
			{
				flag = this.Driver.imethod_0().imethod_12<Struct16>(this.uint_0, gparam_, (int)int_2);
			}
			else
			{
				flag = this.Driver.imethod_0().imethod_12<Struct16>(this.uint_1, gparam_, (int)int_2);
			}
			gchandle.Free();
			if (!flag)
			{
				throw new Exception("Failed to write the given structure to the specified Address, at Write<T>(Address, Value, UseBaseAddress).");
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000058AC File Offset: 0x00003AAC
		public ulong method_9()
		{
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("Driver is disconnected.");
			}
			if (Process.GetProcessesByName(this.method_2()).Length == 0)
			{
				throw new Exception("Game Crashed or Closed?!");
			}
			Struct15 gparam_ = default(Struct15);
			uint int_ = (uint)Marshal.SizeOf<Struct15>();
			GCHandle gchandle = GCHandle.Alloc(new byte[8], GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			gparam_.ulong_0 = this.method_0();
			gparam_.ulong_2 = (ulong)intPtr.ToInt64();
			gparam_.int_0 = 8;
			if (this.Driver.imethod_0().imethod_12<Struct15>(this.uint_3, gparam_, (int)int_))
			{
				return (ulong)BitConverter.ToInt64((byte[])gchandle.Target, 0);
			}
			return 0UL;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005964 File Offset: 0x00003B64
		public ulong method_10(Class19.Enum26 enum26_0)
		{
			if (Process.GetProcessesByName(this.method_2()).Length == 0)
			{
				throw new Exception("Game Crashed or Closed?!");
			}
			if (!this.Driver.imethod_0().imethod_6())
			{
				throw new Exception("Driver is disconnected.");
			}
			bool flag = false;
			Struct15 gparam_ = default(Struct15);
			uint int_ = (uint)Marshal.SizeOf<Struct15>();
			GCHandle gchandle = GCHandle.Alloc(new byte[8], GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			gparam_.ulong_0 = this.method_0();
			gparam_.ulong_2 = (ulong)intPtr.ToInt64();
			gparam_.int_0 = 8;
			if (enum26_0 != (Class19.Enum26)0)
			{
				if (enum26_0 == (Class19.Enum26)1)
				{
					flag = this.Driver.imethod_0().imethod_12<Struct15>(this.uint_5, gparam_, (int)int_);
				}
			}
			else
			{
				flag = this.Driver.imethod_0().imethod_12<Struct15>(this.uint_4, gparam_, (int)int_);
			}
			if (!flag)
			{
				return 0UL;
			}
			return (ulong)BitConverter.ToInt64((byte[])gchandle.Target, 0);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005A43 File Offset: 0x00003C43
		public void method_11()
		{
			this.Driver.imethod_0().Driver.imethod_10();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005A5C File Offset: 0x00003C5C
		private void method_12(string string_2)
		{
			FileInfo fileInfo_ = new FileInfo("C:\\Windows\\System32\\drivers\\wmiacpi.sys");
			Class26 @class = new Class26();
			@class.method_1(this.string_1);
			@class.method_5("\\\\.\\\\" + this.string_1);
			@class.method_3(fileInfo_);
			@class.LoadMethod = (Enum27)0;
			Class25 class2 = new Class25(@class, null);
			Class25.smethod_0(class2.Config.method_4(), class2.Config.IoMethod);
			try
			{
				if (class2.imethod_9() && class2.imethod_0().imethod_6())
				{
					this.method_4(class2);
					Class19.Class24.class19_0 = this;
					this.method_5((ulong)((long)Process.GetProcessesByName(string_2)[0].Id));
					this.method_6(string_2);
					this.ulong_1 = this.method_9();
					if (this.ulong_1 > 100UL && this.method_0() > 0UL)
					{
						this.bool_0 = true;
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005B48 File Offset: 0x00003D48
		public byte[] method_13(ulong ulong_2, int int_0 = 4)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				return this.method_7(ulong_2, int_0);
			}
			return new byte[int_0];
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005B6C File Offset: 0x00003D6C
		public byte method_14(ulong ulong_2)
		{
			if (!Class19.smethod_0(ulong_2) || !this.bool_0)
			{
				return 0;
			}
			byte[] array = new byte[1];
			array = this.method_13(ulong_2, 1);
			if (array != null)
			{
				return array[0];
			}
			return 0;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005BA4 File Offset: 0x00003DA4
		public short method_15(ulong ulong_2)
		{
			if (!Class19.smethod_0(ulong_2) || !this.bool_0)
			{
				return 0;
			}
			byte[] array = new byte[2];
			array = this.method_13(ulong_2, 2);
			if (array == null)
			{
				return 0;
			}
			return BitConverter.ToInt16(array, 0);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005BE0 File Offset: 0x00003DE0
		public int method_16(ulong ulong_2)
		{
			if (!Class19.smethod_0(ulong_2) || !this.bool_0)
			{
				return 0;
			}
			byte[] array = new byte[4];
			array = this.method_13(ulong_2, 4);
			if (array == null)
			{
				return 0;
			}
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005C1C File Offset: 0x00003E1C
		public ulong method_17(ulong ulong_2)
		{
			if (!Class19.smethod_0(ulong_2) || !this.bool_0)
			{
				return 0UL;
			}
			byte[] array = new byte[8];
			array = this.method_13(ulong_2, 8);
			if (array != null)
			{
				return (ulong)BitConverter.ToInt64(array, 0);
			}
			return 0UL;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00005C5C File Offset: 0x00003E5C
		public float method_18(ulong ulong_2)
		{
			if (!Class19.smethod_0(ulong_2) || !this.bool_0)
			{
				return 0f;
			}
			byte[] array = new byte[4];
			array = this.method_13(ulong_2, 4);
			if (array == null)
			{
				return 0f;
			}
			return BitConverter.ToSingle(array, 0);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005CA0 File Offset: 0x00003EA0
		public double method_19(ulong ulong_2)
		{
			if (!Class19.smethod_0(ulong_2) || !this.bool_0)
			{
				return 0.0;
			}
			byte[] array = new byte[8];
			array = this.method_13(ulong_2, 8);
			if (array == null)
			{
				return 0.0;
			}
			return BitConverter.ToDouble(array, 0);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005CEC File Offset: 0x00003EEC
		public ulong method_20(params ulong[] args)
		{
			if (!Class19.smethod_0(args[0]) || !this.bool_0)
			{
				return 0UL;
			}
			ulong num = 0UL;
			if (args.Length <= 1)
			{
				return 0UL;
			}
			for (int i = 0; i <= args.Count<ulong>() - 1; i++)
			{
				if (i != 0)
				{
					if (i != args.Count<ulong>() - 1)
					{
						if (num == 0UL)
						{
							return 0UL;
						}
						num = this.method_17(num + args[i]);
					}
					else
					{
						num += args[i];
					}
				}
				else
				{
					num = this.method_17(args[i]);
				}
			}
			if (!Class19.smethod_0(num))
			{
				return 0UL;
			}
			return num;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005D70 File Offset: 0x00003F70
		public string method_21(ulong ulong_2, int int_0 = 124, bool bool_1 = false)
		{
			if (bool_1)
			{
				int_0 *= 2;
			}
			if (!Class19.smethod_0(ulong_2) || !this.bool_0)
			{
				return "";
			}
			if (int_0 <= 0)
			{
				return "";
			}
			byte[] array = new byte[int_0];
			array = this.method_13(ulong_2, int_0);
			if (array == null)
			{
				return "";
			}
			if (!bool_1)
			{
				ASCIIEncoding asciiencoding = new ASCIIEncoding();
				for (int i = 0; i <= array.Length - 1; i++)
				{
					if (array[i] == 0)
					{
						Array.Resize<byte>(ref array, i);
						return asciiencoding.GetString(array);
					}
				}
				return asciiencoding.GetString(array);
			}
			return new UnicodeEncoding().GetString(array);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005E00 File Offset: 0x00004000
		public Class19.Class21.Struct12 method_22(ulong ulong_2)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				byte[] array = this.method_13(ulong_2, 8);
				float[] array2 = new float[array.Length / 4];
				Buffer.BlockCopy(array, 0, array2, 0, array.Length);
				return new Class19.Class21.Struct12(array2[0], array2[1]);
			}
			return new Class19.Class21.Struct12(0f);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00005E54 File Offset: 0x00004054
		public void method_23(ulong ulong_2, Class19.Class21.Struct12 struct12_0)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				float[] array = new float[]
				{
					struct12_0.float_0,
					struct12_0.float_1
				};
				byte[] array2 = new byte[array.Length * 4];
				Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
				this.method_28(ulong_2, array2, false);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005EA8 File Offset: 0x000040A8
		public Class19.Class22.Struct13 method_24(ulong ulong_2)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				byte[] array = this.method_13(ulong_2, 12);
				float[] array2 = new float[array.Length / 4];
				Buffer.BlockCopy(array, 0, array2, 0, array.Length);
				return new Class19.Class22.Struct13(array2[0], array2[1], array2[2]);
			}
			return new Class19.Class22.Struct13(0f);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005F00 File Offset: 0x00004100
		public void method_25(ulong ulong_2, Class19.Class22.Struct13 struct13_0)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				float[] array = new float[]
				{
					struct13_0.float_0,
					struct13_0.float_1,
					struct13_0.float_2
				};
				byte[] array2 = new byte[array.Length * 4];
				Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
				this.method_28(ulong_2, array2, false);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005F60 File Offset: 0x00004160
		public Class19.Class23.Struct14 method_26(ulong ulong_2)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				byte[] array = this.method_13(ulong_2, 16);
				float[] array2 = new float[array.Length / 4];
				Buffer.BlockCopy(array, 0, array2, 0, array.Length);
				return new Class19.Class23.Struct14(array2[0], array2[1], array2[2], array2[3]);
			}
			return new Class19.Class23.Struct14(0f);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005FBC File Offset: 0x000041BC
		public void method_27(ulong ulong_2, Class19.Class23.Struct14 struct14_0)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				float[] array = new float[]
				{
					struct14_0.float_0,
					struct14_0.float_1,
					struct14_0.float_2,
					struct14_0.float_3
				};
				byte[] array2 = new byte[array.Length * 4];
				Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
				this.method_28(ulong_2, array2, false);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006022 File Offset: 0x00004222
		public void method_28(ulong ulong_2, byte[] byte_0, bool bool_1 = false)
		{
			this.method_8(ulong_2, byte_0, bool_1);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006030 File Offset: 0x00004230
		public void method_29(ulong ulong_2, byte byte_0, bool bool_1 = false)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				byte[] byte_ = new byte[1];
				byte_ = BitConverter.GetBytes((short)byte_0);
				this.method_28(ulong_2, byte_, bool_1);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006064 File Offset: 0x00004264
		public void method_30(ulong ulong_2, short short_0, bool bool_1 = false)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				byte[] byte_ = new byte[2];
				byte_ = BitConverter.GetBytes(short_0);
				this.method_28(ulong_2, byte_, bool_1);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006098 File Offset: 0x00004298
		public void method_31(ulong ulong_2, int int_0, bool bool_1 = false)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				byte[] byte_ = new byte[4];
				byte_ = BitConverter.GetBytes(int_0);
				this.method_28(ulong_2, byte_, bool_1);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000060CC File Offset: 0x000042CC
		public void method_32(ulong ulong_2, long long_0, bool bool_1 = false)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				byte[] byte_ = new byte[8];
				byte_ = BitConverter.GetBytes(long_0);
				this.method_28(ulong_2, byte_, bool_1);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006100 File Offset: 0x00004300
		public void method_33(ulong ulong_2, float float_0, bool bool_1 = false)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				byte[] byte_ = new byte[4];
				byte_ = BitConverter.GetBytes(float_0);
				this.method_28(ulong_2, byte_, bool_1);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00006134 File Offset: 0x00004334
		public void method_34(ulong ulong_2, double double_0, bool bool_1 = false)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				byte[] byte_ = new byte[4];
				byte_ = BitConverter.GetBytes(double_0);
				this.method_28(ulong_2, byte_, bool_1);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006168 File Offset: 0x00004368
		public void method_35(ulong ulong_2, string string_2, bool bool_1 = false, bool bool_2 = false)
		{
			if (Class19.smethod_0(ulong_2) && this.bool_0)
			{
				if (bool_1)
				{
					UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
					this.method_28(ulong_2, unicodeEncoding.GetBytes(string_2), bool_2);
					this.method_29(ulong_2 + (ulong)((long)(string_2.Length * 2)), 0, bool_2);
					return;
				}
				ASCIIEncoding asciiencoding = new ASCIIEncoding();
				this.method_28(ulong_2, asciiencoding.GetBytes(string_2), bool_2);
				this.method_29(ulong_2 + (ulong)((long)string_2.Length), 0, bool_2);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000061DB File Offset: 0x000043DB
		public void method_36(ulong ulong_2, bool bool_1 = false)
		{
			this.method_28(ulong_2, new byte[]
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
			}, bool_1);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000061F7 File Offset: 0x000043F7
		public void method_37(ulong ulong_2, bool bool_1 = false)
		{
			this.method_28(ulong_2, new byte[]
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
			}, bool_1);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00006214 File Offset: 0x00004414
		public bool method_38(byte[] byte_0, int int_0, byte[] byte_1, string string_2)
		{
			for (int i = 0; i <= byte_1.Length - 1; i++)
			{
				if (string_2[i].ToString() == "x" && byte_0[int_0] != byte_1[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00006258 File Offset: 0x00004458
		public ulong method_39(ulong ulong_2, long long_0, byte[] byte_0, string string_2, int int_0 = 1)
		{
			if (string_2.Length != byte_0.Length)
			{
				return 0UL;
			}
			if (!Class19.smethod_0(ulong_2) || !this.bool_0)
			{
				return 0UL;
			}
			int num = 8;
			if (long_0 > 268435455L)
			{
				int num2 = (int)(long_0 / (long)(int.MaxValue / num));
				ulong num3 = (ulong)((long)(int.MaxValue / num) + 1L);
				for (int i = 0; i <= num2; i++)
				{
					byte[] array = new byte[num3 + (ulong)((long)byte_0.Length)];
					array = this.method_13(ulong_2 + num3 * (ulong)((long)i), (int)(num3 + (ulong)((long)byte_0.Length)));
					if (array == null)
					{
						return 0UL;
					}
					for (int j = 0; j <= (int)num3; j++)
					{
						int num4 = 0;
						while (num4 <= byte_0.Length - 1 && (!(string_2[num4].ToString() == "x") || array[j + num4] == byte_0[num4]))
						{
							if (num4 == byte_0.Length - 1)
							{
								return ulong_2 + num3 * (ulong)((long)i) + (ulong)((long)j);
							}
							num4++;
						}
						j += int_0 - 1;
					}
				}
				return 0UL;
			}
			byte[] array2 = new byte[long_0];
			array2 = this.method_13(ulong_2, (int)long_0);
			if (array2 != null)
			{
				int num5 = 0;
				while ((long)num5 <= long_0)
				{
					int num6 = 0;
					while (num6 <= byte_0.Length - 1 && (!(string_2[num6].ToString() == "x") || array2[num5 + num6] == byte_0[num6]))
					{
						if (num6 == byte_0.Length - 1)
						{
							return ulong_2 + (ulong)((long)num5);
						}
						num6++;
					}
					num5++;
				}
				return 0UL;
			}
			return 0UL;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000063D9 File Offset: 0x000045D9
		internal static bool smethod_1()
		{
			return Class19.object_0 == null;
		}

		// Token: 0x04000094 RID: 148
		[CompilerGenerated]
		private Class25 class25_0;

		// Token: 0x04000095 RID: 149
		[CompilerGenerated]
		private ulong ulong_0;

		// Token: 0x04000096 RID: 150
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000097 RID: 151
		private uint uint_0 = 2247680U;

		// Token: 0x04000098 RID: 152
		private uint uint_1 = 2247684U;

		// Token: 0x04000099 RID: 153
		private uint uint_2 = 2247688U;

		// Token: 0x0400009A RID: 154
		private uint uint_3 = 2247692U;

		// Token: 0x0400009B RID: 155
		private uint uint_4 = 2247696U;

		// Token: 0x0400009C RID: 156
		private uint uint_5 = 2247700U;

		// Token: 0x0400009D RID: 157
		private string string_1 = "DriverSRVName";

		// Token: 0x0400009E RID: 158
		public ulong ulong_1;

		// Token: 0x0400009F RID: 159
		public bool bool_0;

		// Token: 0x040000A0 RID: 160
		internal static object object_0;

		// Token: 0x02000022 RID: 34
		internal class Class20
		{
			// Token: 0x06000135 RID: 309 RVA: 0x000063E3 File Offset: 0x000045E3
			internal static bool smethod_0()
			{
				return Class19.Class20.object_0 == null;
			}

			// Token: 0x040000A1 RID: 161
			public uint uint_0 = 2247680U;

			// Token: 0x040000A2 RID: 162
			public uint uint_1 = 2247684U;

			// Token: 0x040000A3 RID: 163
			public uint uint_2 = 2247688U;

			// Token: 0x040000A4 RID: 164
			public uint uint_3 = 2247692U;

			// Token: 0x040000A5 RID: 165
			public uint uint_4 = 2247696U;

			// Token: 0x040000A6 RID: 166
			public uint uint_5 = 2247700U;

			// Token: 0x040000A7 RID: 167
			public string string_0 = "DriverSRVName";

			// Token: 0x040000A8 RID: 168
			internal static object object_0;
		}

		// Token: 0x02000023 RID: 35
		internal enum Enum26
		{

		}

		// Token: 0x02000024 RID: 36
		internal class Class21
		{
			// Token: 0x06000137 RID: 311 RVA: 0x00006450 File Offset: 0x00004650
			internal static bool smethod_0()
			{
				return Class19.Class21.object_0 == null;
			}

			// Token: 0x040000AA RID: 170
			internal static object object_0;

			// Token: 0x02000025 RID: 37
			[DefaultMember("Component")]
			internal struct Struct12
			{
				// Token: 0x06000139 RID: 313 RVA: 0x0000645A File Offset: 0x0000465A
				public float method_0()
				{
					return this.float_0;
				}

				// Token: 0x0600013A RID: 314 RVA: 0x00006462 File Offset: 0x00004662
				public void method_1(float float_2)
				{
					this.float_0 = float_2;
				}

				// Token: 0x0600013B RID: 315 RVA: 0x0000646B File Offset: 0x0000466B
				public float method_2()
				{
					return this.float_1;
				}

				// Token: 0x0600013C RID: 316 RVA: 0x00006473 File Offset: 0x00004673
				public void method_3(float float_2)
				{
					this.float_1 = float_2;
				}

				// Token: 0x0600013D RID: 317 RVA: 0x0000647C File Offset: 0x0000467C
				public static Class19.Class21.Struct12 smethod_0()
				{
					return new Class19.Class21.Struct12(1f);
				}

				// Token: 0x0600013E RID: 318 RVA: 0x00006488 File Offset: 0x00004688
				public static Class19.Class21.Struct12 smethod_1()
				{
					return new Class19.Class21.Struct12(0f);
				}

				// Token: 0x0600013F RID: 319 RVA: 0x00006494 File Offset: 0x00004694
				public static Class19.Class21.Struct12 smethod_2()
				{
					return new Class19.Class21.Struct12(-1f);
				}

				// Token: 0x06000140 RID: 320 RVA: 0x000064A0 File Offset: 0x000046A0
				public unsafe float method_4(int int_0)
				{
					if ((int_0 | 3) != 3)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					fixed (float* ptr = &this.float_0)
					{
						return ptr[int_0];
					}
				}

				// Token: 0x06000141 RID: 321 RVA: 0x000064D0 File Offset: 0x000046D0
				public unsafe void method_5(int int_0, float float_2)
				{
					if ((int_0 | 3) != 3)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					fixed (float* ptr = &this.float_0)
					{
						ptr[int_0] = float_2;
					}
				}

				// Token: 0x06000142 RID: 322 RVA: 0x00006501 File Offset: 0x00004701
				public Struct12(float float_2, float float_3)
				{
					this.float_0 = float_2;
					this.float_1 = float_3;
				}

				// Token: 0x06000143 RID: 323 RVA: 0x00006511 File Offset: 0x00004711
				public Struct12(float float_2)
				{
					this.float_0 = float_2;
					this.float_1 = float_2;
				}

				// Token: 0x06000144 RID: 324 RVA: 0x00006521 File Offset: 0x00004721
				public static float smethod_3(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					return struct12_0.float_0 * struct12_1.float_0 + struct12_0.float_1 * struct12_1.float_1;
				}

				// Token: 0x06000145 RID: 325 RVA: 0x00006540 File Offset: 0x00004740
				public static float smethod_4(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					float num = struct12_0.float_0 - struct12_1.float_0;
					float num2 = struct12_0.float_1 - struct12_1.float_1;
					return (float)Math.Sqrt((double)(num * num + num2 * num2));
				}

				// Token: 0x06000146 RID: 326 RVA: 0x00006578 File Offset: 0x00004778
				public unsafe static Class19.Class21.Struct12 operator &(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					Class19.Class21.Struct12 result = default(Class19.Class21.Struct12);
					int* ptr = (int*)(&struct12_0);
					int* ptr2 = (int*)(&struct12_1);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*ptr3 = (*ptr & *ptr2);
					return result;
				}

				// Token: 0x06000147 RID: 327 RVA: 0x000065DC File Offset: 0x000047DC
				public unsafe static Class19.Class21.Struct12 operator |(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					Class19.Class21.Struct12 result = default(Class19.Class21.Struct12);
					int* ptr = (int*)(&struct12_0);
					int* ptr2 = (int*)(&struct12_1);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*ptr3 = (*ptr | *ptr2);
					return result;
				}

				// Token: 0x06000148 RID: 328 RVA: 0x00006640 File Offset: 0x00004840
				public unsafe static Class19.Class21.Struct12 operator ^(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					Class19.Class21.Struct12 result = default(Class19.Class21.Struct12);
					int* ptr = (int*)(&struct12_0);
					int* ptr2 = (int*)(&struct12_1);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*ptr3 = (*ptr ^ *ptr2);
					return result;
				}

				// Token: 0x06000149 RID: 329 RVA: 0x000066A2 File Offset: 0x000048A2
				public static Class19.Class21.Struct12 operator +(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					return new Class19.Class21.Struct12(struct12_0.float_0 + struct12_1.float_0, struct12_0.float_1 + struct12_1.float_1);
				}

				// Token: 0x0600014A RID: 330 RVA: 0x000066C3 File Offset: 0x000048C3
				public static Class19.Class21.Struct12 operator -(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					return new Class19.Class21.Struct12(struct12_0.float_0 - struct12_1.float_0, struct12_0.float_1 - struct12_1.float_1);
				}

				// Token: 0x0600014B RID: 331 RVA: 0x000066E4 File Offset: 0x000048E4
				public static Class19.Class21.Struct12 operator *(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					return new Class19.Class21.Struct12(struct12_0.float_0 * struct12_1.float_0, struct12_0.float_1 * struct12_1.float_1);
				}

				// Token: 0x0600014C RID: 332 RVA: 0x00006705 File Offset: 0x00004905
				public static Class19.Class21.Struct12 operator *(float float_2, Class19.Class21.Struct12 struct12_0)
				{
					return new Class19.Class21.Struct12(float_2 * struct12_0.float_0, float_2 * struct12_0.float_1);
				}

				// Token: 0x0600014D RID: 333 RVA: 0x0000671C File Offset: 0x0000491C
				public static Class19.Class21.Struct12 operator *(Class19.Class21.Struct12 struct12_0, float float_2)
				{
					return new Class19.Class21.Struct12(float_2 * struct12_0.float_0, float_2 * struct12_0.float_1);
				}

				// Token: 0x0600014E RID: 334 RVA: 0x00006733 File Offset: 0x00004933
				public static Class19.Class21.Struct12 operator /(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					return new Class19.Class21.Struct12(struct12_0.float_0 / struct12_1.float_0, struct12_0.float_1 / struct12_1.float_1);
				}

				// Token: 0x0600014F RID: 335 RVA: 0x00006754 File Offset: 0x00004954
				public static bool operator ==(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					return struct12_0.float_0 == struct12_1.float_0 && struct12_0.float_1 == struct12_1.float_1;
				}

				// Token: 0x06000150 RID: 336 RVA: 0x00006774 File Offset: 0x00004974
				public static bool operator !=(Class19.Class21.Struct12 struct12_0, Class19.Class21.Struct12 struct12_1)
				{
					return struct12_0.float_0 != struct12_1.float_0 || struct12_0.float_1 != struct12_1.float_1;
				}

				// Token: 0x06000151 RID: 337 RVA: 0x00006798 File Offset: 0x00004998
				public override string ToString()
				{
					return string.Concat(new string[]
					{
						"<",
						this.float_0.ToString(),
						", ",
						this.float_1.ToString(),
						">"
					});
				}

				// Token: 0x06000152 RID: 338 RVA: 0x000067E4 File Offset: 0x000049E4
				internal static bool smethod_5()
				{
					return Class19.Class21.Struct12.object_0 == null;
				}

				// Token: 0x040000AB RID: 171
				internal float float_0;

				// Token: 0x040000AC RID: 172
				internal float float_1;

				// Token: 0x040000AD RID: 173
				private static object object_0;
			}
		}

		// Token: 0x02000026 RID: 38
		internal class Class22
		{
			// Token: 0x06000153 RID: 339 RVA: 0x000067EE File Offset: 0x000049EE
			internal static bool smethod_0()
			{
				return Class19.Class22.object_0 == null;
			}

			// Token: 0x040000AE RID: 174
			internal static object object_0;

			// Token: 0x02000027 RID: 39
			[DefaultMember("Component")]
			internal struct Struct13
			{
				// Token: 0x06000155 RID: 341 RVA: 0x000067F8 File Offset: 0x000049F8
				public float method_0()
				{
					return this.float_0;
				}

				// Token: 0x06000156 RID: 342 RVA: 0x00006800 File Offset: 0x00004A00
				public void method_1(float float_3)
				{
					this.float_0 = float_3;
				}

				// Token: 0x06000157 RID: 343 RVA: 0x00006809 File Offset: 0x00004A09
				public float method_2()
				{
					return this.float_1;
				}

				// Token: 0x06000158 RID: 344 RVA: 0x00006811 File Offset: 0x00004A11
				public void method_3(float float_3)
				{
					this.float_1 = float_3;
				}

				// Token: 0x06000159 RID: 345 RVA: 0x0000681A File Offset: 0x00004A1A
				public float method_4()
				{
					return this.float_2;
				}

				// Token: 0x0600015A RID: 346 RVA: 0x00006822 File Offset: 0x00004A22
				public void method_5(float float_3)
				{
					this.float_2 = float_3;
				}

				// Token: 0x0600015B RID: 347 RVA: 0x0000682B File Offset: 0x00004A2B
				public static Class19.Class22.Struct13 smethod_0()
				{
					return new Class19.Class22.Struct13(1f);
				}

				// Token: 0x0600015C RID: 348 RVA: 0x00006837 File Offset: 0x00004A37
				public static Class19.Class22.Struct13 smethod_1()
				{
					return new Class19.Class22.Struct13(0f);
				}

				// Token: 0x0600015D RID: 349 RVA: 0x00006843 File Offset: 0x00004A43
				public static Class19.Class22.Struct13 smethod_2()
				{
					return new Class19.Class22.Struct13(-1f);
				}

				// Token: 0x0600015E RID: 350 RVA: 0x00006850 File Offset: 0x00004A50
				public unsafe float method_6(int int_0)
				{
					if ((int_0 | 3) != 3)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					fixed (float* ptr = &this.float_0)
					{
						return ptr[int_0];
					}
				}

				// Token: 0x0600015F RID: 351 RVA: 0x00006880 File Offset: 0x00004A80
				public unsafe void method_7(int int_0, float float_3)
				{
					if ((int_0 | 3) != 3)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					fixed (float* ptr = &this.float_0)
					{
						ptr[int_0] = float_3;
					}
				}

				// Token: 0x06000160 RID: 352 RVA: 0x000068B1 File Offset: 0x00004AB1
				public Struct13(float float_3, float float_4, float float_5)
				{
					this.float_0 = float_3;
					this.float_1 = float_4;
					this.float_2 = float_5;
				}

				// Token: 0x06000161 RID: 353 RVA: 0x000068C8 File Offset: 0x00004AC8
				public Struct13(float float_3)
				{
					this.float_0 = float_3;
					this.float_1 = float_3;
					this.float_2 = float_3;
				}

				// Token: 0x06000162 RID: 354 RVA: 0x000068DF File Offset: 0x00004ADF
				public static float smethod_3(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					return struct13_0.float_0 * struct13_1.float_0 + struct13_0.float_1 * struct13_1.float_1 + struct13_0.float_2 * struct13_1.float_2;
				}

				// Token: 0x06000163 RID: 355 RVA: 0x0000690C File Offset: 0x00004B0C
				public static float smethod_4(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					float num = struct13_0.float_0 - struct13_1.float_0;
					float num2 = struct13_0.float_1 - struct13_1.float_1;
					float num3 = struct13_0.float_2 - struct13_1.float_2;
					return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3));
				}

				// Token: 0x06000164 RID: 356 RVA: 0x00006954 File Offset: 0x00004B54
				public unsafe static Class19.Class22.Struct13 operator &(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					Class19.Class22.Struct13 result = default(Class19.Class22.Struct13);
					int* ptr = (int*)(&struct13_0);
					int* ptr2 = (int*)(&struct13_1);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*ptr3 = (*ptr & *ptr2);
					return result;
				}

				// Token: 0x06000165 RID: 357 RVA: 0x000069B8 File Offset: 0x00004BB8
				public unsafe static Class19.Class22.Struct13 operator |(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					Class19.Class22.Struct13 result = default(Class19.Class22.Struct13);
					int* ptr = (int*)(&struct13_0);
					int* ptr2 = (int*)(&struct13_1);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*ptr3 = (*ptr | *ptr2);
					return result;
				}

				// Token: 0x06000166 RID: 358 RVA: 0x00006A1C File Offset: 0x00004C1C
				public unsafe static Class19.Class22.Struct13 operator ^(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					Class19.Class22.Struct13 result = default(Class19.Class22.Struct13);
					int* ptr = (int*)(&struct13_0);
					int* ptr2 = (int*)(&struct13_1);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*ptr3 = (*ptr ^ *ptr2);
					return result;
				}

				// Token: 0x06000167 RID: 359 RVA: 0x00006A7E File Offset: 0x00004C7E
				public static Class19.Class22.Struct13 operator +(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					return new Class19.Class22.Struct13(struct13_0.float_0 + struct13_1.float_0, struct13_0.float_1 + struct13_1.float_1, struct13_0.float_2 + struct13_1.float_2);
				}

				// Token: 0x06000168 RID: 360 RVA: 0x00006AAC File Offset: 0x00004CAC
				public static Class19.Class22.Struct13 operator -(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					return new Class19.Class22.Struct13(struct13_0.float_0 - struct13_1.float_0, struct13_0.float_1 - struct13_1.float_1, struct13_0.float_2 - struct13_1.float_2);
				}

				// Token: 0x06000169 RID: 361 RVA: 0x00006ADA File Offset: 0x00004CDA
				public static Class19.Class22.Struct13 operator *(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					return new Class19.Class22.Struct13(struct13_0.float_0 * struct13_1.float_0, struct13_0.float_1 * struct13_1.float_1, struct13_0.float_2 * struct13_1.float_2);
				}

				// Token: 0x0600016A RID: 362 RVA: 0x00006B08 File Offset: 0x00004D08
				public static Class19.Class22.Struct13 operator *(float float_3, Class19.Class22.Struct13 struct13_0)
				{
					return new Class19.Class22.Struct13(float_3 * struct13_0.float_0, float_3 * struct13_0.float_1, float_3 * struct13_0.float_2);
				}

				// Token: 0x0600016B RID: 363 RVA: 0x00006B27 File Offset: 0x00004D27
				public static Class19.Class22.Struct13 operator *(Class19.Class22.Struct13 struct13_0, float float_3)
				{
					return new Class19.Class22.Struct13(float_3 * struct13_0.float_0, float_3 * struct13_0.float_1, float_3 * struct13_0.float_2);
				}

				// Token: 0x0600016C RID: 364 RVA: 0x00006B46 File Offset: 0x00004D46
				public static Class19.Class22.Struct13 operator /(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					return new Class19.Class22.Struct13(struct13_0.float_0 / struct13_1.float_0, struct13_0.float_1 / struct13_1.float_1, struct13_0.float_2 / struct13_1.float_2);
				}

				// Token: 0x0600016D RID: 365 RVA: 0x00006B74 File Offset: 0x00004D74
				public static bool operator ==(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					return struct13_0.float_0 == struct13_1.float_0 && struct13_0.float_1 == struct13_1.float_1 && struct13_0.float_2 == struct13_1.float_2;
				}

				// Token: 0x0600016E RID: 366 RVA: 0x00006BA2 File Offset: 0x00004DA2
				public static bool operator !=(Class19.Class22.Struct13 struct13_0, Class19.Class22.Struct13 struct13_1)
				{
					return struct13_0.float_0 != struct13_1.float_0 || struct13_0.float_1 != struct13_1.float_1 || struct13_0.float_2 != struct13_1.float_2;
				}

				// Token: 0x0600016F RID: 367 RVA: 0x00006BD4 File Offset: 0x00004DD4
				public override string ToString()
				{
					return string.Concat(new string[]
					{
						"<",
						this.float_0.ToString(),
						", ",
						this.float_1.ToString(),
						", ",
						this.float_2.ToString(),
						">"
					});
				}

				// Token: 0x06000170 RID: 368 RVA: 0x00006C36 File Offset: 0x00004E36
				internal static bool smethod_5()
				{
					return Class19.Class22.Struct13.object_0 == null;
				}

				// Token: 0x040000AF RID: 175
				internal float float_0;

				// Token: 0x040000B0 RID: 176
				internal float float_1;

				// Token: 0x040000B1 RID: 177
				internal float float_2;

				// Token: 0x040000B2 RID: 178
				internal static object object_0;
			}
		}

		// Token: 0x02000028 RID: 40
		internal class Class23
		{
			// Token: 0x06000171 RID: 369 RVA: 0x00006C40 File Offset: 0x00004E40
			internal static bool smethod_0()
			{
				return Class19.Class23.object_0 == null;
			}

			// Token: 0x040000B3 RID: 179
			private static object object_0;

			// Token: 0x02000029 RID: 41
			[DefaultMember("Component")]
			internal struct Struct14
			{
				// Token: 0x06000173 RID: 371 RVA: 0x00006C4A File Offset: 0x00004E4A
				public float method_0()
				{
					return this.float_0;
				}

				// Token: 0x06000174 RID: 372 RVA: 0x00006C52 File Offset: 0x00004E52
				public void method_1(float float_4)
				{
					this.float_0 = float_4;
				}

				// Token: 0x06000175 RID: 373 RVA: 0x00006C5B File Offset: 0x00004E5B
				public float method_2()
				{
					return this.float_1;
				}

				// Token: 0x06000176 RID: 374 RVA: 0x00006C63 File Offset: 0x00004E63
				public void method_3(float float_4)
				{
					this.float_1 = float_4;
				}

				// Token: 0x06000177 RID: 375 RVA: 0x00006C6C File Offset: 0x00004E6C
				public float method_4()
				{
					return this.float_2;
				}

				// Token: 0x06000178 RID: 376 RVA: 0x00006C74 File Offset: 0x00004E74
				public void method_5(float float_4)
				{
					this.float_2 = float_4;
				}

				// Token: 0x06000179 RID: 377 RVA: 0x00006C7D File Offset: 0x00004E7D
				public float method_6()
				{
					return this.float_3;
				}

				// Token: 0x0600017A RID: 378 RVA: 0x00006C85 File Offset: 0x00004E85
				public void method_7(float float_4)
				{
					this.float_3 = float_4;
				}

				// Token: 0x0600017B RID: 379 RVA: 0x00006C8E File Offset: 0x00004E8E
				public static Class19.Class23.Struct14 smethod_0()
				{
					return new Class19.Class23.Struct14(3.1415927f);
				}

				// Token: 0x0600017C RID: 380 RVA: 0x00006C9A File Offset: 0x00004E9A
				public static Class19.Class23.Struct14 smethod_1()
				{
					return new Class19.Class23.Struct14(2.7182817f);
				}

				// Token: 0x0600017D RID: 381 RVA: 0x00006CA6 File Offset: 0x00004EA6
				public static Class19.Class23.Struct14 smethod_2()
				{
					return new Class19.Class23.Struct14(1f);
				}

				// Token: 0x0600017E RID: 382 RVA: 0x00006CB2 File Offset: 0x00004EB2
				public static Class19.Class23.Struct14 smethod_3()
				{
					return new Class19.Class23.Struct14(0f);
				}

				// Token: 0x0600017F RID: 383 RVA: 0x00006CBE File Offset: 0x00004EBE
				public static Class19.Class23.Struct14 smethod_4()
				{
					return new Class19.Class23.Struct14(-1f);
				}

				// Token: 0x06000180 RID: 384 RVA: 0x00006CCC File Offset: 0x00004ECC
				public unsafe float method_8(int int_0)
				{
					if ((int_0 | 3) != 3)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					fixed (float* ptr = &this.float_0)
					{
						return ptr[int_0];
					}
				}

				// Token: 0x06000181 RID: 385 RVA: 0x00006CFC File Offset: 0x00004EFC
				public unsafe void method_9(int int_0, float float_4)
				{
					if ((int_0 | 3) != 3)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					fixed (float* ptr = &this.float_0)
					{
						ptr[int_0] = float_4;
					}
				}

				// Token: 0x06000182 RID: 386 RVA: 0x00006D2D File Offset: 0x00004F2D
				public Struct14(float float_4, float float_5, float float_6, float float_7)
				{
					this.float_0 = float_4;
					this.float_1 = float_5;
					this.float_2 = float_6;
					this.float_3 = float_7;
				}

				// Token: 0x06000183 RID: 387 RVA: 0x00006D4C File Offset: 0x00004F4C
				public Struct14(float float_4)
				{
					this.float_0 = float_4;
					this.float_1 = float_4;
					this.float_2 = float_4;
					this.float_3 = float_4;
				}

				// Token: 0x06000184 RID: 388 RVA: 0x00006D6A File Offset: 0x00004F6A
				public static float smethod_5(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					return struct14_0.float_0 * struct14_1.float_0 + struct14_0.float_1 * struct14_1.float_1 + struct14_0.float_2 * struct14_1.float_2 + struct14_0.float_3 * struct14_1.float_3;
				}

				// Token: 0x06000185 RID: 389 RVA: 0x00006DA4 File Offset: 0x00004FA4
				public static float smethod_6(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					float num = struct14_0.float_0 - struct14_1.float_0;
					float num2 = struct14_0.float_1 - struct14_1.float_1;
					float num3 = struct14_0.float_2 - struct14_1.float_2;
					float num4 = struct14_0.float_3 - struct14_1.float_3;
					return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3 + num4 * num4));
				}

				// Token: 0x06000186 RID: 390 RVA: 0x00006E00 File Offset: 0x00005000
				public unsafe static Class19.Class23.Struct14 operator &(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					Class19.Class23.Struct14 result = default(Class19.Class23.Struct14);
					int* ptr = (int*)(&struct14_0);
					int* ptr2 = (int*)(&struct14_1);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*ptr3 = (*ptr & *ptr2);
					return result;
				}

				// Token: 0x06000187 RID: 391 RVA: 0x00006E64 File Offset: 0x00005064
				public unsafe static Class19.Class23.Struct14 operator |(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					Class19.Class23.Struct14 result = default(Class19.Class23.Struct14);
					int* ptr = (int*)(&struct14_0);
					int* ptr2 = (int*)(&struct14_1);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*ptr3 = (*ptr | *ptr2);
					return result;
				}

				// Token: 0x06000188 RID: 392 RVA: 0x00006EC8 File Offset: 0x000050C8
				public unsafe static Class19.Class23.Struct14 operator ^(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					Class19.Class23.Struct14 result = default(Class19.Class23.Struct14);
					int* ptr = (int*)(&struct14_0);
					int* ptr2 = (int*)(&struct14_1);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*ptr3 = (*ptr ^ *ptr2);
					return result;
				}

				// Token: 0x06000189 RID: 393 RVA: 0x00006F2A File Offset: 0x0000512A
				public static Class19.Class23.Struct14 operator +(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					return new Class19.Class23.Struct14(struct14_0.float_0 + struct14_1.float_0, struct14_0.float_1 + struct14_1.float_1, struct14_0.float_2 + struct14_1.float_2, struct14_0.float_3 + struct14_1.float_3);
				}

				// Token: 0x0600018A RID: 394 RVA: 0x00006F65 File Offset: 0x00005165
				public static Class19.Class23.Struct14 operator -(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					return new Class19.Class23.Struct14(struct14_0.float_0 - struct14_1.float_0, struct14_0.float_1 - struct14_1.float_1, struct14_0.float_2 - struct14_1.float_2, struct14_0.float_3 - struct14_1.float_3);
				}

				// Token: 0x0600018B RID: 395 RVA: 0x00006FA0 File Offset: 0x000051A0
				public static Class19.Class23.Struct14 operator *(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					return new Class19.Class23.Struct14(struct14_0.float_0 * struct14_1.float_0, struct14_0.float_1 * struct14_1.float_1, struct14_0.float_2 * struct14_1.float_2, struct14_0.float_3 * struct14_1.float_3);
				}

				// Token: 0x0600018C RID: 396 RVA: 0x00006FDB File Offset: 0x000051DB
				public static Class19.Class23.Struct14 operator *(float float_4, Class19.Class23.Struct14 struct14_0)
				{
					return new Class19.Class23.Struct14(float_4 * struct14_0.float_0, float_4 * struct14_0.float_1, float_4 * struct14_0.float_2, float_4 * struct14_0.float_3);
				}

				// Token: 0x0600018D RID: 397 RVA: 0x00007002 File Offset: 0x00005202
				public static Class19.Class23.Struct14 operator *(Class19.Class23.Struct14 struct14_0, float float_4)
				{
					return new Class19.Class23.Struct14(float_4 * struct14_0.float_0, float_4 * struct14_0.float_1, float_4 * struct14_0.float_2, float_4 * struct14_0.float_3);
				}

				// Token: 0x0600018E RID: 398 RVA: 0x00007029 File Offset: 0x00005229
				public static Class19.Class23.Struct14 operator /(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					return new Class19.Class23.Struct14(struct14_0.float_0 / struct14_1.float_0, struct14_0.float_1 / struct14_1.float_1, struct14_0.float_2 / struct14_1.float_2, struct14_0.float_3 / struct14_1.float_3);
				}

				// Token: 0x0600018F RID: 399 RVA: 0x00007064 File Offset: 0x00005264
				public static bool operator ==(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					return struct14_0.float_0 == struct14_1.float_0 && struct14_0.float_1 == struct14_1.float_1 && struct14_0.float_2 == struct14_1.float_2 && struct14_0.float_3 == struct14_1.float_3;
				}

				// Token: 0x06000190 RID: 400 RVA: 0x000070A0 File Offset: 0x000052A0
				public static bool operator !=(Class19.Class23.Struct14 struct14_0, Class19.Class23.Struct14 struct14_1)
				{
					return struct14_0.float_0 != struct14_1.float_0 || struct14_0.float_1 != struct14_1.float_1 || struct14_0.float_2 != struct14_1.float_2 || struct14_0.float_3 != struct14_1.float_3;
				}

				// Token: 0x06000191 RID: 401 RVA: 0x000070E0 File Offset: 0x000052E0
				public override string ToString()
				{
					return string.Concat(new string[]
					{
						"<",
						this.float_0.ToString(),
						", ",
						this.float_1.ToString(),
						", ",
						this.float_2.ToString(),
						", ",
						this.float_3.ToString(),
						">"
					});
				}

				// Token: 0x06000192 RID: 402 RVA: 0x00007159 File Offset: 0x00005359
				internal static bool smethod_7()
				{
					return Class19.Class23.Struct14.object_0 == null;
				}

				// Token: 0x040000B4 RID: 180
				internal float float_0;

				// Token: 0x040000B5 RID: 181
				internal float float_1;

				// Token: 0x040000B6 RID: 182
				internal float float_2;

				// Token: 0x040000B7 RID: 183
				internal float float_3;

				// Token: 0x040000B8 RID: 184
				private static object object_0;
			}
		}

		// Token: 0x0200002A RID: 42
		internal class Class24
		{
			// Token: 0x06000193 RID: 403 RVA: 0x00007164 File Offset: 0x00005364
			public Class24(float float_16, float float_17, float float_18, float float_19, float float_20, float float_21, float float_22, float float_23, float float_24, float float_25, float float_26, float float_27, float float_28, float float_29, float float_30, float float_31)
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

			// Token: 0x06000194 RID: 404 RVA: 0x000071F4 File Offset: 0x000053F4
			public Class24(float float_16)
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

			// Token: 0x06000195 RID: 405 RVA: 0x00007278 File Offset: 0x00005478
			public static Class19.Class24 smethod_0(ulong ulong_0)
			{
				if (Class19.smethod_0(ulong_0) && Class19.Class24.class19_0.bool_0)
				{
					byte[] array = Class19.Class24.class19_0.method_13(ulong_0, 64);
					float[] array2 = new float[array.Length / 4];
					Buffer.BlockCopy(array, 0, array2, 0, array.Length);
					return new Class19.Class24(array2[0], array2[1], array2[2], array2[3], array2[4], array2[5], array2[6], array2[7], array2[8], array2[9], array2[10], array2[11], array2[12], array2[13], array2[14], array2[15]);
				}
				return new Class19.Class24(0f);
			}

			// Token: 0x06000196 RID: 406 RVA: 0x00007308 File Offset: 0x00005508
			public static void smethod_1(ref Class19.Class24 class24_0, out Class19.Class24 class24_1)
			{
				class24_1 = new Class19.Class24(0f)
				{
					float_0 = class24_0.float_0,
					float_1 = class24_0.float_4,
					float_2 = class24_0.float_8,
					float_3 = class24_0.float_12,
					float_4 = class24_0.float_1,
					float_5 = class24_0.float_5,
					float_6 = class24_0.float_9,
					float_7 = class24_0.float_13,
					float_8 = class24_0.float_2,
					float_9 = class24_0.float_6,
					float_10 = class24_0.float_10,
					float_11 = class24_0.float_14,
					float_12 = class24_0.float_3,
					float_13 = class24_0.float_7,
					float_14 = class24_0.float_11,
					float_15 = class24_0.float_15
				};
			}

			// Token: 0x06000197 RID: 407 RVA: 0x000073F1 File Offset: 0x000055F1
			internal static bool smethod_2()
			{
				return Class19.Class24.object_0 == null;
			}

			// Token: 0x040000B9 RID: 185
			internal static Class19 class19_0;

			// Token: 0x040000BA RID: 186
			public float float_0;

			// Token: 0x040000BB RID: 187
			public float float_1;

			// Token: 0x040000BC RID: 188
			public float float_2;

			// Token: 0x040000BD RID: 189
			public float float_3;

			// Token: 0x040000BE RID: 190
			public float float_4;

			// Token: 0x040000BF RID: 191
			public float float_5;

			// Token: 0x040000C0 RID: 192
			public float float_6;

			// Token: 0x040000C1 RID: 193
			public float float_7;

			// Token: 0x040000C2 RID: 194
			public float float_8;

			// Token: 0x040000C3 RID: 195
			public float float_9;

			// Token: 0x040000C4 RID: 196
			public float float_10;

			// Token: 0x040000C5 RID: 197
			public float float_11;

			// Token: 0x040000C6 RID: 198
			public float float_12;

			// Token: 0x040000C7 RID: 199
			public float float_13;

			// Token: 0x040000C8 RID: 200
			public float float_14;

			// Token: 0x040000C9 RID: 201
			public float float_15;

			// Token: 0x040000CA RID: 202
			internal static object object_0;
		}
	}
}
