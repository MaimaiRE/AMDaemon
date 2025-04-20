using System;
using CardMakerRE;
namespace AMDaemon.Allnet
{
	public sealed class AccountingUnit
	{
		//public static readonly int KindCodeLimit = Api.allnet_AccountingUnit_getKindCodeLimit();

		//public static readonly int StatusCodeLimit = Api.allnet_AccountingUnit_getStatusCodeLimit();

		//public static readonly int ItemCountLimit = Api.allnet_AccountingUnit_getItemCountLimit();

		//public static readonly int QuantityLimit = Api.allnet_AccountingUnit_getQuantityLimit();

		//public static readonly int MaxGeneralIdLength = Api.allnet_AccountingUnit_getMaxGeneralIdLength();

		private IntPtr Pointer { get; set; }

		public bool CanBeginPlay => true; // Api.Call(Pointer, Api.allnet_AccountingUnit_canBeginPlay);

		internal AccountingUnit(IntPtr pointer)
		{
			Pointer = pointer;
		}

		public AccountingHandle BeginPlay(int kindCode, int statusCode)
		{
			//return new AccountingHandle(Api.Call(() => Api.allnet_AccountingUnit_beginPlay(Pointer, kindCode, statusCode)));
			Logger.Trace($"{kindCode} {statusCode}");
			return new AccountingHandle();
		}

		public bool EndPlay(AccountingHandle handle, int kindCode, int statusCode, int itemCount)
		{
			// return Api.Call(() => Api.allnet_AccountingUnit_endPlay(Pointer, handle.Value, kindCode, statusCode, itemCount));
			Logger.Trace($"{handle} {kindCode} {itemCount}");
			return true;
		}

		//public AccountingHandle ContinuePlay(AccountingHandle prevHandle, int prevKindCode, int prevStatusCode, int prevItemCount, int nextKindCode, int nextStatusCode)
		//{
		//	return new AccountingHandle(Api.Call(() => Api.allnet_AccountingUnit_continuePlay(Pointer, prevHandle.Value, prevKindCode, prevStatusCode, prevItemCount, nextKindCode, nextStatusCode)));
		//}

		public bool AccountItem(int kindCode, int statusCode, int itemCount)
		{
			Logger.Trace($"{kindCode} {statusCode} {itemCount}");
			return true;
		}

		public bool PutQuantity(int kindCode, int quantity)
		{
			// return Api.Call(() => Api.allnet_AccountingUnit_putQuantity(Pointer, kindCode, quantity));
			Logger.Trace($"{kindCode} {quantity}");
			return true;
		}

		public bool PutGeneralId(int kindCode, string generalId)
		{
            Logger.Trace($"{kindCode} {generalId}");
            return true;
        }
	}
}
