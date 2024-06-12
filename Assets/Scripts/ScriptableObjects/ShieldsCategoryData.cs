using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shields", menuName = "ScriptableObjects/Shields", order = 2)]

public class ShieldsCategoryData : BasePartCategoryData
{
    public override bool Condition(Dictionary<BasePartCategoryData, List<PartData>> spawnedParts)
    {
        return true;
    }
}
