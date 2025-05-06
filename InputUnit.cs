using System;

namespace AMDaemon
{
	public sealed class InputUnit
	{
		internal IntPtr Pointer { get; private set; }

		public InputUnit(IntPtr pointer)
		{
			Pointer = pointer;
		}

		//public bool IsExists(InputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.InputUnit_exists);
		//}

		//public long GetValue(InputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.InputUnit_getValue);
		//}

		//public long GetDelta(InputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.InputUnit_getDelta);
		//}

		//public long GetMinValue(InputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.InputUnit_getMinValue);
		//}

		//public long GetMaxValue(InputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.InputUnit_getMaxValue);
		//}

		//public long GetDirectValue(InputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.InputUnit_getDirectValue);
		//}

		public long GetDirectValue(InputId id)
		{
			// Log what would've been called and return a dummy value
			AMDebugger.Trace($"[Mock] GetDirectValue({id.Value})");
			return 0; // or any fake long value
		}

		public AnalogInput GetAnalog(InputId id, double minValue, double maxValue)
		{
			return new AnalogInput(this, id, minValue, maxValue);
		}



		//public int GetSwitchFlipDelta(InputId id, bool toOn)
		//{
		//	return Api.Call(() => Api.InputUnit_getSwitchFlipDelta(Pointer, id.Value, toOn));
		//}

		public SwitchInput GetSwitch(InputId id)
		{
			return new SwitchInput(this, id);
		}

		//public AnalogInput GetAnalog(InputId id, double minValue, double maxValue)
		//{
		//	return new AnalogInput(this, id, minValue, maxValue);
		//}

		//public AnalogInput GetAnalog(InputId id, double maxValue)
		//{
		//	return new AnalogInput(this, id, maxValue);
		//}

		//public AnalogInput GetAnalog(InputId id)
		//{
		//	return new AnalogInput(this, id);
		//}
	}
}
