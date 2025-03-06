using System;
namespace AMDaemon
{
	public static class Input
	{
		public static InputUnit System { get; private set; }

		public static int PlayerCount => Players.Count;

		public static LazyCollection<InputUnit> Players { get; private set; }

		static Input()
		{
			System = new InputUnit(IntPtr.Zero);
            Players = new LazyCollection<InputUnit>(()=>1, (int index) => new InputUnit(IntPtr.Zero));
		}
	}
}
