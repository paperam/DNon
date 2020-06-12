using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int Speed=1;
   
    
    void Start()
    {
       
    }

  
    void Update()
    {
        //조작
       if(Input.GetAxisRaw("Horizontal")>0 || Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * Speed *Time.deltaTime,0f,0f));
        }
       if (Input.GetAxisRaw("Vertical") > 0 || Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * Speed *Time.deltaTime,0f));
        }
       
       
    }

  }
