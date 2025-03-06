using System;
using System.Collections.Generic;

namespace AMDaemon.Allnet
{
	public static class Accounting
	{
		private static readonly Dictionary<AccountingPlayCountMonth, AccountingPlayCountItem> PlayCountItems;

		public static bool IsAvailable => true; // Api.allnet_Accounting_isAvailable();

		public static AccountingMode Mode => AccountingMode.None; //Api.allnet_Accounting_getMode();

		public static bool IsPlayable => true; // Api.allnet_Accounting_isPlayable();

		public static bool IsReporting => false; // Api.allnet_Accounting_isReporting();

		public static TimeSpan SpanUntilReport => InnerUtil.MakeTimeSpan(0);

		public static DateTime ReportTime => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		public static DateTime BackgroundReportTime => InnerUtil.MakeDateTime(0, DateTimeKind.Local);

		public static bool IsLogFull => false;// Api.allnet_Accounting_isLogFull();

		public static bool IsNearFullEnabled => true;// Api.allnet_Accounting_isNearFullEnabled();

		public static int PlayerCount => Players.Count;

		public static LazyCollection<AccountingUnit> Players { get; private set; }

		static Accounting()
		{
			//PlayCountItems = new Dictionary<AccountingPlayCountMonth, AccountingPlayCountItem>();
			//foreach (AccountingPlayCountMonth value in Enum.GetValues(typeof(AccountingPlayCountMonth)))
			//{
			//	PlayCountItems.Add(value, new AccountingPlayCountItem(Api.Call(value, Api.allnet_Accounting_getPlayCountItem)));
			//}
			Players = new LazyCollection<AccountingUnit>(()=>1, (int index) => new AccountingUnit(IntPtr.Zero));
		}

		public static AccountingPlayCountItem GetPlayCountItem(AccountingPlayCountMonth month)
		{
			AccountingPlayCountItem value = null;
			if (!PlayCountItems.TryGetValue(month, out value))
			{
				throw new ArgumentException("`month` is invalid value.", "month");
			}
			return value;
		}

		public static bool SetNearFullEnabled(bool enabled)
		{
			return true; // Api.Call(enabled, Api.allnet_Accounting_setNearFullEnabled);
		}
	}
}
