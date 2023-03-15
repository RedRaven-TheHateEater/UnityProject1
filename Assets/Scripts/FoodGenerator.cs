using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    [SerializeField] private float _spawnOffset;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private GameObject _food;

    public List<GameObject> FoodList;
    private Vector3 _position;
    private AIControl aIControl;
    private float _timer = 0;

    private void Start()
    {
        FoodList = new List<GameObject>();
        _position = transform.position;
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        while (_timer >= _spawnDelay)
        {
            _timer-= _spawnDelay;
            FoodList.Add(GenerateFood());
        }
    }

    private GameObject GenerateFood()
    {
        GameObject food = Instantiate(_food, _position, Quaternion.identity);
        food.transform.position += new Vector3(Random.Range(-_spawnOffset, _spawnOffset), Random.Range(-_spawnOffset, _spawnOffset), 0);
        return food;
    }
} 
