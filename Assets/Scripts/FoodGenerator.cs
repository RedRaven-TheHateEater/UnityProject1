using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    public GameObject Food;
    public List<GameObject> FoodList;
    public float time = 0;

    void Update()
    {
        if (time < 1) { time += Time.deltaTime; } else { time = 0; Generate(); }
    }
    public void Generate()
    {
        FoodList.Add(Instantiate(Food, transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0), Quaternion.identity));
        
    }
}
