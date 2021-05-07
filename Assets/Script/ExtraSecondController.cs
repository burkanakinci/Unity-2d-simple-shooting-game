using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraSecondController : MonoBehaviour
{
    public PowerUpColorController powerUpColor;
    private BallHealthManager ballHealthManager;
    private GameManager gameManager;
    public GameObject extraTimeAnim;

    
    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();
        ballHealthManager = FindObjectOfType<BallHealthManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {

            gameManager.extraSecondAnimHealth = powerUpColor.powerUpHealth;
            gameManager.extraSecondAnim.GetComponent<SpriteRenderer>().color = this.gameObject.GetComponent<SpriteRenderer>().color;
            gameManager.extraSecondAnim.SetActive(true);
            gameManager.extraSecondSound.Play();
            ballHealthManager.ballHealth = ballHealthManager.ballHealth + powerUpColor.powerUpHealth;
            gameManager.objectPool.Add(this.gameObject);
            gameManager.objectInScene.Remove(this.gameObject);
            this.gameObject.SetActive(false);
        }        
    }
}
