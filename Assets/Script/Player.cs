using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode up;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right) && transform.position.x < 10)
        {
            transform.position += new Vector3(10, 0, 10) * Time.deltaTime; //röra sig åt höger (alex)
        }
        if (Input.GetKey(left) && transform.position.z > -10)
        {
            transform.position += new Vector3(-10, 0, -10) * Time.deltaTime; //röra sig åt vänster (alex)
        }
        if (Input.GetKey(up) && transform.position.y > 5)
        {
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime; //hoppa (alex)
        }
    }
}
