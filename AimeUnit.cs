using System;
using System.Diagnostics;

namespace AMDaemon
{
	public sealed class AimeUnit
	{
		private IntPtr Pointer { get; set; }

		//public bool CanStart => Api.Call(Pointer, Api.AimeUnit_canStart);

		public bool IsBusy => false; // Api.Call(Pointer, Api.AimeUnit_isBusy);

		//public AimeCommand BusyCommand => Api.Call(Pointer, Api.AimeUnit_getBusyCommand);

		public bool HasConfirm => false;// Api.Call(Pointer, Api.AimeUnit_hasConfirm);

		public AimeConfirm Confirm => AimeConfirm.None;// Api.Call(Pointer, Api.AimeUnit_getConfirm);

		public bool HasResult => false; // Api.Call(Pointer, Api.AimeUnit_hasResult);

		public AimeResult Result { get; private set; }

		public bool HasError => false; // Api.Call(Pointer, Api.AimeUnit_hasError);

		public AimeErrorInfo ErrorInfo { get; private set; }

		//public AimeLedStatus LedStatus => Api.Call(Pointer, Api.AimeUnit_getLedStatus);

		internal AimeUnit(IntPtr pointer)
		{
			Pointer = pointer;
			Result = new AimeResult();
			ErrorInfo = new AimeErrorInfo(IntPtr.Zero);
		}

		public bool Start(AimeCommand command)
		{
			//return Api.Call(Pointer, command, Api.AimeUnit_start);
			return true;
		}

		public bool Cancel()
		{
			//return Api.Call(Pointer, Api.AimeUnit_cancel);
			return true;
		}

		public bool AcceptConfirm()
		{
			//return Api.Call(Pointer, Api.AimeUnit_acceptConfirm);
			return true;
		}

		public bool SetLedStatus(AimeLedStatus status)
		{
            // return Api.Call(Pointer, status, Api.AimeUnit_setLedStatus);
            Debug.Write($"SetLedStatus: status={status}");
            return true;

        }

		public bool SetLed(bool onR, bool onG, bool onB)
		{
			//return Api.Call(() => Api.AimeUnit_setLed(Pointer, onR, onG, onB));
			Debug.Write($"SetLed: onR={onR}, onG={onG}, onB={onB}");
            return true;
		}
	}
}
