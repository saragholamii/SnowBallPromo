using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject target;
    private Vector3 distance;
    private Vector3 nextPos;
    private float camX;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - target.transform.position;
        camX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        nextPos = target.transform.position + distance;
        nextPos = new Vector3(camX, nextPos.y, nextPos.z);
        transform.position = nextPos;
    }
}
