using System;
using System.Collections;

namespace QStats
{
	/// <summary>
	/// Mean is implemented by passing an array of numbers to it
	/// </summary>
	public class Statistics
	{
		/// <summary>
		/// The methods in this class return values (string, int, decimal) from an input 
		/// ArrayList of numbers.
		/// </summary>
		/// <param name="Data"></param>
		/// <returns></returns>
		public static decimal Mean(ArrayList Numbers)
			/// <summary>
			/// returns the Mean
			/// </summary>
			/// <returns>Mean</returns>
		{
			decimal Sum = 0.0m;
			foreach (object i in Numbers)
				Sum += Convert.ToDecimal(i);
			decimal Mean = Sum / Numbers.Count;
			return Mean;
		}

		public static decimal Median(ArrayList Numbers)
		{
			int middle;
			decimal median;
			Numbers.Sort();
			if (Numbers.Count % 2 == 1)
			{
				middle = (Numbers.Count) / 2;
				median = (decimal)Numbers[middle];
				return median;
			}
			else
			{
				middle = (Numbers.Count - 1) / 2;
				median = (decimal)Numbers[middle];
				middle ++;
				median += (decimal)Numbers[middle];
				return median / 2;
			}
		}
		public static decimal Range(ArrayList Numbers)
		{
			Numbers.Sort();
			decimal low = (decimal)Numbers[0];
			decimal high = (decimal)Numbers[Numbers.Count - 1];
			decimal range = high - low;
			return range;
		}

		public static string Mode(ArrayList Numbers, out decimal ModeCount)
		{
			ModeCount = 0; 
			Hashtable counts = new Hashtable(); 
			decimal count = 0;
			foreach(object o in Numbers) 
			{
				if (counts.Contains(o))
				{
					count = (decimal)counts[o];
				}
				else
				{
					count = 0;
				}
				if(++count > ModeCount)
				{
					ModeCount=count;
				} 
				counts[o] = count; 
			}

			string modes = ""; 
			foreach(DictionaryEntry de in counts) 
				if((decimal)de.Value==ModeCount)modes += de.Key.ToString() + "\r\n";

			return modes; 
		}

		public static string Skew(ArrayList Numbers)
		{
			decimal median = Median(Numbers);
			decimal mean = Mean(Numbers);
			string skew;

			if (median > mean)
			{
				skew = "negative";
			}
			else if (mean > median)
			{
				skew = "positive";
			}
			else
			{
				skew = "symetrical";
			}

			return skew;
		}

		public static decimal High(ArrayList Numbers)
		{
			Numbers.Sort();
			decimal high = (decimal)Numbers[Numbers.Count - 1];
			return high;
		}

		public static decimal Low(ArrayList Numbers)
		{
			Numbers.Sort();
			decimal low = (decimal)Numbers[0];
			return low;
		}

		public static decimal IRange(ArrayList Numbers)
		{
			int count = Numbers.Count;
			int iLow = (int)(count * .25);
			int iHigh = (int)(count * .75);
			ArrayList IArray = new ArrayList();
			for (int i = iLow; i <= iHigh; i++)
				IArray.Add(Numbers[i]);

			decimal irange = Range(IArray);
			return irange;
		}

		public static ArrayList Deviations(ArrayList Numbers)
		{
			decimal mean = Mean(Numbers);
			decimal deviation = 0.0m;
			ArrayList deviations = new ArrayList(1);
			foreach (object i in Numbers)
			{
				deviation = Convert.ToDecimal(i) - mean;
				deviations.Add(deviation);
			}
			return deviations;
		}

		public static ArrayList AbsoluteDeviations(ArrayList Numbers)
		{
			decimal mean = Mean(Numbers);
			decimal deviation = 0.0m;
			ArrayList deviations = new ArrayList(1);
			foreach (object i in Numbers)
			{
				deviation = Convert.ToDecimal(i) - mean;
				if (deviation < 0)
				{
					deviations.Add(deviation * -1);
				}
				else
				{
					deviations.Add(deviation);
				}
			}
			return deviations;
		}

		public static decimal MAD(ArrayList Numbers)
		{
			ArrayList deviations = AbsoluteDeviations(Numbers);
            decimal mad = Mean(deviations);
			return mad;	
		}

		public static decimal StandardDeviation(ArrayList Numbers)
		{
			ArrayList deviations = Deviations(Numbers);
			decimal d = 0.0m;
			foreach (decimal o in deviations)
				d += (o * o);
			decimal sd = 0.0m;
			if (deviations.Count - 1 <= 0)
			{
				sd = 0;
			}
			else
			{				
				decimal sv = d / (deviations.Count - 1);
				sd = (decimal)Math.Sqrt(Convert.ToDouble(sv));
			}
			return sd;
		}
	}

	public class RandomNumber
	{

		/// <summary>
		/// This method returns a random number given a low and high range
		/// </summary>
		/// <param name="lowrange"></param>
		/// <param name="highrange"></param>
		/// <returns>a random number</returns>
		public static int[] rndNumber(int lowRange, int highRange, int arrayLength)
		{
			int[] numbers = new int[arrayLength];
			Random rnd = new Random();
			for (int i = 0; i < numbers.Length; i++)
				numbers[i] = rnd.Next(lowRange, highRange + 1);					
			
			return numbers;
		}
	}

}
