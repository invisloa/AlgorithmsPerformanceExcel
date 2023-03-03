namespace AlgoTestProjHomeWork.ArrayInitialize
{
    public interface IArrayInitializer
    {
		public int NumberOfArraysToSort { get; }
		public int NumberOfValuesInArray { get; }
		public int[] SingleArrayInitializer();
        public int[][] InitializeMultipleArrays();


	}
}