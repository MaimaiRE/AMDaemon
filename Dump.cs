using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public static class Dump
	{
		//public static readonly int DumpBinarySize = Api.dump_getDumpBinarySize();

		//public static string DumpAll()
		//{
		//	return DumpAll(true);
		//}

		//public static string DumpAll(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpAll);
		//}

		//public static string DumpProcess()
		//{
		//	return DumpProcess(true);
		//}

		//public static string DumpProcess(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpProcess);
		//}

		//public static string DumpCommon()
		//{
		//	return DumpCommon(true);
		//}

		//public static string DumpCommon(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpCommon);
		//}

		//public static string DumpAbaasLog()
		//{
		//	return DumpAbaasLog(true);
		//}

		//public static string DumpAbaasLog(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpAbaasLog);
		//}

		//public static string DumpAime()
		//{
		//	return DumpAime(true);
		//}

		//public static string DumpAime(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpAime);
		//}

		//public static string DumpAimePay()
		//{
		//	return DumpAimePay(true);
		//}

		//public static string DumpAimePay(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpAimePay);
		//}

		//public static string DumpAllnetAuth()
		//{
		//	return DumpAllnetAuth(true);
		//}

		//public static string DumpAllnetAuth(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpAllnetAuth);
		//}

		//public static string DumpAllnetAccounting()
		//{
		//	return DumpAllnetAccounting(true);
		//}

		//public static string DumpAllnetAccounting(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpAllnetAccounting);
		//}

		//public static string DumpAppImage()
		//{
		//	return DumpAppImage(true);
		//}

		//public static string DumpAppImage(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpAppImage);
		//}

		//public static string DumpBackup()
		//{
		//	return DumpBackup(true);
		//}

		//public static string DumpBackup(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpBackup);
		//}

		//public static string DumpBoardIO()
		//{
		//	return DumpBoardIO(true);
		//}

		//public static string DumpBoardIO(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpBoardIO);
		//}

		//public static string DumpCan()
		//{
		//	return DumpCan(true);
		//}

		//public static string DumpCan(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpCan);
		//}

		//public static string DumpCredit()
		//{
		//	return DumpCredit(true);
		//}

		//public static string DumpCredit(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpCredit);
		//}

		//public static string DumpEMoney()
		//{
		//	return DumpEMoney(true);
		//}

		//public static string DumpEMoney(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpEMoney);
		//}

		//public static string DumpError()
		//{
		//	return DumpError(true);
		//}

		//public static string DumpError(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpError);
		//}

		//public static string DumpInput()
		//{
		//	return DumpInput(true);
		//}

		//public static string DumpInput(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpInput);
		//}

		//public static string DumpJvs()
		//{
		//	return DumpJvs(true);
		//}

		//public static string DumpJvs(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpJvs);
		//}

		//public static string DumpLanInstall()
		//{
		//	return DumpLanInstall(true);
		//}

		//public static string DumpLanInstall(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpLanInstall);
		//}

		//public static string DumpNetDelivery()
		//{
		//	return DumpNetDelivery(true);
		//}

		//public static string DumpNetDelivery(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpNetDelivery);
		//}

		//public static string DumpNetwork()
		//{
		//	return DumpNetwork(true);
		//}

		//public static string DumpNetwork(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpNetwork);
		//}

		//public static string DumpOutput()
		//{
		//	return DumpOutput(true);
		//}

		//public static string DumpOutput(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpOutput);
		//}

		//public static string DumpSequence()
		//{
		//	return DumpSequence(true);
		//}

		//public static string DumpSequence(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpSequence);
		//}

		//public static string DumpSystem()
		//{
		//	return DumpSystem(true);
		//}

		//public static string DumpSystem(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpSystem);
		//}

		//public static string DumpUsbDevice()
		//{
		//	return DumpUsbDevice(true);
		//}

		//public static string DumpUsbDevice(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpUsbDevice);
		//}

		//public static string DumpUsbIO()
		//{
		//	return DumpUsbIO(true);
		//}

		//public static string DumpUsbIO(bool formatting)
		//{
		//	return DumpByApi(formatting, Api.dump_dumpUsbIO);
		//}

		//private static string DumpByApi(bool formatting, Func<int, IntPtr> api)
		//{
		//	return Marshal.PtrToStringUni(api((!formatting) ? (-1) : 0));
		//}

		//public static void DumpBinary(ref byte[] dest)
		//{
		//	if (dest == null)
		//	{
		//		throw new ArgumentNullException("dest");
		//	}
		//	Api.CallAction(ref dest, delegate(ref byte[] d)
		//	{
		//		Api.dump_dumpBinary(d, d.Length);
		//	});
		//}

		//public static byte[] DumpBinary()
		//{
		//	byte[] dest = new byte[DumpBinarySize];
		//	DumpBinary(ref dest);
		//	return dest;
		//}

		//public static string DumpAllFromBinary(byte[] src)
		//{
		//	return DumpAllFromBinary(src, true);
		//}

		//public static string DumpAllFromBinary(byte[] src, bool formatting)
		//{
		//	if (src == null)
		//	{
		//		throw new ArgumentNullException("src");
		//	}
		//	return DumpByApi(formatting, (int indent) => Api.Call(() => Api.dump_dumpAllFromBinary(src, src.Length, indent)));
		//}
	}
}
