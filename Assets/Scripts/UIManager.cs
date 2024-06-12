using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private CategoryUi _categoryPrefab;
    [SerializeField] private RectTransform _parent;

    public void Init(List<BasePartCategoryData> amountOfCategories)
    {
        foreach (BasePartCategoryData item in amountOfCategories)
        {
            CategoryUi spawnedCategory = Instantiate(_categoryPrefab, _parent);
            spawnedCategory.Init(item, item.parts);
        }
    }
}
