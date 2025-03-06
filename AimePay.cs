namespace AMDaemon
{
	public static class AimePay
	{
		public static readonly int MaxDealResultCount;

		public static readonly int MaxDealSummaryCount;

		//public static bool IsAvailable => Api.AimePay_isAvailable();

		//public static bool IsActivated => Api.AimePay_isActivated();

		public static AimePayLocationInfo ActivatedLocationInfo { get; private set; }

		public static AimePayLocationInfo CurrentLocationInfo { get; private set; }

		public static AimePayOperation Operation { get; private set; }

		public static int DealResultCount => DealResults.Count;

		public static LazyCollection<AimePayDealResult> DealResults { get; private set; }

		public static int DealSummaryCount => DealSummaries.Count;

		public static LazyCollection<AimePayDealSummary> DealSummaries { get; private set; }

		static AimePay()
		{
			//MaxDealResultCount = Api.MaxAimePayDealResultCount_get();
			//MaxDealSummaryCount = Api.MaxAimePayDealSummaryCount_get();
			//ActivatedLocationInfo = new AimePayLocationInfo(Api.AimePay_getActivatedLocationInfo());
			//CurrentLocationInfo = new AimePayLocationInfo(Api.AimePay_getCurrentLocationInfo());
			//Operation = new AimePayOperation(Api.AimePay_getOperation());
			//DealResults = new LazyCollection<AimePayDealResult>(Api.AimePay_getDealResultCount, (int index) => new AimePayDealResult(Api.Call(index, Api.AimePay_getDealResult)), true);
			//DealSummaries = new LazyCollection<AimePayDealSummary>(Api.AimePay_getDealSummaryCount, (int index) => new AimePayDealSummary(Api.Call(index, Api.AimePay_getDealSummary)), true);
		}
	}
}
