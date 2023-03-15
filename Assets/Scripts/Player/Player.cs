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
    private AIControl aiControl;
    private PlayerControl playerControl;

    private void Start()
    {
        aiControl = gameObject.GetComponent<AIControl>();
        playerControl = gameObject.GetComponent<PlayerControl>();

        _foodGenerator = _generator.GetComponent<FoodGenerator>();
    }

    public void ChangeControlType(ControlType NewMode)
    {
        playerControl.Turn(false);
        aiControl.Turn(false);
        switch (NewMode)
        {
            case ControlType.None:
                gameObject.GetComponent<SphereMovement>().TargetPos = transform.position;
                break;
            case ControlType.Player:
                playerControl.Turn(true);
                break;
            case ControlType.Auto:
                aiControl.Turn(true);
                break;
        }
    }

}
