using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeControlButton : MonoBehaviour
{

    [SerializeField] private Player _player;
    [SerializeField] private Player.ControlType _controlType;

    private void Awake()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        //Debug.LogError("смена режима");
        _player.ChangeControlType(_controlType);
    }
}
