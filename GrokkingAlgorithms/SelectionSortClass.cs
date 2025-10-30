namespace PracticsGrokaemAlg.GrokkingAlgorithms;

public class SelectionSortClass
{
    public static List<int> SelectionSorts(List<int> arr) 
    {
        List<int> newArr = new List<int>();
        List<int> copiedArr = new List<int>(arr);  
        while (copiedArr.Count > 0)
        {
            int smallestIndex = FindSmallestClass.FindSmallest(copiedArr.ToArray()); 
            newArr.Add(copiedArr[smallestIndex]);
            copiedArr.RemoveAt(smallestIndex);
        }
        return newArr;  
    }
}