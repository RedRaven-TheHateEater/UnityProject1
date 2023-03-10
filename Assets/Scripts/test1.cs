using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static byte Mode = 2;
   


    void Start()
    {
        

    }
    public static void ChangeMode(byte Byte_NewMode) {
        Mode = Byte_NewMode;
        Debug.Log("Теперь режим: "+Mode);
    }
    //
    //Random.Range(-10.0f, 10.0f)
    //
    //
    //
    //
    //
    //
    //
    //
    //
    void Update()
    {
        
    }
}
