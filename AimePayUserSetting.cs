using System;

namespace AMDaemon
{
	public class AimePayUserSetting
	{
		private IntPtr Pointer { get; set; }

		//public bool IsValid => Api.Call(Pointer, Api.AimePayUserSetting_valid);

		//public AimeId AimeId => new AimeId(Api.Call(Pointer, Api.AimePayUserSetting_getAimeId));

		//public bool IsCreditCardAvailable => Api.Call(Pointer, Api.AimePayUserSetting_isCreditCardAvailable);

		//public bool CanSkipAimeHold => Api.Call(Pointer, Api.AimePayUserSetting_canSkipAimeHold);

		internal AimePayUserSetting(IntPtr pointer)
		{
			Pointer = pointer;
		}
	}
}
