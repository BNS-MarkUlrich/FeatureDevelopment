using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalThreshold;

    [SerializeField] private float _damage = 1;

    private float followerHeight;
    private Path _path;
    private Waypoint _currentWaypoint;

    private void Start()
    {
        SetupPath();
        followerHeight = transform.position.y;
    }

    /// <summary>
    /// Responsible for collecting the path from Path
    /// </summary>
    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
    }

    private void Update()
    {
        Vector3 distanceToNextWaypoint = new Vector3(_currentWaypoint.transform.position.x, followerHeight, _currentWaypoint.transform.position.z);
        float distance = Vector3.Distance(transform.position, distanceToNextWaypoint);

        if (distance <= _arrivalThreshold)
        {
            
            if (_currentWaypoint == _path.GetPathEnd())
            {
                PathComplete();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
            }
        }
        else
        {
            transform.LookAt(distanceToNextWaypoint);
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }

    /// <summary>
    /// Decides what happens after Pathfollower completes path
    /// </summary>
    private void PathComplete()
    {
        Destroy(this.gameObject);
        Debug.Log("Ik ben bij het eindpunt");
        FindObjectOfType<PlayerHealth>().TakeDamage(_damage);
    }
}
