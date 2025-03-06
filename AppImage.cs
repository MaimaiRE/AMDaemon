using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public static class AppImage
	{
		public static Version CurrentVersion => new Version(0);

		//public static DateTime CreationTime => InnerUtil.MakeDateTime(Api.AppImage_getCreationTime(), DateTimeKind.Local);

		public static int OptionCount => OptionInfos.Count;

		public static LazyCollection<OptionImageInfo> OptionInfos { get; private set; }

		public static string OptionMountRootPath => "TODO";// Marshal.PtrToStringUni(Api.AppImage_getOptionMountRootPath());

		static AppImage()
		{
			OptionInfos = new LazyCollection<OptionImageInfo>(() => 9, (int index) => new OptionImageInfo(IntPtr.Zero));
		}

		public static OptionImageInfo FindOptionInfo(string optionName)
		{
			foreach (OptionImageInfo optionInfo in OptionInfos)
			{
				if (optionInfo.Name == optionName)
				{
					return optionInfo;
				}
			}
			return null;
		}

		//public static bool ExistsOption(string optionName)
		//{
		//	return Api.Call(optionName, Api.AppImage_existsOption);
		//}

		//public static string MakeOptionMountPath(string optionName)
		//{
		//	return Marshal.PtrToStringUni(Api.Call(optionName, Api.AppImage_makeOptionMountPath));
		//}
	}
}
