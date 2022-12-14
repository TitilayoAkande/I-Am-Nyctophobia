using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeTester : MonoBehaviour
{
    public ScreenShake  ScreenShake;
    public float duration = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            ScreenShake.Shake(duration);
        }
    }
}
