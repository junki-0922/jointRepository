using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barManager : MonoBehaviour
{
        
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x, 0, 0) * Time.deltaTime * 12; 
    }
}
