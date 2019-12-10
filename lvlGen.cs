using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlGen : MonoBehaviour
{
    public float startX=0;
    public float downPercent = 40;
    public float gridSizeX = 100;
    public float gridSizeZ = 3;

    public float currentX = 0;
    public float currentZ = 0;

    public float nextDir = 2;
    public float xDir = 0;
    public float lastDir;

    public int roomScale = 5;
    public int roomSelect = 0;

    public GameObject room1;
    public GameObject room2;
    public GameObject door;
    public GameObject wallbreaker;

    // Start is called before the first frame update
    void Start()
    {
        while (currentZ < gridSizeZ*roomScale)
        {
            
            
            if (nextDir > downPercent)
            {
                if (xDir == 0 && lastDir != 1 && currentX > 0)
                {
                    currentX -= 1 * roomScale;
                    lastDir = 0;
                    //Instantiate(room1, new Vector3(currentX, 0, currentZ), Quaternion.identity);
                    roomSelect = Random.Range(0, 2);
                    if (roomSelect == 1)
                    {
                        Instantiate(room1, new Vector3(currentX, 0, currentZ), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(room2, new Vector3(currentX, 0, currentZ), Quaternion.identity);
                    }
                    Instantiate(wallbreaker, new Vector3(currentX + roomScale/2, 0, currentZ), Quaternion.identity);
                }

                if (xDir == 1 && lastDir != 0 && currentX < gridSizeX - 1)
                {
                    currentX += 1 * roomScale;
                    lastDir = 1;

                    roomSelect = Random.Range(0, 2);
                    if (roomSelect == 1)
                    {
                        Instantiate(room1, new Vector3(currentX, 0, currentZ), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(room2, new Vector3(currentX, 0, currentZ), Quaternion.identity);
                    }
                    Instantiate(wallbreaker, new Vector3(currentX-roomScale/2, 0, currentZ), Quaternion.identity);

                }
                

            }
            else
            {
                
                currentZ += 1 * roomScale;
                
                    Instantiate(room1, new Vector3(currentX, 0, currentZ), Quaternion.identity);
                Instantiate(wallbreaker, new Vector3(currentX, 0, currentZ-roomScale/2), Quaternion.identity);
                lastDir = 2;
            }
            
            Debug.Log("xdir:"+xDir);
            nextDir = Random.Range(0, 100);
            xDir = Random.Range(0, 2);
        }
        Instantiate(door, new Vector3(currentX+0.4f, -1.25f, currentZ + 2.02f), Quaternion.Euler(0f, 180f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


