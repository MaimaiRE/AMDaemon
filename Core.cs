using System;
using System.Runtime.InteropServices;
using MaimaiRE;
namespace AMDaemon
{
	public static class Core
	{
		internal delegate void ExecuteEventHandler();

		//public static string LibraryVersion => Marshal.PtrToStringUni(Api.Core_getLibraryVersion());

		public static bool IsReady => true;// Api.Core_isReady();

		//public static bool IsExited => Api.Core_isExited();

		//public static int PlayerCount => Api.Core_getPlayerCount();

		//public static Action<DaemonException> ExceptionHook { get; set; }

		//public static string Language => Marshal.PtrToStringUni(Api.Core_getLanguage());

		//public static RequestState LastPreloadState { get; private set; }

		//internal static event ExecuteEventHandler PreExecute;

		//internal static event ExecuteEventHandler PostExecute;

		//static Core()
		//{
		//	ExceptionHook = null;
		//}

		public static void Execute()
		{
			//Logger.Trace();
			//if (Core.PreExecute != null)
			//{
			//	Core.PreExecute();
			//}
			//Api.CallAction(Api.Core_execute);
			//if (Core.PostExecute != null)
			//{
			//	Core.PostExecute();
			//}		
				
		}

		public static void Kill()
		{
            Logger.Trace();
            // Kill(NextProcess.Auto);
        }

		public static void Kill(NextProcess nextProcess)
		{
            // Api.CallAction(nextProcess, Api.Core_kill);
            Logger.Trace($"{nextProcess}");
			Kill();
        }

		//public static bool ChangeLanguage(string language)
		//{
		//	return Api.Call(language, Api.Core_changeLanguage);
		//}

		public static void Reboot()
		{
			// Api.CallAction(Api.Core_reboot);
			Logger.Trace();
		}

		//public static bool PreloadDataSection()
		//{
		//	IntPtr intPtr = Api.Call(Api.Core_preloadDataSection);
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return false;
		//	}
		//	LastPreloadState = RequestState.ReplaceOrCreate(LastPreloadState, intPtr);
		//	return true;
		//}
	}
}
