using System;
using System.Collections.Generic;

public class CropRatio
{
    private int totalWeight;
    private Dictionary<string, int> crops = new Dictionary<string, int>();

    public void Add(string name, int cropWeight)
    {
        int currentCropWeight;
        crops.TryGetValue(name, out currentCropWeight);

        if (currentCropWeight == 0) 
            crops[name] = cropWeight;
        else
            crops[name] = currentCropWeight + cropWeight;
        totalWeight = totalWeight + cropWeight;
    }

    public double Proportion(string name)
    {
        return (double)crops[name] / totalWeight;
    }

   
}