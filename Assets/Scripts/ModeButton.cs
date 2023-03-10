using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeButton : MonoBehaviour
{
    public GameObject playerObject;
    public Player.ControlMode ControlMode;

    public void OnClick()
    {
        //Debug.LogError("смена режима");
        Player player = playerObject.GetComponent<Player>();
        player.ChangeMode(ControlMode);
    }
}
