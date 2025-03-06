using System;

namespace AMDaemon
{
	public sealed class OutputUnit
	{
		internal IntPtr Pointer { get; private set; }

		internal OutputUnit(IntPtr pointer)
		{
			Pointer = pointer;
		}

		//public bool IsExists(OutputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.OutputUnit_exists);
		//}

		//public void SetValue(OutputId id, long value, bool forceUpdate)
		//{
		//	Api.CallAction(delegate
		//	{
		//		Api.OutputUnit_setValue(Pointer, id.Value, value, forceUpdate);
		//	});
		//}

		//public void SetValue(OutputId id, long value)
		//{
		//	SetValue(id, value, false);
		//}

		//public long GetCurrentValue(OutputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.OutputUnit_getCurrentValue);
		//}

		//public long GetMinValue(OutputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.OutputUnit_getMinValue);
		//}

		//public long GetMaxValue(OutputId id)
		//{
		//	return Api.Call(Pointer, id.Value, Api.OutputUnit_getMaxValue);
		//}

		public SwitchOutput GetSwitch(OutputId id)
		{
			return new SwitchOutput(this, id);
		}

		//public AnalogOutput GetAnalog(OutputId id, double minValue, double maxValue)
		//{
		//	return new AnalogOutput(this, id, minValue, maxValue);
		//}

		//public AnalogOutput GetAnalog(OutputId id, double maxValue)
		//{
		//	return new AnalogOutput(this, id, maxValue);
		//}

		//public AnalogOutput GetAnalog(OutputId id)
		//{
		//	return new AnalogOutput(this, id);
		//}
	}
}
