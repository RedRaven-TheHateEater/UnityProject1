using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eater : MonoBehaviour
{
    private Player _player;

    private void Start()
    {
        _player = gameObject.GetComponent<Player>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        _player._foodGenerator.FoodList.Remove(collision.gameObject);
        Destroy(collision.gameObject);
    }
}
