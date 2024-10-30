using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	internal class HashTable<TKey, TValue> where TKey : class
	{
		KeyValuePair[] enteries;
		int intialSize;
		int enteriesCount;
        public HashTable()
        {
			intialSize = 3;
			enteriesCount = 0;
			enteries = new KeyValuePair[intialSize];
		}

        public int GetHash(TKey Key)
		{
			uint offestBasis = 2166136261;
			uint fnvPrime = 16777619;
			byte[] Data = Encoding.ASCII.GetBytes(Key.ToString());

			uint Hash = offestBasis;
			for (int i = 0; i < Data.Length; i++)
			{
				Hash = Hash ^ Data[i];
				Hash = Hash * fnvPrime;
			}
			Console.WriteLine($"str : {Key.ToString()}, Hash: {Hash} , HashHexa: {Hash.ToString("x")} : {Hash % (uint)enteries.Length}");
			return  (int)(Hash % (uint)enteries.Length);
		}
		public int CollisionHandling(TKey key ,int Hash , bool set)
		{
			int newHash;
			for (int i = 1; i < enteries.Length; i++)
			{
				newHash = (Hash + i) % enteries.Length;
				if(set && (enteries[newHash] == null || enteries[newHash].Key == key))
				{
					return newHash;
				}
                else if(!set && ( enteries[newHash].Key == key))
                {
					return newHash;
                }
            }
			return -1;

		}
		public void AddToEntries(TKey key,TValue value)
		{
			int hash = GetHash(key);
			if (enteries[hash] != null && enteries[hash].Key != key) // collision
			{
				hash = CollisionHandling(key, hash, true);
			}
			if(hash == -1) // no key
			{
				throw new Exception("Invaild Exception !!!!!");
			}
			if(enteries[hash] == null) // set
			{
				KeyValuePair newPair=new KeyValuePair(key, value);
				enteries[hash] = newPair;
				enteriesCount++;

			}
			if (enteries[hash].Key == key) // update
			{
				enteries[hash].Value = value;
			}
			else
			{
				throw new Exception("Invaild Exception !!!!!");
			}
		}
		
			


		public void ResizeOrNot()
		{
			if (enteriesCount < enteries.Length )
			{
				return;
			}
			int newSize = enteries.Length * 2;
			Console.WriteLine($"Resize Array from {enteries.Length} to new size {newSize}");

			KeyValuePair[] entriesCopy = new KeyValuePair[enteries.Length];
			Array.Copy(this.enteries, entriesCopy, entriesCopy.Length);

			this.enteries = new KeyValuePair[newSize];
			this.enteriesCount = 0;
			for (int i = 0; i < entriesCopy.Length; i++)
			{
				if (entriesCopy[i] == null) continue;
				this.AddToEntries(entriesCopy[i].Key, entriesCopy[i].Value);
			}
		}
		public void Set(TKey key , TValue value)
		{
			ResizeOrNot();
			AddToEntries(key, value);
		}
		public TValue Get(TKey key)
		{
			int hash = this.GetHash(key);
			if (this.enteries[hash] != null && this.enteries[hash].Key != key)
			{
				hash = this.CollisionHandling(key, hash, false);
			}
			if (hash == -1 || this.enteries[hash] == null)
			{
				return default(TValue);
			}

			if (this.enteries[hash].Key == key)
			{
				return this.enteries[hash].Value;
			}
			else
			{
				throw new Exception("Invalid Hashtable!!!!");
			}

		}
		public int Size()
				 => enteriesCount;
		public void Print()
		{
			Console.WriteLine("=============");
			Console.WriteLine($"Size: {Size()}");
			for (int i = 0; i < enteries.Length; i++) // using linear search for search
			{
				if (enteries[i] is null)
				{
					Console.WriteLine($"I :{i}");
					continue;
				}
				else
				{
					Console.WriteLine($"{enteries[i].Key}  : {enteries[i].Value}");
				}
			}
			Console.WriteLine("-----------");
		}











		public class KeyValuePair
		{

			TKey _key;
			TValue _value;

			public TKey Key
			{
				get;
			}


			public TValue Value
			{
				get { return _value; }
				set { _value = value; }
			}
			public KeyValuePair(TKey key, TValue value)
			{
				_key = key;
				_value = value;
			}
		}
	}
}


