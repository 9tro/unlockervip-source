using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000064 RID: 100
	public class json_wrapper
	{
		// Token: 0x060002FF RID: 767 RVA: 0x0000C633 File Offset: 0x0000A833
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000C650 File Offset: 0x0000A850
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		public object string_to_object(string json)
		{
			object result;
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(json)))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x040002EF RID: 751
		private DataContractJsonSerializer serializer;

		// Token: 0x040002F0 RID: 752
		private object current_object;
	}
}
