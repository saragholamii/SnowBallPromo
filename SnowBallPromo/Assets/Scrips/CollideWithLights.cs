using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithLights : MonoBehaviour
{
    private Vector3 scaleMultiplier = new Vector3(0.997f, 0.997f, 0.997f);

    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.tag == "Light")
        {
            Debug.Log("collide");
            transform.localScale = Vector3.Scale(transform.localScale, scaleMultiplier);
        }  
    }
}
