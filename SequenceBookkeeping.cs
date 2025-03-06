using System;

namespace AMDaemon
{
	public sealed class SequenceBookkeeping
	{
		//public static readonly int MaxTimeHistogramCount = Api.SequenceBookkeeping_MaxTimeHistogramCount_get();

		private IntPtr Pointer { get; set; }

		public uint NumberOfGames => 0;// Api.SequenceBookkeeping_numberOfGames_get(Pointer);

		public TimeSpan TotalTime => TimeSpan.FromSeconds(0);

		public TimeSpan PlayTime => TimeSpan.FromSeconds(0);

        public TimeSpan AveragePlayTime => TimeSpan.FromSeconds(0);

        public TimeSpan LongestPlayTime => TimeSpan.FromSeconds(0);

        public TimeSpan ShortestPlayTime => TimeSpan.FromSeconds(0);

        //public int TimeHistogramCount => TimeHistogram.Count;

        //public LazyCollection<TimeHistogramItem> TimeHistogram { get; private set; }

        //internal SequenceBookkeeping(IntPtr pointer)
        //{
        //	Pointer = pointer;
        //	TimeHistogram = new LazyCollection<TimeHistogramItem>(() => Api.SequenceBookkeeping_timeHistogramCount_get(pointer), (int index) => new TimeHistogramItem(Api.Call(pointer, index, Api.SequenceBookkeeping_timeHistogram_get)), true);
        //}
    }
}
