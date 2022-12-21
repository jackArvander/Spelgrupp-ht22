using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromMovement : MonoBehaviour
{
    [SerializeField]
    public Vector3 targetPos1; //positioner den r�r sig mellan
    [SerializeField]
    public Vector3 targetPos2;
    [SerializeField]
    public float speed = 1f;
    public bool canMove;
    public bool firstMove; //startposition
    void Start()
    {

        firstMove = true;

    }
    void Update()
    {
        if (transform.position == targetPos1) 
        {
            firstMove = false;
        }
        if (transform.position == targetPos2)
        {
            firstMove = true;
        }
        if (canMove) // Om den kan r�ra sig r�r den sig till punkt A, n�r p� A g� till B
        {
            if (firstMove)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos1, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos2, speed * Time.deltaTime);
            }
        }
    }
}

