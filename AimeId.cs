using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AMDaemon
{
	[Serializable]
	public struct AimeId : IEquatable<AimeId>, IComparable<AimeId>
	{
		public static readonly AimeId Zero = new AimeId(0u);

		public static readonly AimeId Invalid = new AimeId(0xffffffff);

		public uint Value
		{
			
			get;
			private set; }

		public bool IsValid => true; // Api.AimeId_valid(Value);

		public AimeId(uint value)
		{
			this = default(AimeId);
			Value = value;
		}

		public bool Equals(AimeId other)
		{
			return Value.Equals(other.Value);
		}

		public int CompareTo(AimeId other)
		{
			return Value.CompareTo(other.Value);
		}

		public override bool Equals(object obj)
		{
			if (obj is AimeId)
			{
				return Equals((AimeId)obj);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		public override string ToString()
		{
			return Value.ToString();
		}

		public static bool operator ==(AimeId l, AimeId r)
		{
			return EqualityComparer<AimeId>.Default.Equals(l, r);
		}

		public static bool operator !=(AimeId l, AimeId r)
		{
			return !(l == r);
		}

		public static bool operator <(AimeId l, AimeId r)
		{
			return l.CompareTo(r) < 0;
		}

		public static bool operator >(AimeId l, AimeId r)
		{
			return l.CompareTo(r) > 0;
		}

		public static bool operator <=(AimeId l, AimeId r)
		{
			return !(l > r);
		}

		public static bool operator >=(AimeId l, AimeId r)
		{
			return !(l < r);
		}
	}
}
