using System;
using System.Collections.Generic;

namespace AMDaemon
{
	[Serializable]
	public sealed class InputId : IEquatable<InputId>
	{
		public static readonly int MaxValueLength = 256;// Api.InputId_MaxSize_get() - 1;

		public string Value { get; private set; }

		public InputId(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length > MaxValueLength)
			{
				throw new ArgumentException("The length of `value` is too long.", "value");
			}
			Value = value;
		}

		public bool Equals(InputId other)
		{
			if (other != null)
			{
				return Value == other.Value;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as InputId);
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		public override string ToString()
		{
			return Value;
		}

		public static bool operator ==(InputId l, InputId r)
		{
			return EqualityComparer<InputId>.Default.Equals(l, r);
		}

		public static bool operator !=(InputId l, InputId r)
		{
			return !(l == r);
		}
	}
}
