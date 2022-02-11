using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public GameObject position0;
    public GameObject position1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector2 aiPosition = transform.position;
        //transform.position = Vector2.MoveTowards(transform.position, position0.transform.position, Time.deltaTime);
        if (transform.position.x < position0.transform.position.x) {
            aiPosition.x += (1 * Time.deltaTime);
            transform.position = aiPosition;
            Debug.Log("going right");
        }
        else 
        {
            aiPosition.x -= (1 * Time.deltaTime);
            transform.position = aiPosition;
            Debug.Log("going left");
        }

        if (transform.position.y < position0.transform.position.y)
        {
            transform.position += (Vector3) Vector2.up * (1 * Time.deltaTime);
            Debug.Log("going up");
        }
        else
        {
            transform.position -= (Vector3)Vector2.up * (1 * Time.deltaTime);
            Debug.Log("going down");
        }
        */
        Vector2 directToPos0 = position0.transform.position - transform.position;
        directToPos0.Normalize();
        transform.position += (Vector3)directToPos0 * (1 * Time.deltaTime);
    }
}
