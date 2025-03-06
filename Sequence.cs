using System;

namespace AMDaemon
{
	public static class Sequence
	{
		private static readonly PlayBeginParam DefaultPlayBeginParam;

		private static readonly PlayContinueParam DefaultPlayContinueParam;

		private static readonly PlayEndParam DefaultPlayEndParam;

		public static SequenceBookkeeping Bookkeeping { get; private set; }

		//public static int PlayerCount => Api.Sequence_getPlayerCount();

		//public static PlayAccountingTiming PlayAccountingTiming => Api.Sequence_getPlayAccountingTiming();

		//public static bool IsPlayingAny => Api.Sequence_isPlayingAny();

		public static bool IsTest => false;// Api.Sequence_isTest();

		static Sequence()
		{
			DefaultPlayBeginParam = new PlayBeginParam();
			DefaultPlayContinueParam = new PlayContinueParam();
			DefaultPlayEndParam = new PlayEndParam();
			Bookkeeping = new SequenceBookkeeping();
		}

		public static bool ClearBackup()
		{
			//return Api.Call(Api.Sequence_clearBackup);
			return true;
		}

		public static bool BeginPlay(int playerIndex)
		{
			return BeginPlay(playerIndex, DefaultPlayBeginParam);
		}

		public static bool BeginPlay(int playerIndex, PlayBeginParam param)
		{
			PlayErrorId errorId;
			return BeginPlay(playerIndex, param, out errorId);
		}

		public static bool BeginPlay(int playerIndex, PlayBeginParam param, out PlayErrorId errorId)
		{
			errorId = PlayErrorId.None;
			if (param == null)
			{
				throw new ArgumentNullException("param");
			}
            //return Api.Call(ref errorId, delegate(ref PlayErrorId id)
            //{
            //	return Api.Sequence_beginPlay(playerIndex, param.GameCostIndex, param.GameCostCount, param.AccountingBegin.IsValid, param.AccountingBegin.KindCode, param.AccountingBegin.StatusCode, param.AccountingEnd.IsValid, param.AccountingEnd.KindCode, param.AccountingEnd.StatusCode, param.AccountingEnd.ItemCount, param.AimeId.Value, out id);
            //});
            return true;
        }

		public static bool ContinuePlay(int playerIndex)
		{
			return ContinuePlay(playerIndex, DefaultPlayContinueParam);
		}

		public static bool ContinuePlay(int playerIndex, PlayContinueParam param)
		{
			PlayErrorId errorId;
			return ContinuePlay(playerIndex, param, out errorId);
		}

		public static bool ContinuePlay(int playerIndex, PlayContinueParam param, out PlayErrorId errorId)
		{
			errorId = PlayErrorId.None;
			if (param == null)
			{
				throw new ArgumentNullException("param");
			}
            //return Api.Call(ref errorId, delegate(ref PlayErrorId id)
            //{
            //	return Api.Sequence_continuePlay(playerIndex, param.GameCostIndex, param.GameCostCount, param.AccountingBegin.IsValid, param.AccountingBegin.KindCode, param.AccountingBegin.StatusCode, param.AccountingEnd.IsValid, param.AccountingEnd.KindCode, param.AccountingEnd.StatusCode, param.AccountingEnd.ItemCount, out id);
            //});
            return true;
        }

		public static bool EndPlay(int playerIndex)
		{
			return EndPlay(playerIndex, DefaultPlayEndParam);
		}

		public static bool EndPlay(int playerIndex, PlayEndParam param)
		{
			PlayErrorId errorId;
			return EndPlay(playerIndex, param, out errorId);
		}

		public static bool EndPlay(int playerIndex, PlayEndParam param, out PlayErrorId errorId)
		{
			errorId = PlayErrorId.None;
			if (param == null)
			{
				throw new ArgumentNullException("param");
			}
            //return Api.Call(ref errorId, delegate(ref PlayErrorId id)
            //{
            //	return Api.Sequence_endPlay(playerIndex, param.AccountingBegin.IsValid, param.AccountingBegin.KindCode, param.AccountingBegin.StatusCode, param.AccountingEnd.IsValid, param.AccountingEnd.KindCode, param.AccountingEnd.StatusCode, param.AccountingEnd.ItemCount, param.IsCancel, out id);
            //});
            return true;
        }

		public static bool IsPlaying(int playerIndex)
		{
			return true; // Api.Call(playerIndex, Api.Sequence_isPlaying);
		}

		public static bool IsAccountingPlaying(int playerIndex)
		{
			return true; // Api.Call(playerIndex, Api.Sequence_isAccountingPlaying);
		}

		public static AimeId GetPlayingAimeId(int playerIndex)
		{
            //return new AimeId(Api.Call(playerIndex, Api.Sequence_getPlayingAimeId));
            return new AimeId();
        }

		public static bool BeginTest()
		{
			//return Api.Call(Api.Sequence_beginTest);
			return true;
		}

		public static bool EndTest()
		{
			//return Api.Call(Api.Sequence_endTest);
			return false;
		}
	}
}
