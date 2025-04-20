namespace AMDaemon
{
	public static class NetworkTestItemExtension
	{
		public static string ToText(this NetworkTestItem item)
		{
			switch (item)
			{
				case NetworkTestItem.IpAddress:
					return "IPアドレス";
				case NetworkTestItem.LanDns: // assuming 'LanDns' maps to DNS
					return "DNS";
				case NetworkTestItem.Gateway:
					return "ゲートウェイ";
				case NetworkTestItem.AllnetAuth: // assuming 'Server' = AllnetAuth
					return "サーバー";
				case NetworkTestItem.Aime:
					return "AIME";
				case NetworkTestItem.EMoney:
					return "電子マネー";
				case NetworkTestItem.Hops:
					return "ホップ数";
				case NetworkTestItem.LineType:
					return "回線種別";
				case NetworkTestItem.AimePay:
					return "AIME PAY";
				default:
					return item.ToString();
			}
		}
	}
}
