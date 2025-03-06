using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AMDaemon.Allnet
{
	[Serializable]
	public struct AccountingHandle : IEquatable<AccountingHandle>, IComparable<AccountingHandle>
	{
		public static readonly AccountingHandle Zero = new AccountingHandle(0u);

		public uint Value
		{
			
			get;
			private set; }

		public bool IsValid => Value != 0;

		public AccountingHandle(uint value)
		{
			this = default(AccountingHandle);
			Value = value;
		}

		public bool Equals(AccountingHandle other)
		{
			return Value.Equals(other.Value);
		}

		public int CompareTo(AccountingHandle other)
		{
			return Value.CompareTo(other.Value);
		}

		public override bool Equals(object obj)
		{
			if (obj is AccountingHandle)
			{
				return Equals((AccountingHandle)obj);
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

		public static bool operator ==(AccountingHandle l, AccountingHandle r)
		{
			return EqualityComparer<AccountingHandle>.Default.Equals(l, r);
		}

		public static bool operator !=(AccountingHandle l, AccountingHandle r)
		{
			return !(l == r);
		}

		public static bool operator <(AccountingHandle l, AccountingHandle r)
		{
			return l.CompareTo(r) < 0;
		}

		public static bool operator >(AccountingHandle l, AccountingHandle r)
		{
			return l.CompareTo(r) > 0;
		}

		public static bool operator <=(AccountingHandle l, AccountingHandle r)
		{
			return !(l > r);
		}

		public static bool operator >=(AccountingHandle l, AccountingHandle r)
		{
			return !(l < r);
		}
	}
}
