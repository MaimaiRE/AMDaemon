using System;
using System.Runtime.InteropServices;

using Logger = AMDaemon.Debug.Logger;
namespace AMDaemon
{
	public sealed class CreditUnit
	{
		private IntPtr Pointer { get; set; }

		public uint Credit => 1; // Api.Call(Pointer, Api.CreditUnit_getCredit);

		public uint Remain => 1; // Api.Call(Pointer, Api.CreditUnit_getRemain);

		public bool IsZero => false; // Api.Call(Pointer, Api.CreditUnit_isZero);

		public uint AddableCoin => 1; // Api.Call(Pointer, Api.CreditUnit_getAddableCoin);

		public uint CoinToCredit => 1; // Api.Call(Pointer, Api.CreditUnit_getCoinToCredit);

		public bool IsFreePlay => true; // Api.Call(Pointer, Api.CreditUnit_isFreePlay);

		public LazyCollection<uint> GameCosts { get; private set; }

		internal CreditUnit(IntPtr pointer)
		{
			Pointer = pointer;
			GameCosts = new LazyCollection<uint>(
				() => CreditConfig.MaxGameCostCount,
				(int index) => 1, // Stubbed value instead of: Api.Call(pointer, index, Api.CreditUnit_getGameCost)
				false
			);
		}

		//public override string ToString()
		//{
		//	return Marshal.PtrToStringUni(Api.Call(Pointer, Api.CreditUnit_toString));
		//}

		public bool IsGameCostEnough(int gameCostIndex)
		{
			return IsGameCostEnough(gameCostIndex, 1);
		}

		public bool IsGameCostEnough(int gameCostIndex, int count)
		{
			// return Api.Call(() => Api.CreditUnit_isGameCostEnough(Pointer, gameCostIndex, count));
			// Logger.Trace($"{gameCostIndex}, {count}");
			return true;
		}

		public bool PayGameCost(int gameCostIndex)
		{
			return PayGameCost(gameCostIndex, 1);
		}

		public bool PayGameCost(int gameCostIndex, int count)
		{
			// return Api.Call(() => Api.CreditUnit_payGameCost(Pointer, gameCostIndex, count));
			Logger.Trace($"{gameCostIndex}, {count}");
			return true;
		}
	}
}
