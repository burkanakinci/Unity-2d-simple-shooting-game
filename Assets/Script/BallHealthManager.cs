using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallHealthManager : MonoBehaviour
{
    public Text ballHealthText;
    public float ballHealth;
    private GameManager gameManager;
    private BallController ballController;
    public float extraSpeed;
    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();
        ballController = FindObjectOfType<BallController>();

        extraSpeed = 0;

    }

    void Update()
    {

        int iBallHealth = (int)ballHealth;
        ballHealthText.text = (iBallHealth).ToString();

        if (ballController.currentBallState == BallController.ballState.fire)
        {

            if (Time.timeScale == 1.0f)
            {

                ballHealth -= Time.deltaTime;
            }
           if (Time.timeScale == 2.0f)
            {

                ballHealth -= (Time.deltaTime/2);
                extraSpeed -= (Time.deltaTime / 2);
                if (extraSpeed <= 0)
                {
                    Time.timeScale = 1.0f;
                }
            }
        }
        if (ballHealth <= 0)
        {

            //ballController.gameObject.SetActive(false);
            //ballController.gameObject.transform.position = Vector3.MoveTowards(ballController.transform.position,
            //    new Vector3(0,-4,0),10f*Time.deltaTime);
            //ballController.gameObject.transform.position = new Vector3(0,-4,0);
            ballController.currentBallState = BallController.ballState.aim;
            ballHealth = gameManager.level + 3;
            gameManager.LevelUp();
            ballController.gameObject.SetActive(true);
        }
        

    }
}
