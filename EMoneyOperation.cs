using System;
using System.Threading;
using Logger = AMDaemon.Debug.Logger;
namespace AMDaemon
{
	public sealed class EMoneyOperation
	{
		//public static readonly int MaxItemIdLength = Api.MaxEMoneyItemIdLength_get();

		//public static readonly uint MaxAmountCount = Api.MaxEMoneyAmountCount_get();

		//private Func<EMoneyResult, bool> payAmountHook;

		//private int payAmountHookCheckLock;

		//private IntPtr Pointer { get; set; }

		public bool IsDealAvailable => true; // Api.EMoneyOperation_isDealAvailable(Pointer);

		public bool CanOperateDeal => true; // Api.EMoneyOperation_canOperateDeal(Pointer);

		public bool IsBusy => false; // Api.EMoneyOperation_isBusy(Pointer);

		public bool IsCancellable => true; // Api.EMoneyOperation_isCancellable(Pointer);

		public bool IsHeldOver => false; // Api.EMoneyOperation_isHeldOver(Pointer);

		public bool IsErrorOccurred => false; // Api.EMoneyOperation_isErrorOccurred(Pointer);

		public bool HasResult => true; // Api.EMoneyOperation_hasResult(Pointer);

		public EMoneyResult Result { get; private set; }

		//private Func<EMoneyResult, bool> PayAmountHook
		//{
		//	get
		//	{
		//		return payAmountHook;
		//	}
		//	set
		//	{
		//		bool flag = payAmountHook != null;
		//		payAmountHook = value;
		//		bool flag2 = payAmountHook != null;
		//		if (flag != flag2)
		//		{
		//			if (flag2)
		//			{
		//				Core.PreExecute += CheckPayAmountHook;
		//			}
		//			else
		//			{
		//				Core.PreExecute -= CheckPayAmountHook;
		//			}
		//		}
		//	}
		//}

		//internal EMoneyOperation(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	Result = new EMoneyResult(Api.EMoneyOperation_getResult(pointer));
		//}

		public bool Cancel()
		{
			// return Api.Call(Pointer, Api.EMoneyOperation_cancel);
			Logger.Trace();
			return true;
		}

		public bool CheckDisplay()
		{
            // return Api.Call(Pointer, Api.EMoneyOperation_checkDisplay);
            Logger.Trace();
            return true;
        }

		public bool AuthTerminal()
		{
            //return Api.Call(Pointer, Api.EMoneyOperation_authTerminal);
            Logger.Trace();
            return true;
        }

		public bool RemoveTerminal()
		{
            //return Api.Call(Pointer, Api.EMoneyOperation_removeTerminal);
            Logger.Trace();
            return true;
        }

		public bool RequestBalance(EMoneyBrandId brandId)
		{
			//return Api.Call(Pointer, brandId, Api.EMoneyOperation_requestBalance);
			Logger.Trace($"{brandId}");
            return true;
        }

		public bool PayToCoin(int playerIndex, EMoneyBrandId brandId, uint coin)
		{
            // return Api.Call(() => Api.EMoneyOperation_payToCoin(Pointer, playerIndex, brandId, coin));
            Logger.Trace($"{playerIndex} {brandId} {coin}");
            return true;
        }

		//public bool CanAddCoin(int playerIndex, uint coin)
		//{
		//	return Api.Call(() => Api.EMoneyOperation_canAddCoin(Pointer, playerIndex, coin));
		//}

		//public bool PayAmount(EMoneyBrandId brandId, string itemId, int amount, uint count, Func<EMoneyResult, bool> hook)
		//{
		//	bool flag = Api.Call(() => Api.EMoneyOperation_payAmount(Pointer, brandId, itemId, amount, count, hook != null));
		//	if (flag)
		//	{
		//		PayAmountHook = hook;
		//	}
		//	return flag;
		//}

		//public bool PayAmount(EMoneyBrandId brandId, string itemId, int amount, uint count)
		//{
		//	return PayAmount(brandId, itemId, amount, count, null);
		//}

		//public bool PayAmount(EMoneyBrandId brandId, string itemId, int amount)
		//{
		//	return PayAmount(brandId, itemId, amount, 1u);
		//}

		//private void CheckPayAmountHook()
		//{
		//	if (Interlocked.Exchange(ref payAmountHookCheckLock, 1) != 0)
		//	{
		//		return;
		//	}
		//	try
		//	{
		//		if (Api.EMoneyOperation_payAmount_check())
		//		{
		//			if (PayAmountHook(Result))
		//			{
		//				PayAmountHook = null;
		//				Api.EMoneyOperation_payAmount_done();
		//			}
		//		}
		//		else if (!IsBusy)
		//		{
		//			PayAmountHook = null;
		//		}
		//	}
		//	finally
		//	{
		//		payAmountHookCheckLock = 0;
		//	}
		//}
	}
}
