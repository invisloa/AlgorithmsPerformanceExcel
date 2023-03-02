using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.ArrayInitialize
{
    public class ArrayInitializer : IArrayInitializer
    {
		Random random = new Random();
		public int[] SingleArrayInitializer()
		{
			
			Console.Write("Enter the maximum length of the array: ");
			int maxLength = GetUserInputValues();
			return SingleArrayInitializer(maxLength);
		
		}
		public int[] SingleArrayInitializer(int maxLength)
		{
			int[] array = new int[maxLength];
			for (int i = 0; i < maxLength; i++)
			{
				array[i] = ValuesRandoizer();
			}
/*			Console.WriteLine("Generated array:");
			Console.WriteLine(string.Join(", ", array));
*/
			return array;
		}


		public int[][] MultiArrayInitializer()
		{
			Console.Write("Enter the numbers of arrays: ");
			int howManyArrays = GetUserInputValues();
			Console.Write("Enter the numbers of values in a single array: ");
			int howManyValuesInAnArray = GetUserInputValues();
			int[][] arrayOfArrays = new int[howManyArrays][]; 

			for (int i = 0; i < howManyArrays; i++)
			{
				arrayOfArrays[i] = SingleArrayInitializer(howManyValuesInAnArray);
			}
			return arrayOfArrays;
		}
		int GetUserInputValues()
		{
			int userInput;
			while (!int.TryParse(Console.ReadLine(), out userInput))
			{
				Console.WriteLine("hmmmm.... Are You sure it was a good number....??");
			}
			return userInput;
		}
		int ValuesRandoizer()
		{
			return random.Next(1, 1001);
		}

	}
}
