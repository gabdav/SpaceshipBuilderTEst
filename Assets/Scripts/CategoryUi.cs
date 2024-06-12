using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CategoryUi : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _label;
    [SerializeField] private Button _buttonPrefab;
    [SerializeField] private RectTransform _buttonHolder;

    public void Init(BasePartCategoryData label, List<PartData> buttonLabel)
    {
        _label.text = label.partCategoryLabel.ToString();
        foreach (var item in buttonLabel)
        {
            Button newBtn = Instantiate(_buttonPrefab, _buttonHolder);
            newBtn.GetComponentInChildren<TextMeshProUGUI>().text = item.stats.name;
            newBtn.onClick.AddListener(() => ShipAssembler.Instance.Spawn(label, item));
        }

    }
}
