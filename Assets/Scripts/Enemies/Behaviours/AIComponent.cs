using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIComponent : MonoBehaviour
{
    public EnemyBehavior enemyBehavior;
    public EnemyData enemyData;

    void Start()
    {
        enemyBehavior.Initialize(enemyData.baseDamage);
    }

    void Update()
    {
        enemyBehavior.Update();
    }
}
