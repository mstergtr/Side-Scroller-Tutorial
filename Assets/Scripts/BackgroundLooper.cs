using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLooper : MonoBehaviour
{
    public float scrollSpeed = 0.5f;

    public float xRepeatPoint = -3.0f;
    public float xResetPoint = 3.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x -= scrollSpeed * Time.deltaTime;

        if (pos.x <= xRepeatPoint)
        {
            pos.x = xResetPoint;
        }

        transform.position = pos;
    }
}
