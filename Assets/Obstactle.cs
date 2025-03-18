using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstactle : MonoBehaviour
{
    public float obstacleSpeed = 7.0f;

    public float obstacleDistance = 9;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * obstacleSpeed * Time.deltaTime;

        if (transform.position.x <= -obstacleDistance)
        {
            Destroy(gameObject);
        }
    }
}
