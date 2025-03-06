using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	[Serializable]
	public struct Version : IEquatable<Version>, IComparable<Version>
	{
		public static readonly uint MajorLimit = 0;

		public static readonly uint MinorLimit = 0;

		public static readonly uint PatchLimit = 0;

		public static readonly Version Zero = new Version(0u);

		public uint Value
		{
			
			get;
			private set; }

		public uint Major => 0;
							 
		public uint Minor => 0;
							 
		public uint Patch => 0;

		//public static bool CanMake(uint major, uint minor, uint patch)
		//{
		//	return Api.Version_canMake_fromParts(major, minor, patch);
		//}

		//public static Version Make(uint major, uint minor, uint patch)
		//{
		//	return new Version(Api.Call(() => Api.Version_make_fromParts(major, minor, patch)));
		//}

		//public static bool CanMake(string src)
		//{
		//	return Api.Version_canMake_fromString(src);
		//}

		//public static Version Make(string src)
		//{
		//	return new Version(Api.Call(src, Api.Version_make_fromString));
		//}

		internal Version(uint value)
		{
			this = default(Version);
			Value = value;
		}

		public bool Equals(Version other)
		{
			return Value == other.Value;
		}

		public int CompareTo(Version other)
		{
			return Value.CompareTo(other.Value);
		}

		//public string ToString(bool withoutPatch)
		//{
		//	return Marshal.PtrToStringUni(Api.Version_toString(Value, withoutPatch));
		//}

		public override bool Equals(object obj)
		{
			if (obj is Version)
			{
				return Equals((Version)obj);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		//public override string ToString()
		//{
		//	return ToString(false);
		//}

		public static bool operator ==(Version l, Version r)
		{
			return l.Value == r.Value;
		}

		public static bool operator !=(Version l, Version r)
		{
			return l.Value != r.Value;
		}

		public static bool operator <(Version l, Version r)
		{
			return l.Value < r.Value;
		}

		public static bool operator >(Version l, Version r)
		{
			return l.Value > r.Value;
		}

		public static bool operator <=(Version l, Version r)
		{
			return l.Value <= r.Value;
		}

		public static bool operator >=(Version l, Version r)
		{
			return l.Value >= r.Value;
		}
	}
}
