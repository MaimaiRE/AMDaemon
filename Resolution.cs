using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AMDaemon
{
	[Serializable]
	public struct Resolution : IEquatable<Resolution>
	{
		public int Width
		{
			
			get;
			private set; }

		public int Height
		{
			
			get;
			private set; }

		internal Resolution(IntPtr pointer)
		{
			this = default(Resolution);
			//Width = Api.Resolution_width_get(pointer);
			//Height = Api.Resolution_height_get(pointer);
		}

		public bool Equals(Resolution other)
		{
			if (Width == other.Width)
			{
				return Height == other.Height;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			if (obj is Resolution)
			{
				return Equals((Resolution)obj);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Width + Height * 65536;
		}

		public override string ToString()
		{
			return Width + "x" + Height;
		}

		public static bool operator ==(Resolution l, Resolution r)
		{
			return EqualityComparer<Resolution>.Default.Equals(l, r);
		}

		public static bool operator !=(Resolution l, Resolution r)
		{
			return !(l == r);
		}
	}
}
