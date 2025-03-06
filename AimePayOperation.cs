using System;

namespace AMDaemon
{
	public class AimePayOperation
	{
		//public static readonly int CheckInPinCodeLength = Api.AimePayCheckInPinCodeLength_get();

		//public static readonly int MaxItemIdLength = Api.MaxAimePayItemIdLength_get();

		//public static readonly uint MaxAmountCount = Api.MaxAimePayAmountCount_get();

		//private IntPtr Pointer { get; set; }

		//public bool IsDealAvailable => Api.AimePayOperation_isDealAvailable(Pointer);

		//public bool CanOperateDeal => Api.AimePayOperation_canOperateDeal(Pointer);

		//public bool IsBusy => Api.AimePayOperation_isBusy(Pointer);

		//public bool IsCancellable => Api.AimePayOperation_isCancellable(Pointer);

		//public bool HasConfirm => Api.AimePayOperation_hasConfirm(Pointer);

		//public AimePayConfirm Confirm => Api.AimePayOperation_getConfirm(Pointer);

		//public bool IsErrorOccurred => Api.AimePayOperation_isErrorOccurred(Pointer);

		//public AimePayUserSetting UserSetting { get; private set; }

		//public bool HasDealResult => Api.AimePayOperation_hasDealResult(Pointer);

		//public AimePayDealResult DealResult { get; private set; }

		//internal AimePayOperation(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	DealResult = new AimePayDealResult(Api.AimePayOperation_getDealResult(pointer));
		//}

		//public bool Cancel()
		//{
		//	return Api.Call(Pointer, Api.AimePayOperation_cancel);
		//}

		//public bool AcceptConfirm(string param)
		//{
		//	return Api.Call(Pointer, param, Api.AimePayOperation_acceptConfirm);
		//}

		//public bool AcceptConfirm()
		//{
		//	return AcceptConfirm(null);
		//}

		//public bool CheckDisplay()
		//{
		//	return Api.Call(Pointer, Api.AimePayOperation_checkDisplay);
		//}

		//public bool Activate()
		//{
		//	return Api.Call(Pointer, Api.AimePayOperation_activate);
		//}

		//public bool Deactivate()
		//{
		//	return Api.Call(Pointer, Api.AimePayOperation_deactivate);
		//}

		//public bool RequestUserSetting(AimeId aimeId)
		//{
		//	return Api.Call(Pointer, aimeId.Value, Api.AimePayOperation_requestUserSetting);
		//}

		//public bool PayToCoin(int playerIndex, AimeId aimeId, AccessCode accessCode, uint coin)
		//{
		//	return Api.Call(accessCode.ValuesRef, (byte[] acValues) => Api.AimePayOperation_payToCoin(Pointer, playerIndex, aimeId.Value, acValues, acValues.Length, coin));
		//}

		//public bool CanAddCoin(int playerIndex, uint coin)
		//{
		//	return Api.Call(() => Api.AimePayOperation_canAddCoin(Pointer, playerIndex, coin));
		//}

		//public bool PayAmount(AimeId aimeId, AccessCode accessCode, string itemId, uint count, long optionNumber)
		//{
		//	return Api.Call(accessCode.ValuesRef, (byte[] acValues) => Api.AimePayOperation_payAmount(Pointer, aimeId.Value, acValues, acValues.Length, itemId, count, optionNumber));
		//}

		//public bool PayAmount(AimeId aimeId, AccessCode accessCode, string itemId, uint count)
		//{
		//	return PayAmount(aimeId, accessCode, itemId, count, 0L);
		//}

		//public bool PayAmount(AimeId aimeId, AccessCode accessCode, string itemId)
		//{
		//	return PayAmount(aimeId, accessCode, itemId, 1u);
		//}
	}
}
