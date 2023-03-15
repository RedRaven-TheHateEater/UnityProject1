using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum ControlType : byte
    {
        None = 0,
        Player = 1,
        Auto = 2
    }

    [SerializeField] private GameObject _generator;

    public FoodGenerator _foodGenerator;
    private AIControl _aiControl;
    private PlayerControl _playerControl;

    private void Start()
    {
        _aiControl = gameObject.GetComponent<AIControl>();
        _playerControl = gameObject.GetComponent<PlayerControl>();

        _foodGenerator = _generator.GetComponent<FoodGenerator>();
    }

    public void ChangeControlType(ControlType NewControlType)
    {
        _playerControl.Turn(false);
        _aiControl.Turn(false);
        switch (NewControlType)
        {
            case ControlType.None:
                gameObject.GetComponent<SphereMovement>().MovementTargetPosition = transform.position;
                break;
            case ControlType.Player:
                _playerControl.Turn(true);
                break;
            case ControlType.Auto:
                _aiControl.Turn(true);
                break;
        }
    }

}
