using System;
using System.Runtime.CompilerServices;

namespace AMDaemon
{
	public struct AnalogInput
	{
		public bool IsValid => Unit != null;

		public InputUnit Unit
		{
			
			get;
			private set; }

		public InputId Id
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

		//public double Value => Api.Call(ref this, delegate(ref AnalogInput self)
		//{
		//	return Api.AnalogInput_getValue(self.Unit.Pointer, self.Id.Value, self.MinValue, self.MaxValue);
		//});

		//public double Delta => Api.Call(ref this, delegate(ref AnalogInput self)
		//{
		//	return Api.AnalogInput_getDelta(self.Unit.Pointer, self.Id.Value, self.MinValue, self.MaxValue);
		//});

		public AnalogInput(InputUnit unit, InputId id, double minValue, double maxValue)
		{
			this = default(AnalogInput);
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

		public AnalogInput(InputUnit unit, InputId id, double maxValue)
			: this(unit, id, 0.0, maxValue)
		{
		}

		public AnalogInput(InputUnit unit, InputId id)
			: this(unit, id, 0.0, 1.0)
		{
		}
	}
}
