using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;
using System;

public class rotator : MonoBehaviour
{
    public int range = 10;
    public Transform player;
    Vector3 obj;
    Vector3 playerPos;
    // Start is called before the first frame update
    public float rotatorSpeed = 0.1f;
    float z = 0;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        player = GameObject.FindWithTag("Player").transform;
        obj = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        //Debug.Log("dist is:" + Vector3.Distance(playerPos, this.transform.position));
        if (Vector3.Distance(playerPos, obj) > range)
        {

            
        }
        if (Vector3.Distance(playerPos, obj) < range)
        {
            
                z += rotatorSpeed;
            transform.eulerAngles = new Vector3(0, 0, z);
        }

    }
}
