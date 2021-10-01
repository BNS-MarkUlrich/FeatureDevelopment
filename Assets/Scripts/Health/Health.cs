using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float _startHealth = 3;
    private float _currentHealth;
    public float CurrentHealth
    {
        get { return _currentHealth; }
    }

    private new MeshRenderer renderer;

    public void Awake()
    {
        _currentHealth = _startHealth;
    }

    public void TakeDamage(float dmg)
    {
        _currentHealth -= dmg;
        HandleTakeDamage();

        if (_currentHealth <= 0)
        {
            DeadState();
        }
    }

    protected virtual void HandleTakeDamage()
    {
        Debug.Log("Ik krijg damage");
    }

    protected virtual void DeadState()
    {
        Debug.Log("Ik ben dood");
    }
}