
using System.Runtime.InteropServices;
using UnityEngine;
namespace AMDaemon.Abaas
{
	public static class Log
	{
		public static bool IsAvailable => true;

		//public static string RootPath => Marshal.PtrToStringUni(Api.abaas_Log_getRootPath());

		//public static bool IsServerAlive => Api.abaas_Log_isServerAlive();

		//public static bool IsUploading => Api.abaas_Log_isUploading();

		//public static int UploadingFileCount => Api.abaas_Log_getUploadingFileCount();

		public static bool PutErrorMessage(string message)
		{
			UnityEngine.Debug.LogError(message);
			return true;
		}
	}
}
