using System;

namespace AMDaemon
{
	public sealed class CreditBookkeeping
	{
		//public static readonly int CoinChuteCount = 0;
		private IntPtr Pointer { get; set; }

		public LazyCollection<uint> Coins { get; private set; }

		public uint TotalCoin => 0;
		public uint CoinCredit => 0;
		public uint ServiceCredit => 0;
		public uint EMoneyCoin => 0;
		public uint EMoneyCredit => 0;
		public uint TotalCredit => 0;
		//internal CreditBookkeeping(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	Coins = new LazyCollection<uint>(() => CoinChuteCount, (int index) => Api.Call(pointer, index, 0;		//}
	}
}
