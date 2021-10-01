using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        // Update je healthbar
    }

    protected override void DeadState()
    {
        base.DeadState();
        Destroy(this.gameObject);
    }
}
