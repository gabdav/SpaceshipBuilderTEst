using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePartCategoryData : ScriptableObject
{
    public PartCategory partCategoryLabel;
    public List<PartData> parts;
    public abstract bool Condition(Dictionary<BasePartCategoryData, List<PartData>> spawnedParts);
}
public enum PartCategory
{
    None,
    Canons = 100,
    Shields = 200,
    Motors = 300,
    LivingAreas = 400
}