using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;

    private float leftEdge;

    private void Start()
    {
        //access the position of leftEdge via main camera 
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // when pipes reach the end of screen on the left, get destroyed 
        if(transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
