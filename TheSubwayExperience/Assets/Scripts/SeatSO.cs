using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SeatSO", order = 3)]

public class SeatSO : ScriptableObject
{
    public bool isOccupied;
    public GameObject seatObj;
}
