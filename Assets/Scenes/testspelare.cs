using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testspelare : MonoBehaviour
{

    [SerializeField]
    KeyCode up;
    [SerializeField]
    KeyCode down;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up) && transform.position.y < 4.504)
        {

            transform.position += new Vector3(0, 5, 0) * Time.deltaTime;
            print("�ker upp");
        }
        // �ker ner
        if (Input.GetKey(down) && transform.position.y > -4.8)
        {
            transform.position += new Vector3(0, -5, 0) * Time.deltaTime;
            print("�ker ner");
        }
        // �ker �t h�ger
        if (Input.GetKey(right) && transform.position.x < 11.30)
        {
            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;

        }
        // �ker mot v�nster
        if (Input.GetKey(left) && transform.position.x > -11.20)
        {
            transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;

        }
    }
}
