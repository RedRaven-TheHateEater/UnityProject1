using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControl : MonoBehaviour
{
    public bool On = false;

    public Player player;
    void Start()
    {
        player = gameObject.GetComponent<Player>();
    }

    void Update()
    {
        if (On)
        {
            if (player.foodGenerator.FoodList.Count>0)
            {
                SphereMovement.TargetPos = FindClosest().transform.position;
            }
        }
    }
    GameObject FindClosest()
    {
        GameObject Closest = player.foodGenerator.FoodList[0];
        foreach (GameObject i in player.foodGenerator.FoodList.ToArray())
        {
            if (Vector3.Distance(i.transform.position, transform.position) < Vector3.Distance(Closest.transform.position, transform.position)) { Closest = i; }
        }
        return Closest;
    }
}
