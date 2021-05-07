using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitSecondController : MonoBehaviour
{
    public PowerUpColorController powerUpColor;
    private BallHealthManager ballHealthManager;
    private GameManager gameManager;
    private BallController ballController;
    public GameObject waitSecAnim;
    void Start()
    {

        ballController = FindObjectOfType<BallController>();
        gameManager = FindObjectOfType<GameManager>();
        ballHealthManager = FindObjectOfType<BallHealthManager>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "ball")
        {

            ballController.waitSecondAnimation.GetComponent<SpriteRenderer>().color = this.gameObject.GetComponent<SpriteRenderer>().color;
            gameManager.waitSecondSound.Play();
            ballController.waitSecond = powerUpColor.powerUpHealth ;
            ballController.wait = true;
            ballController.currentBallState = BallController.ballState.wait;
            gameManager.objectPool.Add(this.gameObject);
            gameManager.objectInScene.Remove(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
