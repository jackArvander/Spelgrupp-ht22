using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPHMovements : MonoBehaviour
{
    [SerializeField] KeyCode right;
    [SerializeField] KeyCode left;
    [SerializeField] KeyCode jump;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void ResetPlayer()
    {
        transform.position = new Vector3(1, -3, 0);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DeathCol")
        {
            ResetPlayer();//Återställer spelarens position när den colliderar med "DeathCol"-taggat object (dvs när den faller ner i ett hål) -Arvid
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(jump))
        {
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime;
            //Bara skit som får test-spelaren att röra på sig så att jag kan testa scroll-funktion mm. -Arvid
        }
    }
}
