using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AMDaemon
{
	public class LazyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		private struct Cache
		{
			public T Value
			{
				
				get;
				private set; }

			public Cache(T value)
			{
				this = default(Cache);
				Value = value;
			}
		}

		public T this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				Cache? cache = GetCache(index);
				if (cache.HasValue)
				{
					return cache.Value.Value;
				}
				T val = ValueGenerater(index);
				SetCache(index, val);
				return val;
			}
		}

		public bool IsCacheEnabled => Caches != null;

		private Func<int> CountGenerater { get; set; }

		private Func<int, T> ValueGenerater { get; set; }

		private List<Cache?> Caches { get; set; }

		T IList<T>.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public int Count => CountGenerater();

		bool ICollection<T>.IsReadOnly => true;

		public LazyCollection(Func<int> countGenerator, Func<int, T> valueGenerater)
			: this(countGenerator, valueGenerater, false)
		{
		}

		public LazyCollection(Func<int> countGenerator, Func<int, T> valueGenerater, bool cacheEnabled)
		{
			if (countGenerator == null)
			{
				throw new ArgumentNullException("countGenerator");
			}
			if (countGenerator == null)
			{
				throw new ArgumentNullException("valueGenerater");
			}
			CountGenerater = countGenerator;
			ValueGenerater = valueGenerater;
			Caches = (cacheEnabled ? new List<Cache?>() : null);
		}

		public void ForEach(Action<T> action)
		{
			using (IEnumerator<T> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					action(current);
				}
			}
		}

		public void ForEach(Action<T, int> action)
		{
			int num = 0;
			using (IEnumerator<T> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					action(current, num);
					num++;
				}
			}
		}

		private Cache? GetCache(int index)
		{
			if (Caches != null && Caches.Count > index)
			{
				return Caches[index];
			}
			return null;
		}

		private void SetCache(int index, T value)
		{
			if (Caches != null)
			{
				while (Caches.Count <= index)
				{
					Caches.Add(null);
				}
				Caches[index] = new Cache(value);
			}
		}

		public int IndexOf(T item)
		{
			int num = 0;
			using (IEnumerator<T> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					if (EqualityComparer<T>.Default.Equals(current, item))
					{
						return num;
					}
					num++;
				}
			}
			return -1;
		}

		void IList<T>.Insert(int index, T item)
		{
			throw new NotSupportedException();
		}

		void IList<T>.RemoveAt(int index)
		{
			throw new NotSupportedException();
		}

		public bool Contains(T item)
		{
			return IndexOf(item) >= 0;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex");
			}
			int count = Count;
			if (array.Length - arrayIndex < count)
			{
				throw new ArgumentException();
			}
			for (int i = 0; i < Math.Min(count, Count); i++)
			{
				array[arrayIndex + i] = this[i];
			}
		}

		void ICollection<T>.Add(T item)
		{
			throw new NotSupportedException();
		}

		void ICollection<T>.Clear()
		{
			throw new NotSupportedException();
		}

		bool ICollection<T>.Remove(T item)
		{
			throw new NotSupportedException();
		}

		public IEnumerator<T> GetEnumerator()
		{
			int i = 0;
			while (i < Count)
			{
				yield return this[i];
				int num = i + 1;
				i = num;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
