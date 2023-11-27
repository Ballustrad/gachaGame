using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class SummonSystem : MonoBehaviour
{

    public void Start()
    {
        foreach(var item in tierTable)
        {
            total += item;
        }

        
    }

    

    public List<CharacterObject> tier1List = new List<CharacterObject>();
    public List<CharacterObject> tier2List = new List<CharacterObject>();
    public List<CharacterObject> tier3List = new List<CharacterObject>();

    public int total;
    public int randomNumber;

    public int[] tierTable =
    {
        65, //tier 1
        25, //tier 2
        10, //tier 3
    };
    
    public void Summon()
    {
        randomNumber = Random.Range(0, total);
        
        for(int i = 0; i < tierTable.Length; i++) 
        {
        
        }
        foreach(var weight in tierTable)
        {
            if (randomNumber <= weight)
            {
                Debug.Log("Award: " + weight);
            }
            else
            {
                randomNumber -= weight;
            }

        }
    }
    
}
