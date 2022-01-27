using System;

public class GetRecord
{
    public virtual int[] GetDataFromDB()
    {
        // consider this method fetches records from the databse 
        throw new NotImplementedException();
        // return new int[] { 4, 5, 6, 7, 8, 9 };
    }
}

public class SortRecord
{
    public int[] GetSortedRecord(GetRecord getter)
    {
        int[] record = getter.GetDataFromDB();
        Array.Sort(record);
        return record;
    }
}