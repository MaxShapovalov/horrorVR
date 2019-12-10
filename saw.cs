using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw : MonoBehaviour
{
    // Start is called before the first frame update
    float startPos;
    int direction=1;
    
    void Start()
    {
        startPos=this.transform.position.x;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.right* direction * Time.deltaTime);

        if (this.transform.position.x > startPos + 1.5) {
            direction = Random.Range(-1, -3);
        }
        if (this.transform.position.x < startPos - 1.5)
        {
            direction = Random.Range(1,3);
        }
        
        
    }
}
