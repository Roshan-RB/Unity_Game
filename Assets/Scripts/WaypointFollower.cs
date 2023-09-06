using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int CurrentWaypointIndex = 0;

    [SerializeField] float speed = 1f;
 
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[CurrentWaypointIndex].transform.position) < 0.1f) 
        {
            CurrentWaypointIndex++;
            if (CurrentWaypointIndex >= waypoints.Length)
            {
                CurrentWaypointIndex = 0;
            }
        }
        transform.position  = Vector3.MoveTowards(transform.position, waypoints[CurrentWaypointIndex].transform.position, speed * Time.deltaTime);
        
    }
}
