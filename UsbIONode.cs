using System;

namespace AMDaemon
{
	public sealed class UsbIONode
	{
		public UsbIOSwitchInput SwitchInput { get; private set; }

		public UsbIOAnalogInput AnalogInput { get; private set; }

		public UsbIORotaryInput RotaryInput { get; private set; }

		public UsbIOUniqueInput UniqueInput { get; private set; }

		public UsbIOGeneralOutput GeneralOutput { get; private set; }

		public UsbIOPwmOutput PwmOutput { get; private set; }

		public UsbIOUniqueOutput UniqueOutput { get; private set; }

		//internal UsbIONode(IntPtr pointer)
		//{
		//	SwitchInput = new UsbIOSwitchInput(Api.Call(pointer, Api.UsbIONode_getSwitchInput));
		//	AnalogInput = new UsbIOAnalogInput(Api.Call(pointer, Api.UsbIONode_getAnalogInput));
		//	RotaryInput = new UsbIORotaryInput(Api.Call(pointer, Api.UsbIONode_getRotaryInput));
		//	UniqueInput = new UsbIOUniqueInput(Api.Call(pointer, Api.UsbIONode_getUniqueInput));
		//	GeneralOutput = new UsbIOGeneralOutput(Api.Call(pointer, Api.UsbIONode_getGeneralOutput));
		//	PwmOutput = new UsbIOPwmOutput(Api.Call(pointer, Api.UsbIONode_getPwmOutput));
		//	UniqueOutput = new UsbIOUniqueOutput(Api.Call(pointer, Api.UsbIONode_getUniqueOutput));
		//}
	}
}
