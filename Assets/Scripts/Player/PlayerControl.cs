using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private bool _on = false;
    private bool _clicked = false;
    private SphereMovement _sphereMovement;

    private void Start()
    {
        _sphereMovement = gameObject.GetComponent<SphereMovement>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) & !_clicked)
        {
            _clicked = true;
            Click();
        }
        else if (!Input.GetMouseButtonDown(0) & _clicked)
        {
            _clicked = false;
        }
    }

    private void Click()
    {
        if (_on)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 worldPosition = new Vector3(MousePos.x, MousePos.y, 0);
                _sphereMovement.MovementTargetPosition = worldPosition;
            }
        }
    }

    public void Turn(bool On)
    {
        _on = On;
    }
}
