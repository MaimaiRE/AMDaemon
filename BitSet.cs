using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AMDaemon
{
	[Serializable]
	public struct BitSet : IEnumerable<bool>, IEnumerable, IComparable<BitSet>, IEquatable<BitSet>
	{
		public const int MinBitCount = 0;

		public const int MaxBitCount = 64;

		private ulong _value;

		public ulong Value
		{
			get
			{
				return _value;
			}
			private set
			{
				if (BitCount > 0)
				{
					_value = value & (ulong.MaxValue >> 64 - BitCount);
				}
			}
		}

		public int BitCount
		{
			
			get;
			private set; }

		public bool this[int bitIndex]
		{
			get
			{
				if (bitIndex < 0 || bitIndex >= BitCount)
				{
					throw new ArgumentOutOfRangeException("bitIndex");
				}
				return GetBit(bitIndex);
			}
		}

		public BitSet(int bitCount)
			: this(bitCount, 0uL)
		{
		}

		public BitSet(int bitCount, ulong value)
		{
			this = default(BitSet);
			if (bitCount < 0 || bitCount > 64)
			{
				throw new ArgumentOutOfRangeException("bitCount");
			}
			BitCount = bitCount;
			Value = value;
		}

		public string ToString(char zero, char one)
		{
			if (BitCount == 0)
			{
				return "";
			}
			StringBuilder stringBuilder = new StringBuilder(BitCount);
			int num = BitCount;
			while (num > 0)
			{
				stringBuilder.Append(GetBit(--num) ? one : zero);
			}
			return stringBuilder.ToString();
		}

		public static BitSet operator ~(BitSet r)
		{
			r.Value = ~r.Value;
			return r;
		}

		public static BitSet operator &(BitSet l, BitSet r)
		{
			return new BitSet(Math.Max(l.BitCount, r.BitCount), l.Value & r.Value);
		}

		public static BitSet operator |(BitSet l, BitSet r)
		{
			return new BitSet(Math.Max(l.BitCount, r.BitCount), l.Value | r.Value);
		}

		public static BitSet operator ^(BitSet l, BitSet r)
		{
			return new BitSet(Math.Max(l.BitCount, r.BitCount), l.Value ^ r.Value);
		}

		public static BitSet operator <<(BitSet l, int r)
		{
			l.Value = ((r < l.BitCount) ? (l.Value << r) : 0);
			return l;
		}

		public static BitSet operator >>(BitSet l, int r)
		{
			l.Value = ((r < l.BitCount) ? (l.Value >> r) : 0);
			return l;
		}

		public static bool operator ==(BitSet l, BitSet r)
		{
			return l.Equals(r);
		}

		public static bool operator !=(BitSet l, BitSet r)
		{
			return !(l == r);
		}

		private bool GetBit(int bitIndex)
		{
			return (Value & (ulong)(1L << bitIndex)) != 0;
		}

		public override string ToString()
		{
			return ToString('0', '1');
		}

		public override bool Equals(object other)
		{
			if (other is BitSet)
			{
				return Equals((BitSet)other);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		public IEnumerator<bool> GetEnumerator()
		{
			int bi = 0;
			while (bi < BitCount)
			{
				yield return GetBit(bi);
				int num = bi + 1;
				bi = num;
			}
		}

		public int CompareTo(BitSet other)
		{
			return Value.CompareTo(other.Value);
		}

		public bool Equals(BitSet other)
		{
			return Value == other.Value;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
