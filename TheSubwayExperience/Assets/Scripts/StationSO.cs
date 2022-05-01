using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/StationSO", order = 2)]
public class StationSO : ScriptableObject
{
    public string stationName;
    public int timeToStation;
    public int stationOrder;
    public GameObject stationObj;
    public AudioSource stationNameAudio;

}
