using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class SerialId // : IEquatable<SerialId>
	{
		private IntPtr Pointer { get; set; }

		public string Value { get; set; }// Marshal.PtrToStringUni(Api.SerialId_id_value(Pointer));

		public string ShortValue { get; set; }// Marshal.PtrToStringUni(Api.SerialId_shortId_value(Pointer));

		//public bool IsEmpty => Api.SerialId_empty(Pointer);

		internal SerialId(IntPtr pointer)
		{
			Pointer = pointer;
		}

		internal SerialId(string value)
		{
			Value = ShortValue = value;
		}

		//public bool Equals(SerialId other)
		//{
		//	if (other != null)
		//	{
		//		return Api.SerialId_operator_equals(Pointer, other.Pointer);
		//	}
		//	return false;
		//}

		//public string ToString(bool useShort)
		//{
		//	return Marshal.PtrToStringUni(Api.SerialId_toString(Pointer, useShort));
		//}

		//public override bool Equals(object obj)
		//{
		//	return Equals(obj as SerialId);
		//}

		//public override int GetHashCode()
		//{
		//	return (Value + ShortValue).GetHashCode();
		//}

		//public override string ToString()
		//{
		//	return ToString(false);
		//}

		//public static bool operator ==(SerialId l, SerialId r)
		//{
		//	return EqualityComparer<SerialId>.Default.Equals(l, r);
		//}

		//public static bool operator !=(SerialId l, SerialId r)
		//{
		//	return !(l == r);
		//}
	}
}
