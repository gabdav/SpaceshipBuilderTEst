using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseFollow : Singleton<MouseFollow>
{
    [SerializeField] private GameObject _mainBody;
    private GameObject _currentSelectedItem;
    private float _zDistance;

    public void SetSelectedItem(GameObject newItem)
    {
        if (_currentSelectedItem != null)
        {
            Destroy(_currentSelectedItem);
        }
        _currentSelectedItem = newItem;
    }
    private void Start()
    {
        _zDistance = Camera.main.WorldToScreenPoint(_mainBody.transform.position).z;
    }
    private void Update()
    {
        FollowMouse();
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            PlaceItem();
        }
    }
    private void FollowMouse()
    {
        if (_currentSelectedItem == null)
            return;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _zDistance));
        _currentSelectedItem.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);

    }
    private void PlaceItem()
    {
        if (_currentSelectedItem == null) return;
        ShipAssembler.Instance.SetItem(_currentSelectedItem.transform);
        _currentSelectedItem = null;
    }
}
