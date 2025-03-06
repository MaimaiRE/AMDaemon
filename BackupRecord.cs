using System;

namespace AMDaemon
{
	public sealed class BackupRecord
	{
		public object Data { get; private set; }

		public BackupDevice Device { get; private set; }

		public BackupRecord(object data, BackupDevice device)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			Type type = data.GetType();
			if (!type.IsClass)
			{
				throw new ArgumentException("The type of `data` is not class.", "data");
			}
			if (!type.IsLayoutSequential && !type.IsExplicitLayout)
			{
				throw new ArgumentException("StructLayoutAttribute of `data` is not valid.", "data");
			}
			Data = data;
			Device = device;
		}
	}
}
