namespace AMDaemon
{
	public sealed class PlayContinueParam : PlayParamHolder
	{
		public void SetGameCost(int gameCostIndex)
		{
			SetGameCost(gameCostIndex, 1);
		}

		public void SetGameCost(int gameCostIndex, int count)
		{
			SetGameCostImpl(gameCostIndex, count);
		}

		public void SetAccountingBegin(int kindCode, int statusCode)
		{
			SetAccountingBeginImpl(kindCode, statusCode);
		}

		public void SetAccountingEnd(int kindCode, int statusCode, int itemCount)
		{
			SetAccountingEndImpl(kindCode, statusCode, itemCount);
		}
	}
}
