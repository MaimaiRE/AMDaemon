namespace AMDaemon
{
	public sealed class PlayEndParam : PlayParamHolder
	{
		public void SetAccountingBegin(int kindCode, int statusCode)
		{
			SetAccountingBeginImpl(kindCode, statusCode);
		}

		public void SetAccountingEnd(int kindCode, int statusCode, int itemCount)
		{
			SetAccountingEndImpl(kindCode, statusCode, itemCount);
		}

		public void SetCancel()
		{
			SetCancelImpl();
		}
	}
}
