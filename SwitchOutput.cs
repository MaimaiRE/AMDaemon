using System;
using System.Runtime.CompilerServices;

namespace AMDaemon
{
	public struct SwitchOutput
	{
		public bool IsValid => Unit != null;

		public OutputUnit Unit
		{

			get;
			private set;
		}

		public OutputId Id
		{

			get;
			private set;
		}

		public SwitchOutput(OutputUnit unit, OutputId id)
		{
			this = default(SwitchOutput);
			//if (unit == null)
			//{
			//	throw new ArgumentNullException("unit");
			//}
			//if (id == null)
			//{
			//	throw new ArgumentNullException("id");
			//}
			Unit = unit;
			Id = id;
		}

		public void Set(int bitIndex, bool on, bool forceUpdate)
		{
			//Logger.Trace($"{bitIndex} {on} {forceUpdate}");
        }

		public void Set(int bitIndex, bool on)
		{
			Set(bitIndex, on, false);
		}

		//public void Reset(int bitIndex, bool forceUpdate)
		//{
		//	Api.CallAction(ref this, delegate(ref SwitchOutput self)
		//	{
		//		Api.SwitchOutput_reset(self.Unit.Pointer, self.Id.Value, bitIndex, forceUpdate);
		//	});
		//}

		//public void Reset(int bitIndex)
		//{
		//	Reset(bitIndex, false);
		//}

		//public bool IsCurrentOn(int bitIndex)
		//{
		//	return Api.Call(ref this, delegate(ref SwitchOutput self)
		//	{
		//		return Api.SwitchOutput_isCurrentOn(self.Unit.Pointer, self.Id.Value, bitIndex);
		//	});
		//}
	}
}
