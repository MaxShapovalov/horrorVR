using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using OVRTouchSample;
using System;


public class playerCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float jumpForce = 10.0f;
    public GameObject blood;
    CharacterController controller;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.GetDown(OVRInput.Button.One)&& OVRInput.GetDown(OVRInput.Button.Two))
        {
            SceneManager.LoadScene("vr");
            //Instantiate(myPrefab, new Vector3(0, 20, 0), Quaternion.identity);
            //rb.AddForce(new Vector3(0,jumpForce, 0), ForceMode.Impulse);
        }
        controller = GetComponent<CharacterController>();
        //controller.height = 2.0f;

    }
    void OnTriggerEnter(Collider collision)
    {

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "trap")
        {
            Instantiate(blood, new Vector3(this.transform.position.x, -0.5f, this.transform.position.z), Quaternion.Euler(90f, 0f, 0f));
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
        }
        if (collision.gameObject.tag == "vault")
        {
            SceneManager.LoadScene("vr");
        }
       
    }
} 

