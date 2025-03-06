using System;
using System.Collections.Generic;

namespace AMDaemon
{
	[Serializable]
	public sealed class OutputId : IEquatable<OutputId>
	{
		//public static readonly int MaxValueLength = Api.OutputId_MaxSize_get() - 1;

		public string Value { get; private set; }

		public OutputId(string value)
		{
			//if (value == null)
			//{
			//	throw new ArgumentNullException("value");
			//}
			//if (value.Length > MaxValueLength)
			//{
			//	throw new ArgumentException("The length of `value` is too long.", "value");
			//}
			Value = value;
		}

		public bool Equals(OutputId other)
		{
			if (other != null)
			{
				return Value == other.Value;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as OutputId);
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		public override string ToString()
		{
			return Value;
		}

		public static bool operator ==(OutputId l, OutputId r)
		{
			return EqualityComparer<OutputId>.Default.Equals(l, r);
		}

		public static bool operator !=(OutputId l, OutputId r)
		{
			return !(l == r);
		}
	}
}
