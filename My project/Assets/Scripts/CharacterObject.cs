using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CharacterStats
{
    public float healthPoints;
    public float defensePoints;
    public float damagePoints;
    public float criticalChance;
    public float criticalDamage;
    public float speed;
    public bool tier1;
    public bool tier2;
    public bool tier3;

}
[CreateAssetMenu]
public class CharacterObject : ScriptableObject
{
    public string Name;
    public CharacterStats stats;
    public Sprite keyArt;
    public Sprite inGameSprite;
    
}
