using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    // Start is called before the first frame update
    //public int Spikerange = 2;
    

    private int trapState=1;
    public float spikeMin = 4.0f;
    public float spikeMax = 8.0f;
    public GameObject theSpike;

    public Transform player;
    Vector3 obj;
    Vector3 playerPos;
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
        //if (Vector3.Distance(playerPos, obj) < Spikerange && trapState == 1)
        //{
        //    StartCoroutine(spike());
        //}
        if (trapState == 1) {
            StartCoroutine(spike());
        }
    }

    //IEnumerator spike()
    //{
    //        trapState = 0;
    //        yield return new WaitForSeconds(Spikerange);

    //        Instantiate(theSpike, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(90f, 0f, 0f));
    //        yield return new WaitForSeconds(10);
    //        trapState = 1;
    //}
    IEnumerator spike()
    {

        trapState = 0;
        
        Instantiate(theSpike, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(90f, 0f, 0f));
        yield return new WaitForSeconds(Random.Range(spikeMin,spikeMax));
        trapState = 1;
        
    }

}
