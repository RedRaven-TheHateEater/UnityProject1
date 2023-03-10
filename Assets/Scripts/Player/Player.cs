using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public byte Mode = 1;
    AIControl aiControl;
    PlayerControl playerControl;

    public GameObject generator;
    public FoodGenerator foodGenerator;

    void Start()
    {
        aiControl = gameObject.GetComponent<AIControl>();
        playerControl = gameObject.GetComponent<PlayerControl>();

        foodGenerator = generator.GetComponent<FoodGenerator>();
    }


    public void ChangeMode(ControlMode NewMode)
    {
        playerControl.On = false;
        aiControl.On = false;
        switch (NewMode)
        {
            case ControlMode.ControlModePlayer:
                playerControl.On = true;
                break;
            case ControlMode.ControlModeNone:
                //ничего не делать
                break;
            case ControlMode.ControlModeAI:
                aiControl.On = true;
                break;
        }
    }
    public enum ControlMode : byte
    {
        ControlModePlayer = 0,
        ControlModeNone = 1,
        ControlModeAI = 2
    }
}
