using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] bool isPlaceable;
    public bool IsPlaceable { get { return isPlaceable; } }

    Tower tower;

    void Start()
    {
        tower = GetComponent<Tower>();
    }

    void OnMouseDown() 
    {
        if(isPlaceable)
        {
            bool isPlaced = towerPrefab.PlaceTower(towerPrefab, transform.position);
            isPlaceable = !isPlaced;
        }
    }
}
