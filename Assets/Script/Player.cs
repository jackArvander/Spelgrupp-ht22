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
        if (Input.GetKey(right) && transform.position.x < 50)
        {
            transform.position += new Vector3(10, 0, 0) * Time.deltaTime; //move right (alex)
        }
        if (Input.GetKey(left) && transform.position.z > -20)
        {
            transform.position += new Vector3(-10, 0, 0) * Time.deltaTime; //move left (alex)
        }
        if (Input.GetKey(up) && transform.position.y < 3)
        {
            transform.position += new Vector3(0, 10, 0) * Time.deltaTime; //hoppa (alex)
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
           Destroy(this.gameObject); //player dies when touches wall (alex)
        }
    }

}
