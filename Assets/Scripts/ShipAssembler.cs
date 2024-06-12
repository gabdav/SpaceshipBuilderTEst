using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAssembler : Singleton<ShipAssembler>
{
    [SerializeField] private List<BasePartCategoryData> _partCategories = new List<BasePartCategoryData>();
    [SerializeField] private GameObject _basePartPrefab;
    [SerializeField] private Transform _unifier;
    private Dictionary<BasePartCategoryData, List<PartData>> _spawnedPart = new Dictionary<BasePartCategoryData, List<PartData>>();

    private KeyValuePair<BasePartCategoryData, PartData> floatingItem = new KeyValuePair<BasePartCategoryData, PartData>();
    public void Init()
    {
        foreach (BasePartCategoryData partCategory in _partCategories)
        {
            _spawnedPart.Add(partCategory, new List<PartData>());
        }
    }
    public List<BasePartCategoryData> GetCategories()
    {
        return _partCategories;
    }
    public void Spawn(BasePartCategoryData category, PartData partToSpawn)
    {
        if (category.Condition(_spawnedPart))
        {
            GameObject spawnedBasePart = Instantiate(_basePartPrefab, transform);
            Instantiate(partToSpawn.art, spawnedBasePart.transform);
            floatingItem = new KeyValuePair<BasePartCategoryData, PartData>(category, partToSpawn);
            MouseFollow.Instance.SetSelectedItem(spawnedBasePart);
        }
        else
        {
            Debug.Log("Condition not met");
        }
    }
    public void SetItem(Transform partLocation)
    {
        if (floatingItem.Key && floatingItem.Value)
            _spawnedPart[floatingItem.Key].Add(floatingItem.Value);

        Transform partConnectionTransform = Instantiate(_unifier, Vector3.zero, Quaternion.identity);
        partConnectionTransform.LookAt(partLocation.position);
        partConnectionTransform.localScale = new Vector3(0.5f, 0.5f, Vector3.Distance(partLocation.position, Vector3.zero));
    }
}
