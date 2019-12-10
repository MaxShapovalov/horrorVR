using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public GameObject flash;
    public int lightState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            lightState++;
        }
        if (lightState>1) {
            lightState = 0;
        }
        if (lightState == 0)
        {
            flash.transform.gameObject.SetActive(false);
        }
        else {
            flash.transform.gameObject.SetActive(true);
        }
    }
}
