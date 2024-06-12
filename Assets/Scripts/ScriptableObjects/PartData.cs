using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Part", menuName = "ScriptableObjects/Part/Part", order = 1)]
public class PartData : ScriptableObject
{
    public GameObject art;
    public Stats stats;
}
[System.Serializable]

public class Stats
{
    public string name;
    public int hp;
}