
using System.Collections.Generic;
using System.IO;


public static class DataProcess
{
    public static List<List<float>> datList = new List<List<float>>();

    private static float maxDat_val;
    
    public static void SortDat(StreamReader streamReader)
    {
        List<float> dat = new List<float>();
        maxDat_val = 0;
        
        while (!streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            var datVal = float.Parse(line);
            
            if (datVal > maxDat_val)
            {
                maxDat_val = datVal;
            }

            dat.Add(datVal);
        }

        dat = normalizeDat(dat);
        datList.Add(dat);
    }

    public static List<float> normalizeDat(List<float> datList)
    {
        for (int i = 0; i < datList.Count; i++)
        {
            datList[i] = datList[i] / maxDat_val;
        }
        return datList;
    }
}
