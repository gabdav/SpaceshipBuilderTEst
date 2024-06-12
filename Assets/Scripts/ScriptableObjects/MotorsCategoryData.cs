using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Motors", menuName = "ScriptableObjects/Motors", order = 3)]

public class MotorsCategoryData : BasePartCategoryData
{
    public override bool Condition(Dictionary<BasePartCategoryData, List<PartData>> spawnedParts)
    {
        return true;
    }
}
