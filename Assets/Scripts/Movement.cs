using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject spawnObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(spawnObject, new Vector3(-36.5999985f,0.970000029f,-1.70000005f), Quaternion.identity);
            
        }

        move();
    }

    void move()
    {
        spawnObject.transform.position += new Vector3(0,0,1) * Time.deltaTime * 5f;
    }
}
