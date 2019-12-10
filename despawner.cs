using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawner : MonoBehaviour
{
    // Start is called before the first frame update
    public int range = 10;
    public Transform player;
    Vector3 obj;
    Vector3 playerPos;
    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player").transform;
        obj = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        Debug.Log("dist is:" + Vector3.Distance(playerPos, this.transform.position));
        if (Vector3.Distance(playerPos, obj) > range)
        {

            rend.enabled = false;
        }
        if (Vector3.Distance(playerPos, obj) < range)
        {
            rend.enabled = true;
        }
    }

   

}
