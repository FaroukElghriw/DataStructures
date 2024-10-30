using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	internal static class Hashing
	{
		public static uint Hash32(string str)
		{
			uint offestBasis = 2166136261;
			uint fnvPrime = 16777619;
			byte[] Data = Encoding.ASCII.GetBytes(str);

			uint Hash = offestBasis;
			for (int i =0; i<Data.Length;i++)
			{
				Hash = Hash ^ Data[i];
				Hash = Hash * fnvPrime;
			}
            Console.WriteLine($"str : {str}, Hash: {Hash} , HashHexa: {Hash.ToString("x")}");
            return Hash;
		}

		public static ulong Hash64(string str)
		{
			ulong offestBasis = 14695981039346656037;
			ulong fnvPrime = 1099511628211;
			byte[] Data = Encoding.ASCII.GetBytes(str);

			ulong Hash = offestBasis;
			for (int i = 0; i < Data.Length; i++)
			{
				Hash = Hash ^ Data[i];
				Hash = Hash * fnvPrime;
			}
			Console.WriteLine($"str : {str}, Hash: {Hash} , HashHexa: {Hash.ToString("x")}");
			return Hash;
		}
	}
}
