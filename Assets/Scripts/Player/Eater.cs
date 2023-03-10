using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eater : MonoBehaviour
{
    public Player player;


    void Start()
    {
        player = gameObject.GetComponent<Player>();
    }
    void Update()
    {
        TryToEat();
        
    }
    public void TryToEat()
    {
        for (int i = 0; i < player.foodGenerator.FoodList.Count; i++)
        {
            GameObject I = player.foodGenerator.FoodList[i];

            if (Vector3.Distance(I.transform.position, gameObject.transform.position) < 1) { Destroy(I); player.foodGenerator.FoodList.Remove(I); }


        }
    }

}
