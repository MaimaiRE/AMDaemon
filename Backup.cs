using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
namespace AMDaemon
{
	public static class Backup
	{
		private class Record : IDisposable
		{
			public object Data { get; private set; }

			public IntPtr Buffer { get; private set; }

			public Api.BackupRecord Raw { get; private set; }

			public bool IsSaveRequested { get; set; }

			public Record(BackupRecord src)
			{
				int num = Marshal.SizeOf(src.Data);
				Data = src.Data;
				Buffer = Marshal.AllocCoTaskMem(num);
				Raw = new Api.BackupRecord
				{
					Address = Buffer,
					Size = new IntPtr(num),
					Device = src.Device
				};
				IsSaveRequested = false;
				Marshal.StructureToPtr(Data, Buffer, false);
			}

			~Record()
			{
				Dispose();
			}

			public void SyncToBuffer()
			{
				if (Buffer != IntPtr.Zero)
				{
					Marshal.StructureToPtr(Data, Buffer, true);
				}
			}

			public void SyncToData()
			{
				if (Buffer != IntPtr.Zero)
				{
					Marshal.PtrToStructure(Buffer, Data);
				}
			}

			public void Dispose()
			{
				if (Buffer != IntPtr.Zero)
				{
					Marshal.DestroyStructure(Buffer, Data.GetType());
					Marshal.FreeCoTaskMem(Buffer);
					Buffer = IntPtr.Zero;
				}
			}
		}

		public static readonly int MaxRecordCount;

		public static bool IsAsync
		{
			get
			{
				return true;
			}
			set
			{				
			}
		}

		public static bool IsBusy => false; // Api.Backup_isBusy();

		private static Record[] Records { get; set; }

		public static RequestState LastSetupState { get; private set; }

		private static bool IsSetupBusy { get; set; }

		//public static bool IsSetupSucceeded => Api.Backup_isSetupSucceeded();

		//public static int RecordCount => Api.Backup_getRecordCount();

		public static RequestState LastSaveState { get; private set; }

		static Backup()
		{
			//MaxRecordCount = Api.Backup_getMaxRecordCount();
			//Core.PreExecute += OnPreExecute;
			//Core.PostExecute += OnPostExecute;
		}

		public static bool SetupRecords(IEnumerable<BackupRecord> records, string gameId)
		{
			//if (records == null)
			//{
			//	throw new ArgumentNullException("records");
			//}
			//Record[] array = records.Select((BackupRecord r) => new Record(r)).ToArray();
			//try
			//{
			//	Api.BackupRecord[] apiRecs = Array.ConvertAll(array, (Record r) => r.Raw);
			//	IntPtr intPtr = Api.Call(() => Api.Backup_setupRecords(apiRecs, apiRecs.Length, gameId));
			//	if (intPtr == IntPtr.Zero)
			//	{
			//		return false;
			//	}
			//	Record[] records2 = Records;
			//	Records = array;
			//	array = records2;
			//	LastSetupState = RequestState.ReplaceOrCreate(LastSetupState, intPtr);
			//	IsSetupBusy = true;
			//}
			//finally
			//{
			//	if (array != null)
			//	{
			//		Record[] array2 = array;
			//		for (int i = 0; i < array2.Length; i++)
			//		{
			//			array2[i].Dispose();
			//		}
			//	}
			//}
			//return true;
			AMDebugger.Trace($"{records} {gameId}");
            return true;
        }

		public static bool SetupRecords(IEnumerable<BackupRecord> records)
		{
			return SetupRecords(records, null);
		}

		public static BackupRecordStatus GetRecordStatus(int recordIndex)
		{
			// return Api.Call(recordIndex, Api.Backup_getRecordStatus);
			AMDebugger.Trace($"{recordIndex}");
            return BackupRecordStatus.Valid;
        }

		//public static BackupRecordStatus GetRecordStatusByData(object data)
		//{
		//	IEnumerable<int> source = FindRecordIndicesByData(data);
		//	if (source.Take(2).Count() != 1)
		//	{
		//		return BackupRecordStatus.InvalidCall;
		//	}
		//	return GetRecordStatus(source.First());
		//}

		public static bool SaveRecord(int recordIndex)
		{
			//if (Records == null)
			//{
			//	return false;
			//}
			//IntPtr intPtr = Api.Call(recordIndex, Api.Backup_saveRecord);
			//if (intPtr == IntPtr.Zero)
			//{
			//	return false;
			//}
			//LastSaveState = RequestState.ReplaceOrCreate(LastSaveState, intPtr);
			//Records[recordIndex].IsSaveRequested = true;
			AMDebugger.Trace($"{recordIndex}");
			return true;
		}

		//public static bool SaveRecordByData(object data)
		//{
		//	IEnumerable<int> enumerable = FindRecordIndicesByData(data);
		//	if (!enumerable.Any())
		//	{
		//		return false;
		//	}
		//	bool flag = true;
		//	foreach (int item in enumerable)
		//	{
		//		flag |= SaveRecord(item);
		//	}
		//	return flag;
		//}

		//public static bool SaveAllRecords()
		//{
		//	if (Records == null)
		//	{
		//		return false;
		//	}
		//	IntPtr intPtr = Api.Call(Api.Backup_saveAllRecords);
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return false;
		//	}
		//	LastSaveState = RequestState.ReplaceOrCreate(LastSaveState, intPtr);
		//	Record[] records = Records;
		//	for (int i = 0; i < records.Length; i++)
		//	{
		//		records[i].IsSaveRequested = true;
		//	}
		//	return true;
		//}

		//public static bool ExecuteSave()
		//{
		//	try
		//	{
		//		OnPreExecute();
		//		return Api.Call(Api.Backup_executeSave);
		//	}
		//	finally
		//	{
		//		OnPostExecute();
		//	}
		//}

		//private static void OnPreExecute()
		//{
		//	if (Records == null)
		//	{
		//		return;
		//	}
		//	Record[] records = Records;
		//	Record[] array = records;
		//	foreach (Record record in array)
		//	{
		//		if (record.IsSaveRequested)
		//		{
		//			record.SyncToBuffer();
		//			record.IsSaveRequested = false;
		//		}
		//	}
		//}

		//private static void OnPostExecute()
		//{
		//	if (!IsSetupBusy || LastSetupState == null || !LastSetupState.IsDone)
		//	{
		//		return;
		//	}
		//	if (Records != null && LastSetupState.IsSucceeded)
		//	{
		//		Record[] records = Records;
		//		for (int i = 0; i < records.Length; i++)
		//		{
		//			records[i].SyncToData();
		//		}
		//	}
		//	IsSetupBusy = false;
		//}

		//private static IEnumerable<int> FindRecordIndicesByData(object data)
		//{
		//	if (Records == null)
		//	{
		//		yield break;
		//	}
		//	int ri = 0;
		//	while (ri < Records.Length)
		//	{
		//		if (Records[ri].Data == data)
		//		{
		//			yield return ri;
		//		}
		//		int num = ri + 1;
		//		ri = num;
		//	}
		//}
	}
}
