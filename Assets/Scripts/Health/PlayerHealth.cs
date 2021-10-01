using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] private PlayerHealthUI _playerHealthUI;

    private void Start()
    {
        _playerHealthUI.UpdateUI(CurrentHealth);
    }

    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        _playerHealthUI.UpdateUI(CurrentHealth);
    }

    protected override void DeadState()
    {
        base.DeadState();
        Debug.Log("Herlaad level of laat game over menu zien");
    }
}
