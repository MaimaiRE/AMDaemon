using System;
using System.Runtime.CompilerServices;

namespace AMDaemon
{
	public struct AnalogOutput
	{
		public bool IsValid => Unit != null;

		public OutputUnit Unit
		{
			
			get;
			private set; }

		public OutputId Id
		{
			
			get;
			private set; }

		public double MinValue
		{
			
			get;
			private set; }

		public double MaxValue
		{
			
			get;
			private set; }

		//public double CurrentValue => Api.Call(ref this, delegate(ref AnalogOutput self)
		//{
		//	return Api.AnalogOutput_getCurrentValue(self.Unit.Pointer, self.Id.Value, self.MinValue, self.MaxValue);
		//});

		public AnalogOutput(OutputUnit unit, OutputId id, double minValue, double maxValue)
		{
			this = default(AnalogOutput);
			if (unit == null)
			{
				throw new ArgumentNullException("unit");
			}
			if (id == null)
			{
				throw new ArgumentNullException("id");
			}
			Unit = unit;
			Id = id;
			MinValue = minValue;
			MaxValue = maxValue;
		}

		public AnalogOutput(OutputUnit unit, OutputId id, double maxValue)
			: this(unit, id, 0.0, maxValue)
		{
		}

		public AnalogOutput(OutputUnit unit, OutputId id)
			: this(unit, id, 0.0, 1.0)
		{
		}

		//public void SetValue(double value, bool forceUpdate)
		//{
		//	Api.CallAction(ref this, delegate(ref AnalogOutput self)
		//	{
		//		Api.AnalogOutput_setValue(self.Unit.Pointer, self.Id.Value, self.MinValue, self.MaxValue, value, forceUpdate);
		//	});
		//}

		//public void SetValue(double value)
		//{
		//	SetValue(value, false);
		//}
	}
}
