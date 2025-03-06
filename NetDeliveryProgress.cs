using System;
using System.Runtime.CompilerServices;

namespace AMDaemon
{
	[Serializable]
	public struct NetDeliveryProgress : IEquatable<NetDeliveryProgress>
	{
		public int Total
		{
			
			get;
			private set; }

		public int Current
		{
			
			get;
			private set; }

		public float Percentage
		{
			
			get;
			private set; }

		internal NetDeliveryProgress(IntPtr pointer)
		{
			this = default(NetDeliveryProgress);
			//Total = Api.NetDeliveryProgress_total_get(pointer);
			//Current = Api.NetDeliveryProgress_current_get(pointer);
			//Percentage = Api.NetDeliveryProgress_toPercentage(pointer);
		}

		public bool Equals(NetDeliveryProgress other)
		{
			if (Total == other.Total)
			{
				return Current == other.Current;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			if (obj is NetDeliveryProgress)
			{
				return Equals((NetDeliveryProgress)obj);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Total * 65536 + Current;
		}

		public override string ToString()
		{
			return Current + "/" + Total;
		}

		public static bool operator ==(NetDeliveryProgress l, NetDeliveryProgress r)
		{
			return l.Equals(r);
		}

		public static bool operator !=(NetDeliveryProgress l, NetDeliveryProgress r)
		{
			return !(l == r);
		}
	}
}
