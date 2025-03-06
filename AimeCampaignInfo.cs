using System;
using System.Runtime.InteropServices;

namespace AMDaemon
{
	public sealed class AimeCampaignInfo
	{
		public sealed class TimeRange
		{
			public DateTime Begin => InnerUtil.MakeDateTime(BeginGetter(), DateTimeKind.Local);

			public DateTime End => InnerUtil.MakeDateTime(EndGetter(), DateTimeKind.Local);

			private Func<ulong> BeginGetter { get; set; }

			private Func<ulong> EndGetter { get; set; }

			internal TimeRange(Func<ulong> beginGetter, Func<ulong> endGetter)
			{
				BeginGetter = beginGetter;
				EndGetter = endGetter;
			}
		}

		//public static readonly int MaxNameLength = Api.AimeCampaignInfo_MaxNameLength_get();

		//private IntPtr Pointer { get; set; }

		//public uint Id => Api.AimeCampaignInfo_id_get(Pointer);

		//public string Name => Marshal.PtrToStringUni(Api.AimeCampaignInfo_name_get(Pointer));

		//public DateTime NoticeTime => InnerUtil.MakeDateTime(Api.AimeCampaignInfo_noticeTime_get(Pointer), DateTimeKind.Local);

		public TimeRange OpenTimeRange { get; private set; }

		public TimeRange RewardTimeRange { get; private set; }

		internal AimeCampaignInfo(IntPtr pointer)
		{
			//Pointer = pointer;
			//OpenTimeRange = new TimeRange(() => Api.AimeCampaignInfo_openTimeRange_begin_get(pointer), () => Api.AimeCampaignInfo_openTimeRange_end_get(pointer));
			//RewardTimeRange = new TimeRange(() => Api.AimeCampaignInfo_rewardTimeRange_begin_get(pointer), () => Api.AimeCampaignInfo_rewardTimeRange_end_get(pointer));
		}
	}
}
