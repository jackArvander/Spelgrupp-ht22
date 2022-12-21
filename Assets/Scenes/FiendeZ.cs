using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiendeZ : MonoBehaviour
{
    public GameObject ShootPoint;
    public GameObject fireBall1;
    public GameObject player;
    private Transform target;
    Vector2 dir;
    public float speed;
    public float distanceBetween;
    private float distance;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    public float Force;


    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // har redan best?mt sig att ha spelaren som m?l
        target = GameObject.FindGameObjectWithTag("Player").transform;
        audioSource = GetComponent<AudioSource>();
    }



    // Update is called once per frame
    void Update()
    {
        // följer efter spelaren
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }

        if (Time.time > nextFire)
        {
            if (!fireBall1)
                return;

            nextFire = Time.time + fireRate;
            // skjuter
            GameObject clone = Instantiate(fireBall1, transform.position, transform.rotation);
            Rigidbody2D rb = clone.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.right * 2500 * Time.deltaTime, (ForceMode2D)ForceMode.Impulse);

        }


    }
}
