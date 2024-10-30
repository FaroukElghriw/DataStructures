using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	internal class Dicitionary<TKey, TValue> where TKey :class
	{
		KeyValuePair[] enteries;
		int intialSize;
		int enteriesCount;
        public Dicitionary()
        {
			intialSize = 3;
			enteries = new KeyValuePair[intialSize];
        }
		public void ResizeOrNot()
		{
			if(enteriesCount < enteries.Length - 1)
			{
				return;
			}
				int newSize= enteries.Length+ intialSize;
			Console.WriteLine($"Resize Array from {enteries.Length} to new size {newSize}");
			KeyValuePair[] newArray = new KeyValuePair[newSize];
				Array.Copy(enteries, newArray, enteries.Length);
				enteries = newArray;
		}
		public int Size()
				 => enteriesCount;
		public void Set(TKey key,TValue value)
		{
			for(int i=0; i <enteries.Length; i++) // using linear search for search
			{
				if (enteries[i] is not  null && enteries[i].Key== key)
				{
					enteries[i].Value = value;
					return;
				}
			}
			ResizeOrNot();
			KeyValuePair newPair = new KeyValuePair(key, value);
			enteries[this.enteriesCount] = newPair;
			enteriesCount++;
		}

		public TValue Get(TKey key)
		{
			for (int i = 0; i < enteries.Length; i++) // using linear search for search
			{
				if (enteries[i] != null && enteries[i].Key == key)
				{
					return enteries[i].Value;
				}
			}

			return default(TValue);
		}


		// enteriesCOunt is a index in a dicitinory help me to know the auct item in dici and help to in remove
	
		public Boolean Remove(TKey key)
		{
			for (int i = 0; i < enteries.Length; i++) // using linear search for search
			{
				if (enteries[i] !=null && enteries[i].Key == key)
				{
					enteries[i] = enteries[enteriesCount - 1];
					enteries[enteriesCount - 1] = null;
					enteriesCount--;
					return true;
				}
			}
			return false;
		}

		public void Print()
		{
            Console.WriteLine("=============");
            Console.WriteLine($"Size: {Size()}");
            for (int i = 0; i < enteries.Length; i++) // using linear search for search
			{
				if (enteries[i] is  null)
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
				get { return _value ; }
				set { _value = value; }
			}
            public KeyValuePair(TKey key,TValue value)
            {
                _key = key;
				_value = value;
            }

        }
	}
	
}
