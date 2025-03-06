using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	[Serializable]
	public struct FeliCaId // : IEquatable<FeliCaId>, IComparable<FeliCaId>
	{
		public static readonly int Size = 16; // Api.FeliCaId_Size_get();

		public static readonly FeliCaId Zero = MakeZero();

		internal byte[] Values
		{

			get;
			private set;
		}

		internal byte[] ValuesRef => Values ?? Zero.Values;

		internal static FeliCaId MakeZero()
		{
			return new FeliCaId(new byte[Size], true);
		}

		public FeliCaId(byte[] values)
			: this(values, false)
		{
		}

		private FeliCaId(byte[] values, bool directly)
		{
			this = default(FeliCaId);
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length != Size)
			{
				throw new ArgumentException("The length of `values` is invalid.", "values");
			}
			Values = (directly ? values : ((byte[])values.Clone()));
		}

		//public byte[] GetValues()
		//{
		//	return (byte[])ValuesRef.Clone();
		//}

		//public bool Equals(FeliCaId other)
		//{
		//	return EqualsImpl(ValuesRef, other.ValuesRef);
		//}

		//public int CompareTo(FeliCaId other)
		//{
		//	if (LessImpl(ValuesRef, other.ValuesRef))
		//	{
		//		return -1;
		//	}
		//	if (LessImpl(other.ValuesRef, ValuesRef))
		//	{
		//		return 1;
		//	}
		//	return 0;
		//}

		//public override bool Equals(object obj)
		//{
		//	if (obj is FeliCaId)
		//	{
		//		return EqualsImpl(ValuesRef, ((FeliCaId)obj).ValuesRef);
		//	}
		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return InnerUtil.MakeHashCode(ValuesRef);
		//}

		//public override string ToString()
		//{
		//	return Marshal.PtrToStringUni(Api.Call(ValuesRef, (byte[] values) => Api.FeliCaId_toString(values, values.Length)));
		//}

		//public static bool operator ==(FeliCaId l, FeliCaId r)
		//{
		//	return EqualsImpl(l.ValuesRef, r.ValuesRef);
		//}

		//public static bool operator !=(FeliCaId l, FeliCaId r)
		//{
		//	return !EqualsImpl(l.ValuesRef, r.ValuesRef);
		//}

		//public static bool operator <(FeliCaId l, FeliCaId r)
		//{
		//	return LessImpl(l.ValuesRef, r.ValuesRef);
		//}

		//public static bool operator >(FeliCaId l, FeliCaId r)
		//{
		//	return LessImpl(r.ValuesRef, l.ValuesRef);
		//}

		//public static bool operator <=(FeliCaId l, FeliCaId r)
		//{
		//	return !LessImpl(r.ValuesRef, l.ValuesRef);
		//}

		//public static bool operator >=(FeliCaId l, FeliCaId r)
		//{
		//	return !LessImpl(l.ValuesRef, r.ValuesRef);
		//}

		//private static bool EqualsImpl(byte[] valuesL, byte[] valuesR)
		//{
		//	return Api.Call(valuesL, valuesR, (byte[] l, byte[] r) => Api.FeliCaId_operator_equals(l, l.Length, r, r.Length));
		//}

		//private static bool LessImpl(byte[] valuesL, byte[] valuesR)
		//{
		//	return Api.Call(valuesL, valuesR, (byte[] l, byte[] r) => Api.FeliCaId_operator_less(l, l.Length, r, r.Length));
		//}
	}
}
