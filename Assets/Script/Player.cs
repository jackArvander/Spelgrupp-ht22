using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
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
            transform.position += new Vector3(10, 0, 0) * Time.deltaTime; //röra sig åt höger (alex)
        }
        if (Input.GetKey(left) && transform.position.z > -20)
        {
            transform.position += new Vector3(-10, 0, 0) * Time.deltaTime; //röra sig åt vänster (alex)
        }
        if (Input.GetKey(up) && transform.position.y < 3)
        {
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime; //hoppa (alex)
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
           Destroy(this.gameObject); //gör så att spelaren dör när den nuddar väggen (alex)
        }
    }

}
