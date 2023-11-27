using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SummonTable : ScriptableObject
{
    [Serializable]
    public class Summon
    {
        public CharacterObject summoned;
        public int probality;

    }
    public List<Summon> table;

    public CharacterObject GetSummon()
    {
        int roll = UnityEngine.Random.Range(0, 100);
        for (int i = 0; i < table.Count; i++)
        {
            roll -= table[i].probality;
            if (roll < 0 )
            {
               return table[i].summoned;
            }
        }

             return table[0].summoned;
    }
}
