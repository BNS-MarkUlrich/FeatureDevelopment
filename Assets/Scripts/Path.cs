using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Waypoint[] _waypoints;

    /// <summary>
    /// Get the start of the path
    /// </summary>
    /// <returns>First waypoint</returns>
    public Waypoint GetPathStart()
    {
        return _waypoints[0];
    }

    /// <summary>
    /// Get the end of the path
    /// </summary>
    /// <returns>Last waypoint</returns>
    public Waypoint GetPathEnd()
    {
        return _waypoints[_waypoints.Length - 1];
    }

    /// <summary>
    /// Get the next waypoint
    /// </summary>
    /// <param name="currentWaypoint">What is the current waypoint?</param>
    /// <returns>The next Waypoint</returns>
    public Waypoint GetNextWaypoint(Waypoint currentWaypoint)
    {
        // Below line is placeholder to prevent errors, edit later
        for (int i = 0; i < _waypoints.Length; i++)
        {
            if (i == _waypoints.Length - 1)
            {
                return null;
            }
            else if (currentWaypoint == _waypoints[i])
            {
                return _waypoints[++i];
            }
        }
        return null;
    }
}
