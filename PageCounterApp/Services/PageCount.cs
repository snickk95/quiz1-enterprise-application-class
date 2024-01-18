namespace PageCounterApp.Services
{
    public class PageCount: IPageCount
    {
        
        IPageCount count;//interface for the counting
        private int numVisits;//track the number of visits to the page
       Dictionary<string, int> counts = new Dictionary<string,int>();//create dictionary OBJ
        public PageCount() 
        {
            //fill dictionary
            counts.Add("Home", 0);
            counts.Add("otherPage", 0);
        }

        public int Count(string pageName)//takes in the name of the current page
        {
            if (counts.TryGetValue(pageName, out numVisits))//check the value exists in the dictionary
            {
                int newNum;//variable to track the new page count
                newNum = count.IncrementPageCount(numVisits);//call the Interface to incrment the page count
                counts[pageName] = newNum;//update dictionary 
                return newNum;
            }
            else
            {
               return -1;//return -1 for the page not found in dictionary
            }
          
        }
    }
}
