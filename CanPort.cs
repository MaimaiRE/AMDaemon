using System;

namespace AMDaemon
{
	public sealed class CanPort
	{
		public int TargetCount => Targets.Count;

		public LazyCollection<CanTarget> Targets { get; private set; }

		internal CanPort(IntPtr pointer)
		{
			//Targets = new LazyCollection<CanTarget>(() => Api.Call(pointer, Api.CanPort_getTargetCount), (int index) => new CanTarget(Api.Call(pointer, index, Api.CanPort_getTarget)), true);
		}
	}
}
