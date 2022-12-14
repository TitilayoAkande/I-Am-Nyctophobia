using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 scale = transform.localScale;

		if(player.transform.position.x > transform.position.x)
		{
			scale.x = Mathf.Abs(scale.x) * -1;
			
		}
		else
		{
			scale.x = Mathf.Abs(scale.x);
			
		}

		transform.localScale = scale;
    }
}
