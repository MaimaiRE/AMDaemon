using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	[Serializable]
	public struct AccessCode// : IEquatable<AccessCode>, IComparable<AccessCode>
	{
		public static readonly int DigitCount;

		public static readonly int Size;

		public static readonly AccessCode Zero;

		public static readonly AccessCode Invalid;

		internal byte[] Values
		{
			
			get;
			private set; }

		internal byte[] ValuesRef => Values ?? Zero.Values;

		public bool IsValid
		{
			get
			{
				//byte[] valuesRef = ValuesRef;
				//return Api.Call(valuesRef, valuesRef.Length, Api.AccessCode_valid);
				return true;
			}
		}

		static AccessCode()
		{
			//DigitCount = Api.AccessCode_DigitCount_get();
			//Size = Api.AccessCode_Size_get();
			//Zero = MakeZero();
			//Invalid = MakeZero();
			//Api.CallAction(Invalid.Values, delegate(byte[] values)
			//{
			//	Api.AccessCode_makeInvalid(values, values.Length);
			//});
		}

		internal static AccessCode MakeZero()
		{
			return new AccessCode(new byte[Size], true);
		}

		public static bool CanMake(string src, string separator)
		{
			return true; // Api.AccessCode_canMake(src, separator);
		}

		public static bool CanMake(string src)
		{
			return CanMake(src, null);
		}

		public static AccessCode Make(string src, string separator)
		{
			AccessCode result = MakeZero();
			//Api.CallAction(result.Values, delegate(byte[] values)
			//{
			//	Api.AccessCode_make(src, separator, values, values.Length);
			//});
			return result;
		}

		public static AccessCode Make(string src)
		{
			return Make(src, null);
		}

		public AccessCode(byte[] values)
			: this(values, false)
		{
		}

		private AccessCode(byte[] values, bool directly)
		{
			this = default(AccessCode);
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

		//public int GetDigit(int digitIndex)
		//{
		//	return Api.Call(ValuesRef, (byte[] values) => Api.AccessCode_getDigit(values, values.Length, digitIndex));
		//}

		//public bool Equals(AccessCode other)
		//{
		//	return EqualsImpl(ValuesRef, other.ValuesRef);
		//}

		//public int CompareTo(AccessCode other)
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

		//public string ToString(string separator)
		//{
		//	return Marshal.PtrToStringUni(Api.Call(ValuesRef, separator, (byte[] values, string s) => Api.AccessCode_toString(values, values.Length, s)));
		//}

		//public override bool Equals(object obj)
		//{
		//	if (obj is AccessCode)
		//	{
		//		return EqualsImpl(ValuesRef, ((AccessCode)obj).ValuesRef);
		//	}
		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return InnerUtil.MakeHashCode(ValuesRef);
		//}

		//public override string ToString()
		//{
		//	return ToString(null);
		//}

		//public static bool operator ==(AccessCode l, AccessCode r)
		//{
		//	return EqualsImpl(l.ValuesRef, r.ValuesRef);
		//}

		//public static bool operator !=(AccessCode l, AccessCode r)
		//{
		//	return !EqualsImpl(l.ValuesRef, r.ValuesRef);
		//}

		//public static bool operator <(AccessCode l, AccessCode r)
		//{
		//	return LessImpl(l.ValuesRef, r.ValuesRef);
		//}

		//public static bool operator >(AccessCode l, AccessCode r)
		//{
		//	return LessImpl(r.ValuesRef, l.ValuesRef);
		//}

		//public static bool operator <=(AccessCode l, AccessCode r)
		//{
		//	return !LessImpl(r.ValuesRef, l.ValuesRef);
		//}

		//public static bool operator >=(AccessCode l, AccessCode r)
		//{
		//	return !LessImpl(l.ValuesRef, r.ValuesRef);
		//}

		//private static bool EqualsImpl(byte[] valuesL, byte[] valuesR)
		//{
		//	return Api.Call(valuesL, valuesR, (byte[] l, byte[] r) => Api.AccessCode_operator_equals(l, l.Length, r, r.Length));
		//}

		//private static bool LessImpl(byte[] valuesL, byte[] valuesR)
		//{
		//	return Api.Call(valuesL, valuesR, (byte[] l, byte[] r) => Api.AccessCode_operator_less(l, l.Length, r, r.Length));
		//}
	}
}
