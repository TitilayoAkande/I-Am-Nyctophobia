using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
   Transform target;
   Vector3 initalPos;
   float pendingShakeDuration = 0f;
   bool isShaking = false;

    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<Transform>();
        initalPos = target.localPosition;
    }
    public void Shake (float duration)
    {
        if(duration > 0)
        {
            pendingShakeDuration += duration;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(pendingShakeDuration > 0 && !isShaking)
        {
            StartCoroutine(Doshake());
        }
    }
    IEnumerator Doshake()
     {
        isShaking = true;

        var StartTime = Time.realtimeSinceStartup;
        while(Time.realtimeSinceStartup <StartTime + pendingShakeDuration)
        {
           var randomPoint = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1), initalPos.z); 
           target.localPosition = randomPoint;
           yield return null;    
        }

        pendingShakeDuration = 0f;
        target.localPosition = initalPos;
        isShaking = false;
     }

    
}
