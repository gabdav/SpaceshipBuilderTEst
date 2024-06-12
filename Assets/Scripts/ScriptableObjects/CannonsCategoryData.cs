using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cannons", menuName = "ScriptableObjects/Cannons", order = 1)]

public class CannonsCategoryData : BasePartCategoryData
{
    public override bool Condition(Dictionary<BasePartCategoryData, List<PartData>> spawnedParts)
    {
        foreach (KeyValuePair<BasePartCategoryData, List<PartData>> valuePair in spawnedParts)
        {
            if (valuePair.Key.partCategoryLabel == PartCategory.Shields)
            {
                if (valuePair.Value.Count > 0)
                    return true;
            }
        }
        return false;
    }
}
