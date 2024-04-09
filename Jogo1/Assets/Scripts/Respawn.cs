using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{   
    public float treshold;
    void FixedUpdate(){
        if(transform.position.y <treshold){
            transform.position = new Vector3(0f, 15.9f, -13.9f);
        }
    }
}
