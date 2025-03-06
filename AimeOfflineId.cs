using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	[Serializable]
	public struct AimeOfflineId // : IEquatable<AimeOfflineId>, IComparable<AimeOfflineId>
	{
		public static readonly int Size = 16; // Api.AimeOfflineId_Size_get();

		public static readonly AimeOfflineId Zero = MakeZero();

		internal byte[] Values
		{
			
			get;
			private set; }

		internal byte[] ValuesRef => Values ?? Zero.Values;

		public bool IsValid => true; // Api.Call(ValuesRef, (byte[] values) => Api.AimeOfflineId_valid(values, values.Length));

		public AimeOfflineIdType Type => AimeOfflineIdType.None;  // Api.Call(ValuesRef, (byte[] values) => Api.AimeOfflineId_getType(values, values.Length));


        internal static AimeOfflineId MakeZero()
		{
			return new AimeOfflineId(new byte[Size], true);
		}

		//public static AimeOfflineId Make(AccessCode accessCode)
		//{
		//	AimeOfflineId result = MakeZero();
		//	Api.CallAction(accessCode.ValuesRef, result.Values, delegate(byte[] src, byte[] dest)
		//	{
		//		Api.AimeOfflineId_make_AccessCode(src, src.Length, dest, dest.Length);
		//	});
		//	return result;
		//}

		//public static AimeOfflineId Make(FeliCaId feliCaId)
		//{
		//	AimeOfflineId result = MakeZero();
		//	Api.CallAction(feliCaId.ValuesRef, result.Values, delegate(byte[] src, byte[] dest)
		//	{
		//		Api.AimeOfflineId_make_FeliCaId(src, src.Length, dest, dest.Length);
		//	});
		//	return result;
		//}

		public AimeOfflineId(byte[] values)
			: this(values, false)
		{
		}

		private AimeOfflineId(byte[] values, bool directly)
		{
			this = default(AimeOfflineId);
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

		public byte[] GetValues()
		{
			return (byte[])ValuesRef.Clone();
		}

		public AccessCode GetAccessCodeData()
		{
			AccessCode result = AccessCode.MakeZero();
			//Api.CallAction(ValuesRef, result.Values, delegate(byte[] src, byte[] dest)
			//{
			//	Api.AimeOfflineId_getData_accessCode_get(src, src.Length, dest, dest.Length);
			//});
			return result;
		}

		public FeliCaId GetFeliCaIdData()
		{
			FeliCaId result = FeliCaId.MakeZero();
			//Api.CallAction(ValuesRef, result.Values, delegate(byte[] src, byte[] dest)
			//{
			//	Api.AimeOfflineId_getData_feliCaId_get(src, src.Length, dest, dest.Length);
			//});
			return result;
		}

		//public bool Equals(AimeOfflineId other)
		//{
		//	return EqualsImpl(ValuesRef, other.ValuesRef);
		//}

		//public int CompareTo(AimeOfflineId other)
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
		//	if (obj is AimeOfflineId)
		//	{
		//		return EqualsImpl(ValuesRef, ((AimeOfflineId)obj).ValuesRef);
		//	}
		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return InnerUtil.MakeHashCode(ValuesRef);
		//}

		//public override string ToString()
		//{
		//	return Marshal.PtrToStringUni(Api.Call(ValuesRef, (byte[] values) => Api.AimeOfflineId_toString(values, values.Length)));
		//}

		//public static bool operator ==(AimeOfflineId l, AimeOfflineId r)
		//{
		//	return EqualsImpl(l.ValuesRef, r.ValuesRef);
		//}

		//public static bool operator !=(AimeOfflineId l, AimeOfflineId r)
		//{
		//	return !EqualsImpl(l.ValuesRef, r.ValuesRef);
		//}

		//public static bool operator <(AimeOfflineId l, AimeOfflineId r)
		//{
		//	return LessImpl(l.ValuesRef, r.ValuesRef);
		//}

		//public static bool operator >(AimeOfflineId l, AimeOfflineId r)
		//{
		//	return LessImpl(r.ValuesRef, l.ValuesRef);
		//}

		//public static bool operator <=(AimeOfflineId l, AimeOfflineId r)
		//{
		//	return !LessImpl(r.ValuesRef, l.ValuesRef);
		//}

		//public static bool operator >=(AimeOfflineId l, AimeOfflineId r)
		//{
		//	return !LessImpl(l.ValuesRef, r.ValuesRef);
		//}

		//private static bool EqualsImpl(byte[] valuesL, byte[] valuesR)
		//{
		//	return Api.Call(valuesL, valuesR, (byte[] l, byte[] r) => Api.AimeOfflineId_operator_equals(l, l.Length, r, r.Length));
		//}

		//private static bool LessImpl(byte[] valuesL, byte[] valuesR)
		//{
		//	return Api.Call(valuesL, valuesR, (byte[] l, byte[] r) => Api.AimeOfflineId_operator_less(l, l.Length, r, r.Length));
		//}
	}
}
