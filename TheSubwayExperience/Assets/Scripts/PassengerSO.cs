using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PassengerSO", order = 1)]
public class PassengerSO : ScriptableObject
{
    public string passengerName;
    public GameObject characterObj;
}
