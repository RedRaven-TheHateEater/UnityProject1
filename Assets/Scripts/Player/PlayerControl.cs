using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool On = false;
    bool Clicked = false;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) & !Clicked) { Clicked = true; Click(); }
        else if (!Input.GetMouseButtonDown(0) & Clicked) { Clicked = false; }
    }
    void Click()
    {
        if (On)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 worldPosition = new Vector3(MousePos.x, MousePos.y,0);
                SphereMovement.TargetPos = worldPosition;
            }
        }
    }
}
