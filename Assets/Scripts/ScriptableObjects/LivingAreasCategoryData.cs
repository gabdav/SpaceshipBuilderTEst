using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LivingAreas", menuName = "ScriptableObjects/LivingAreas", order = 4)]

public class LivingAreasCategoryData : BasePartCategoryData
{
    public override bool Condition(Dictionary<BasePartCategoryData, List<PartData>> spawnedParts)
    {
        int totalAmountOfLivingAreas = 0;
        int totalAmountOfMotors = 0;
        foreach (KeyValuePair<BasePartCategoryData, List<PartData>> valuePair in spawnedParts)
        {
            if (valuePair.Key.partCategoryLabel == PartCategory.Motors)
                totalAmountOfMotors = valuePair.Value.Count;
            if (valuePair.Key.partCategoryLabel == PartCategory.LivingAreas)
                totalAmountOfLivingAreas = valuePair.Value.Count;
        }

        return totalAmountOfMotors >= (totalAmountOfLivingAreas + 1) * 2;
    }
}
