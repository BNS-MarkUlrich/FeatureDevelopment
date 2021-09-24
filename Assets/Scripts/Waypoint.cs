using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    /// <summary>
    /// Gets the position of the waypoint
    /// </summary>
    /// <returns>The location of the waypoint</returns>
    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
