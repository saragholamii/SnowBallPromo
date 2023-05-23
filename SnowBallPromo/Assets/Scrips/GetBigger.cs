using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBigger : MonoBehaviour
{
    private float clockCounter = 0f;
    private Vector3 scaleMultiplier = new Vector3(1.005f, 1.005f, 1.005f);
   
    void Update()
    {
        if(clockCounter >= 0.1f)
        {
            GoBigger();
            clockCounter = 0f;
        }
        clockCounter += Time.deltaTime;
    }

    private void GoBigger()
    {
        transform.localScale = Vector3.Scale(transform.localScale, scaleMultiplier);
    }
}
