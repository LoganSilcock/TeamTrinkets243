using UnityEngine;
using System.Collections;

public class PlatformMover : MonoBehaviour
{
    public Transform[] waypoints;
    int cur = 0;

    float speed = 1f;

    void FixedUpdate()
    {
        if (transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, waypoints[cur].position, speed);
            //GetComponent<Transform>().position.y; 
        }
        else
        {
            cur = (cur + 1);// % waypoints.Length;
        }
    }
}
