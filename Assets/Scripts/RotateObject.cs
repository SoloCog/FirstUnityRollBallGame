using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private float speed = 0.3f;
    private 
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * speed);
    }
}
