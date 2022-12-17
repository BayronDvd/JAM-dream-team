using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EnemyBehavior : Enemy
{
    private int baseDamage;
    public int BaseDamage => baseDamage;
    
    public void Initialize(int _baseDamage)
    {
        baseDamage = _baseDamage;
    }
    internal void Update()
    {
        SimpleAttack();
    }

    protected override void SimpleAttack()
    {
        return;
    }
}
