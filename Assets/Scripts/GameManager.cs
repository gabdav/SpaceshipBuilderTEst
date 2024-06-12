using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    void Start()
    {
        ShipAssembler.Instance.Init();
        UIManager.Instance.Init(ShipAssembler.Instance.GetCategories());
    }
}
