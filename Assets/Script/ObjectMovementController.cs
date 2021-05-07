using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementController : MonoBehaviour
{
    public enum objectState
    {
        stop,
        move,
        move2
    }
    public objectState currentObjectState;
    private float currentPositionY, currentPositionX;
    private Vector2 movement;
    private bool onesMove;
    private void OnEnable()
    {

        onesMove = true;
        currentPositionY = 0f;
        currentPositionX = 0f;
        currentObjectState = objectState.stop;
    }


    

    void Update()
    {
        if(currentObjectState==objectState.move2)
        {

            if (onesMove)
            {

                currentPositionX = transform.position.x;
                currentPositionY = transform.position.y;
                movement = new Vector2(transform.position.x, transform.position.y - 1f);
                onesMove = false;
            }

            //this.GetComponent<Rigidbody2D>().AddForce(movement*100f);
            transform.position = Vector3.MoveTowards((transform.position),
                new Vector3(currentPositionX, currentPositionY - 1f, transform.position.z),
                (20f * Time.deltaTime));
            //transform.position = new Vector2(transform.position.x, transform.position.y - 2f);       

            if (transform.position.y <= currentPositionY - 1f)
            {

                onesMove = true;
                currentObjectState = objectState.stop;
            }
        }
        if (currentObjectState == objectState.move)
        {
            if(onesMove)
            {

                currentPositionX = transform.position.x;
                currentPositionY = transform.position.y;
                movement = new Vector2(transform.position.x, transform.position.y - 2f);
                onesMove = false;
            }

            //this.GetComponent<Rigidbody2D>().AddForce(movement*100f);
            transform.position = Vector3.MoveTowards((transform.position),
                new Vector3(currentPositionX,currentPositionY-2f,transform.position.z),
                (10f*Time.deltaTime));
            //transform.position = new Vector2(transform.position.x, transform.position.y - 2f);       

            if (transform.position.y<=currentPositionY-2f)
            {

                onesMove = true;
                currentObjectState = objectState.stop;
            }
            
        }
    }
}
