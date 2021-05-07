using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBallController : MonoBehaviour
{

    private void OnEnable()
    {

        currentBallState = ballState.aim;
        arrow.GetComponent<LineRenderer>().startColor = this.gameObject.GetComponent<SpriteRenderer>().color;
        arrow.GetComponent<LineRenderer>().endColor = new Color(0,0,0,0);
    }
    public enum ballState
    {
        aim,
        fire
    }

    public AudioSource extraBallShotSound;
    public ballState currentBallState;
    public Rigidbody2D ball;
    private Vector2 mouseStartPosition, mouseEndPosition;
    private float ballVelocityX, ballVelocityY;
    public float constantSpeed = 18;
    public GameObject arrow;
    private BallHealthManager ballHealthManager;
    private BallController ballController;
    public float extraBallHealth;
    private GameManager gameManager;

    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();
        ballController = FindObjectOfType<BallController>();
        ballHealthManager = FindObjectOfType<BallHealthManager>();

        arrow.SetActive(false);

        currentBallState = ballState.aim;
    }

    void Update()
    {

        switch (currentBallState)
        {
            case ballState.aim:

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
                break;
            case ballState.fire:
                if (Time.timeScale == 1.0f)
                {

                    extraBallHealth -= Time.deltaTime;
                }
                if (Time.timeScale == 2.0f)
                {

                    extraBallHealth -= (Time.deltaTime / 2);
                }
                break;
            default:
                break;
        }

        if (ballController.currentBallState==BallController.ballState.aim||extraBallHealth<=0)
        {

            this.gameObject.SetActive(false);
        }
    }

    public void MouseClicked()
    {

        mouseStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void MouseDragged()
    {

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

        extraBallShotSound.Play();
        currentBallState = ballState.fire;
    }
}
