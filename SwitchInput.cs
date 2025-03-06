using System;
using System.Runtime.CompilerServices;

namespace AMDaemon
{
	public struct SwitchInput
	{
		public bool IsValid => Unit != null;

		public InputUnit Unit
		{

			get;
			private set;
		}

		public InputId Id
		{

			get;
			private set;
		}

		public bool IsOn => false;

		public bool IsFlipNow => false;

		public bool IsOnNow => false;
		public bool IsOffNow => false;

		public bool HasFlipNow => false;

		public bool HasOnNow => true;

		public bool HasOffNow => true;

		public SwitchInput(InputUnit unit, InputId id)
		{
			this = default(SwitchInput);
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

		//public int GetFlipDelta(bool toOn)
		//{
		//	return Api.Call(ref this, delegate(ref SwitchInput self)
		//	{
		//		return Api.SwitchInput_getFlipDelta(self.Unit.Pointer, self.Id.Value, toOn);
		//	});
		//}
	}
}
