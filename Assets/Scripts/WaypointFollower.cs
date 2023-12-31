using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoint;
    private int CurrentWaypointIndex = 0;
    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if (Vector2.Distance(waypoint[CurrentWaypointIndex].transform.position,transform.position)<.1f)
        {
            CurrentWaypointIndex++;
            if(CurrentWaypointIndex >= waypoint.Length) 
            {
                CurrentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoint[CurrentWaypointIndex].transform.position,Time.deltaTime*speed); 
    }
}
