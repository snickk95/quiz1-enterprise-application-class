namespace PageCounterApp.Services
{
    //interface for all functions to do with page counting
    public interface IPageCount
    {
        //fumction takes in the current page count for that page incrments it then returns the new value
        public int IncrementPageCount(int curPageCount)
        {
            curPageCount++;
            return curPageCount;
        }
    }
}
