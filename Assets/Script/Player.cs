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
            transform.position += new Vector3(10, 0, 0) * Time.deltaTime; //r�ra sig �t h�ger (alex)
        }
        if (Input.GetKey(left) && transform.position.z > -20)
        {
            transform.position += new Vector3(-10, 0, 0) * Time.deltaTime; //r�ra sig �t v�nster (alex)
        }
        if (Input.GetKey(up) && transform.position.y < 3)
        {
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime; //hoppa (alex)
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("koll");
        if (collision.gameObject.tag == "Wall")
        {
            print("v�gg");
            Destroy(this.gameObject); //ska g�ra s� att spelaren d�r n�r den nuddar v�ggen, men funkar inte (alex)
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        
    }
}
