using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject car;
    public GameObject empty;
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(car.transform);
        float distanceToMove = Mathf.Abs(Vector3.Distance(transform.position, empty.transform.position) * speed);
        transform.position = Vector3.MoveTowards(transform.position, empty.transform.position, distanceToMove * Time.fixedDeltaTime);
        
    }
}
