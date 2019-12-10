using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeFall : MonoBehaviour
{
    public float spikeTime=2.0f;
    public float spikeDestroyTime = 2.0f;
    public Rigidbody rb;

    public int Spikerange = 7;
    public Transform player;
    Vector3 obj;
    Vector3 playerPos;

    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        StartCoroutine(spike());


        //player = GameObject.FindWithTag("Player").transform;
        //obj = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        //playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        ////Debug.Log("dist is:" + Vector3.Distance(playerPos, this.transform.position));
        //if (Vector3.Distance(playerPos, obj) < Spikerange)
        //{
        //    audioData = GetComponent<AudioSource>();
        //    audioData.pitch = 1;
        //    audioData.Play(0);
        //}

    }
    void Update() {
        
    }
    IEnumerator spike()
    {

        yield return new WaitForSeconds(spikeTime);
        rb.isKinematic = false;
        audioData = GetComponent<AudioSource>();
        audioData.pitch = 0.7f;
        audioData.Play(0);
        //gameObjectsRigidBody.mass = 5;
        Destroy(gameObject,spikeDestroyTime);

        //player = GameObject.FindWithTag("Player").transform;
        //obj = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        //playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        ////Debug.Log("dist is:" + Vector3.Distance(playerPos, this.transform.position));
        //if (Vector3.Distance(playerPos, obj) < Spikerange)
        //{
        //    audioData = GetComponent<AudioSource>();
        //    audioData.pitch = 0.7f;
        //    audioData.Play(0);
        //}

    }
}
