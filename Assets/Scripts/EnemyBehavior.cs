using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    private Transform target;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        if (target == null)
        {
            Debug.Log("no player in the scene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Debug.Log("no player in the scene");
            return;
        }
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, b, speed * Time.deltaTime);
    }
}
