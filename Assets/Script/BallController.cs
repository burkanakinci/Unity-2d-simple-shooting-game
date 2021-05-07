
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallController : MonoBehaviour
{
    public enum ballState
    {
        aim,
        fire,
        wait,
    }
    public bool isGameActive;
    public ballState currentBallState;
    public Rigidbody2D ball;
    private Vector2 mouseStartPosition, mouseEndPosition;
    private float ballVelocityX, ballVelocityY;
    public float constantSpeed = 18;
    public GameObject arrow;
    public float waitSecond;
    public bool wait;
    public GameObject ballAimObject;
    private GameManager gameManager;
    public AudioSource ballSound;
    private float slowDownFactor=0.05f;
    public GameObject waitSecondAnimation;
    public GameObject tutorialFire;
    public GameObject redirectText;
    private bool tutorialFireBool;

    void Start()
    {

        redirectText.SetActive(false);

        tutorialFireBool = true;
        tutorialFire.SetActive(false);

        waitSecondAnimation.SetActive(false);

        gameManager = FindObjectOfType<GameManager>();

        arrow.SetActive(false);

        currentBallState = ballState.aim;

        wait = false;
        waitSecond = 0;

        //isGameActive = true;

        ballAimObject.SetActive(true);
    }

    void Update()
    {
        
        if(isGameActive)
        {

            switch (currentBallState)
            {
               
                case ballState.aim:
                    
                    Time.timeScale = 1.0f;
                    Time.fixedDeltaTime = Time.timeScale * .02f;

                    //transform.position = new Vector3(0, -4, 0);
                    ball.velocity = 0 * ball.velocity;
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(0,-4,0), 20f * Time.deltaTime);
                    
                    ballAimObject.SetActive(true);
                    waitSecondAnimation.SetActive(false);
                    if(transform.position==new Vector3(0f,-4f,0f))
                    {

                        if (Input.GetMouseButtonDown(0))
                        {

                            MouseClicked();
                        }

                        if (Input.GetMouseButton(0))
                        {

                            MouseDragged();
                        }

                        if (Input.GetMouseButtonUp(0))
                        {

                            ReleaseMouse();
                        }
                    }


                    break;
                case ballState.fire:

                    if(tutorialFireBool)
                    {

                        Time.timeScale = 0.1f;
                        Time.fixedDeltaTime = Time.timeScale * 0.02f;
                        Invoke("TutorialFire1",0.3f);
                        redirectText.SetActive(true);
                        tutorialFireBool = false;
                        tutorialFire.SetActive(true);
                    }

                    ballAimObject.SetActive(false);
                    waitSecondAnimation.SetActive(false);

                    if((!gameManager.extraBall.activeInHierarchy)||
                        ( gameManager.extraBall.activeInHierarchy&&gameManager.extraBall.GetComponent<ExtraBallController>().currentBallState==ExtraBallController.ballState.fire))
                    {

                        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
                        {

                            Time.timeScale = slowDownFactor;
                            Time.fixedDeltaTime = Time.timeScale * .02f;
                        }

                        if (Input.GetMouseButtonDown(0))
                        {

                            MouseClickedOnFire();
                        }

                        if (Input.GetMouseButton(0))
                        {

                            MouseDraggedOnFire();
                        }

                        if (Input.GetMouseButtonUp(0))
                        {

                            ReleaseMouse();
                            gameManager.LevelUp2();
                            Time.timeScale = 1f;
                            Time.fixedDeltaTime = 0.02f;
                            arrow.SetActive(false);
                        }
                    }
                    break;

                case ballState.wait:
                    waitSecondAnimation.SetActive(true);
                    ballAimObject.SetActive(false);
                    if (wait)
                    {

                        waitSecond -= Time.deltaTime;
                        if (waitSecond <= 0 || gameManager.objectInScene.Count <= 0)
                        {
                            wait = false;
                            currentBallState = ballState.fire;
                        }
                    }
                    break;

                default:
                    waitSecondAnimation.SetActive(false);
                    ballAimObject.SetActive(false);
                    break;
            }
        }
        else if(isGameActive==false)
        {

            ballAimObject.SetActive(false);
            currentBallState = ballState.aim;
            ball.transform.position = new Vector3(0,-4,0);
        }
    }

    public void MouseClicked()
    {

        mouseStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void MouseDragged()
    {

        //move to arrow
        arrow.SetActive(true);
        Vector2 tempMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float diffX = mouseStartPosition.x - tempMousePosition.x;
        float diffY = mouseStartPosition.y - tempMousePosition.y;
        if (diffY <= 0)
        {
            diffY = .01f;
        }
        float theta = Mathf.Rad2Deg * Mathf.Atan(diffX / diffY);
        arrow.transform.rotation = Quaternion.Euler(0f, 0f, -theta);

    }

    public void ReleaseMouse()
    {

        arrow.SetActive(false);
        mouseEndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ballVelocityX = (mouseStartPosition.x - mouseEndPosition.x);
        ballVelocityY = (mouseStartPosition.y - mouseEndPosition.y);
        Vector2 tempVelocity = new Vector2(ballVelocityX, ballVelocityY).normalized;
        ball.velocity = constantSpeed * tempVelocity;
        if (ball.velocity == Vector2.zero)
        {
            return;
        }

        currentBallState = ballState.fire;
        ballSound.Play();
    }
    public void MouseClickedOnFire()
    {
        
        mouseStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void MouseDraggedOnFire()
    {

        //move to arrow
        arrow.SetActive(true);
        Vector2 tempMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float diffX = mouseStartPosition.x - tempMousePosition.x;
        float diffY = mouseStartPosition.y - tempMousePosition.y;
        if (diffY <= 0)
        {
            diffY = .01f;
        }
        float theta = Mathf.Rad2Deg * Mathf.Atan(diffX / diffY);
        arrow.transform.rotation = Quaternion.Euler(0f, 0f, -theta);

    }


    private void TutorialFire1()
    {

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
        redirectText.SetActive(false);
        tutorialFire.SetActive(false);
    }

}
