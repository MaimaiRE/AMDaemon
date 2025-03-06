using AMDaemon.Allnet;

namespace AMDaemon
{
	public sealed class Player
	{
		//public static LazyCollection<Player> Instances { get; private set; }

		//public int Index { get; private set; }

		//public bool IsPlaying => Sequence.IsPlaying(Index);

		//public bool IsAccountingPlaying => Sequence.IsAccountingPlaying(Index);

		//public AimeId PlayingAimeId => Sequence.GetPlayingAimeId(Index);

		//public InputUnit InputUnit => Input.Players[Index];

		//public OutputUnit OutputUnit => Output.Players[Index];

		//public CreditUnit CreditUnit => Credit.Players[Index];

		//public AccountingUnit AllnetAccountingUnit => Accounting.Players[Index];

		//static Player()
		//{
		//	Instances = new LazyCollection<Player>(() => Core.PlayerCount, (int index) => new Player(index), true);
		//}

		//internal Player(int index)
		//{
		//	Index = index;
		//}

		//public bool BeginPlay()
		//{
		//	return Sequence.BeginPlay(Index);
		//}

		//public bool BeginPlay(PlayBeginParam param)
		//{
		//	return Sequence.BeginPlay(Index, param);
		//}

		//public bool BeginPlay(PlayBeginParam param, out PlayErrorId errorId)
		//{
		//	return Sequence.BeginPlay(Index, param, out errorId);
		//}

		//public bool ContinuePlay()
		//{
		//	return Sequence.ContinuePlay(Index);
		//}

		//public bool ContinuePlay(PlayContinueParam param)
		//{
		//	return Sequence.ContinuePlay(Index, param);
		//}

		//public bool ContinuePlay(PlayContinueParam param, out PlayErrorId errorId)
		//{
		//	return Sequence.ContinuePlay(Index, param, out errorId);
		//}

		//public bool EndPlay()
		//{
		//	return Sequence.EndPlay(Index);
		//}

		//public bool EndPlay(PlayEndParam param)
		//{
		//	return Sequence.EndPlay(Index, param);
		//}

		//public bool EndPlay(PlayEndParam param, out PlayErrorId errorId)
		//{
		//	return Sequence.EndPlay(Index, param, out errorId);
		//}
	}
}
