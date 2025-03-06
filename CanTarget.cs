using System;

namespace AMDaemon
{
	public sealed class CanTarget
	{
		//private readonly RequestState[] sendStateCaches = new RequestState[256];

		//private readonly CanAck[] ackCaches = new CanAck[256];

		//private IntPtr Pointer { get; set; }

		//public CanTargetProperty Property { get; private set; }

		//internal CanTarget(IntPtr pointer)
		//{
		//	Pointer = pointer;
		//	Property = new CanTargetProperty(Api.Call(pointer, Api.CanTarget_getProperty));
		//}

		//public bool Send(byte command, byte[] data, int dataSize, byte priority)
		//{
		//	IntPtr intPtr = Api.Call(() => Api.CanTarget_send(Pointer, command, data, dataSize, priority));
		//	if (intPtr == IntPtr.Zero)
		//	{
		//		return false;
		//	}
		//	sendStateCaches[command] = RequestState.ReplaceOrCreate(sendStateCaches[command], intPtr);
		//	return true;
		//}

		//public bool Send(byte command, byte[] data, int dataSize)
		//{
		//	return Send(command, data, dataSize, Can.DefaultPacketPriority);
		//}

		//public bool Send(byte command, byte[] data)
		//{
		//	return Send(command, data, (data != null) ? data.Length : 0);
		//}

		//public bool Send(byte command)
		//{
		//	return Send(command, null, 0);
		//}

		//public RequestState GetLastSendState(byte command)
		//{
		//	return sendStateCaches[command];
		//}

		//public CanAck GetAck(byte command)
		//{
		//	CanAck canAck = ackCaches[command];
		//	if (canAck == null)
		//	{
		//		canAck = new CanAck(Api.Call(Pointer, command, Api.CanTarget_getAck));
		//		ackCaches[command] = canAck;
		//	}
		//	return canAck;
		//}
	}
}
