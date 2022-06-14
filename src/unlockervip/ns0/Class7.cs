using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns0
{
	// Token: 0x02000037 RID: 55
	internal class Class7
	{
		// Token: 0x0600022E RID: 558 RVA: 0x00008FE8 File Offset: 0x000071E8
		public static string smethod_0(string string_0, string string_1)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				if (!string.IsNullOrEmpty(string_1))
				{
					RijndaelManaged rijndaelManaged = null;
					try
					{
						Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, Class7.byte_0);
						rijndaelManaged = new RijndaelManaged();
						rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
						ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
						using (MemoryStream memoryStream = new MemoryStream())
						{
							memoryStream.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
							memoryStream.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
							using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
							{
								using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
								{
									streamWriter.Write(string_0);
								}
							}
							return Convert.ToBase64String(memoryStream.ToArray());
						}
					}
					finally
					{
						if (rijndaelManaged != null)
						{
							rijndaelManaged.Clear();
						}
					}
				}
				throw new ArgumentNullException("sharedSecret");
			}
			throw new ArgumentNullException("plainText");
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000911C File Offset: 0x0000731C
		public static string smethod_1(string string_0, string string_1)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				if (string.IsNullOrEmpty(string_1))
				{
					throw new ArgumentNullException("sharedSecret");
				}
				RijndaelManaged rijndaelManaged = null;
				try
				{
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, Class7.byte_0);
					using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(string_0)))
					{
						rijndaelManaged = new RijndaelManaged();
						rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
						rijndaelManaged.IV = Class7.smethod_2(memoryStream);
						ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
						{
							using (StreamReader streamReader = new StreamReader(cryptoStream))
							{
								return streamReader.ReadToEnd();
							}
						}
					}
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						rijndaelManaged.Clear();
					}
				}
			}
			throw new ArgumentNullException("cipherText");
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00009228 File Offset: 0x00007428
		private static byte[] smethod_2(Stream stream_0)
		{
			byte[] array = new byte[4];
			if (stream_0.Read(array, 0, array.Length) != array.Length)
			{
				throw new SystemException("Stream did not contain properly formatted byte array");
			}
			byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
			if (stream_0.Read(array2, 0, array2.Length) != array2.Length)
			{
				throw new SystemException("Did not read byte array properly");
			}
			return array2;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00009280 File Offset: 0x00007480
		public static ulong smethod_3(string string_0)
		{
			return ulong.Parse(Class7.smethod_1(string_0, "zqingay"));
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00009292 File Offset: 0x00007492
		internal static bool smethod_4()
		{
			return Class7.object_0 == null;
		}

		// Token: 0x04000117 RID: 279
		private static byte[] byte_0 = Encoding.ASCII.GetBytes("Add a app specific salt here");

		// Token: 0x04000118 RID: 280
		internal static object object_0;
	}
}
