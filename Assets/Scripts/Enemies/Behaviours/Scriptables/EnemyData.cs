using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyData", menuName = "Scriptables/Enemies")]
public class EnemyData : ScriptableObject
{
    public int baseDamage = 2;
    public float criticalMultiplier = 0.1f; 
}
