using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControl : MonoBehaviour
{
    [SerializeField] private float _seekDelay;

    private bool _on = false;
    private Player _player;
    private float _timer = 0;

    public void Turn(bool On)
    {
        _on = On;
    }

    private void Start()
    {
        _player = gameObject.GetComponent<Player>();
    }

    private void Update()
    {
        if (_on)
        {
            _timer += Time.deltaTime;
            while (_timer >= _seekDelay)
            {
                _timer -= _seekDelay;
                MakeTargetPosition();
            }
        }
    }

    private void MakeTargetPosition()
    {
        List<GameObject> FoodList = _player._foodGenerator.FoodList;
        if (FoodList.Count > 0)
        {
            Vector3 TargetPosition = FoodList[0].transform.position;
            //foreach (GameObject i in FoodList.ToArray())
            //{
            //    if (Vector3.Distance(i.transform.position, transform.position) < Vector3.Distance(TargetPosition, transform.position)) { ClosestPosition = i.transform.position; }
            //}
            gameObject.GetComponent<SphereMovement>().MovementTargetPosition = TargetPosition;
        }
    }
}
