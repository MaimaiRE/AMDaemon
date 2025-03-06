using System;
using System.Runtime.CompilerServices;
using AMDaemon.Allnet;

namespace AMDaemon
{
	public abstract class PlayParamHolder
	{
		internal struct AccountingInfo
		{
			public bool IsValid
			{
				
				get;
				set; }

			public int KindCode
			{
				
				get;
				set; }

			public int StatusCode
			{
				
				get;
				set; }

			public int ItemCount
			{
				
				get;
				set; }
		}

		internal int GameCostIndex { get; private set; }

		internal int GameCostCount { get; private set; }

		internal AccountingInfo AccountingBegin { get; private set; }

		internal AccountingInfo AccountingEnd { get; private set; }

		internal AimeId AimeId { get; private set; }

		internal bool IsCancel { get; private set; }

		public PlayParamHolder()
		{
			Reset();
		}

		public void Reset()
		{
			GameCostIndex = -1;
			AccountingBegin = new AccountingInfo
			{
				IsValid = false
			};
			AccountingEnd = new AccountingInfo
			{
				IsValid = false
			};
			AimeId = AimeId.Invalid;
			IsCancel = false;
		}

		protected internal void SetGameCostImpl(int gameCostIndex, int count)
		{
			//if (gameCostIndex < 0 || gameCostIndex >= CreditConfig.MaxGameCostCount)
			//{
			//	throw new ArgumentOutOfRangeException("gameCostIndex");
			//}
			//if (count <= 0 || count > 99)
			//{
			//	throw new ArgumentOutOfRangeException("count");
			//}
			GameCostIndex = gameCostIndex;
			GameCostCount = count;
		}

		protected internal void SetAccountingBeginImpl(int kindCode, int statusCode)
		{
			//if (kindCode < 0 || kindCode > AccountingUnit.KindCodeLimit)
			//{
			//	throw new ArgumentOutOfRangeException("kindCode");
			//}
			//if (statusCode < 0 || statusCode > AccountingUnit.StatusCodeLimit)
			//{
			//	throw new ArgumentOutOfRangeException("statusCode");
			//}
			AccountingBegin = new AccountingInfo
			{
				IsValid = true,
				KindCode = kindCode,
				StatusCode = statusCode
			};
		}

		protected internal void SetAccountingEndImpl(int kindCode, int statusCode, int itemCount)
		{
			//if (kindCode < 0 || kindCode > AccountingUnit.KindCodeLimit)
			//{
			//	throw new ArgumentOutOfRangeException("kindCode");
			//}
			//if (statusCode < 0 || statusCode > AccountingUnit.StatusCodeLimit)
			//{
			//	throw new ArgumentOutOfRangeException("statusCode");
			//}
			//if (itemCount < 0 || itemCount > AccountingUnit.ItemCountLimit)
			//{
			//	throw new ArgumentOutOfRangeException("itemCount");
			//}
			AccountingEnd = new AccountingInfo
			{
				IsValid = true,
				KindCode = kindCode,
				StatusCode = statusCode,
				ItemCount = itemCount
			};
		}

		protected internal void SetAimeIdImpl(AimeId aimeId)
		{
			if (!aimeId.IsValid)
			{
				throw new ArgumentException("`aimeId` is invalid value.", "aimeId");
			}
			AimeId = aimeId;
		}

		protected internal void SetCancelImpl()
		{
			IsCancel = true;
		}
	}
}
