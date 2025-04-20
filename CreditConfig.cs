using System;

namespace AMDaemon
{
	public sealed class CreditConfig
	{
		//public static readonly int MaxCoinChuteCount = Api.CreditConfig_MaxCoinChuteCount_get();

		public static readonly int MaxGameCostCount = 3;

		//private IntPtr Pointer { get; set; }

		//public bool IsCoinChuteCommon => Api.CreditConfig_coinChuteCommon_get(Pointer);

		//public bool IsServiceCommon => Api.CreditConfig_serviceCommon_get(Pointer);

		//public bool IsFreePlay => Api.CreditConfig_freePlay_get(Pointer);

		//public LazyCollection<uint> CoinMultipliers { get; private set; }

		//public uint BonusAdder => Api.CreditConfig_bonusAdder_get(Pointer);

		//public uint CoinToCredit => Api.CreditConfig_coinToCredit_get(Pointer);

		//public LazyCollection<uint> GameCosts { get; private set; }

		public uint CoinAmount => 100; // Api.CreditConfig_coinAmount_get(Pointer);

		public uint CoinToCredit => 1; // or 2 depending on how many coins make 1 credit

		//internal CreditConfig(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	CoinMultipliers = new LazyCollection<uint>(() => MaxCoinChuteCount, (int index) => Api.Call(pointer, index, Api.CreditConfig_coinMultipliers_get), false);
		//	GameCosts = new LazyCollection<uint>(() => MaxGameCostCount, (int index) => Api.Call(pointer, index, Api.CreditConfig_gameCosts_get), false);
		//}
	}
}
