using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapspawner : MonoBehaviour
{
    // Start is called before the first frame update
    public int spawnPercent = 50;
    public GameObject trap;
    public GameObject cylinder;
    void Start()
    {
        if (spawnPercent > Random.Range(0, 100)) {
            Instantiate(trap, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            Instantiate(cylinder, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
