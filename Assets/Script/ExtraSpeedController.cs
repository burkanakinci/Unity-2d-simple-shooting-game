using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraSpeedController : MonoBehaviour
{
    public PowerUpColorController powerUpColor;
    private BallHealthManager ballHealthManager;
    private GameManager gameManager;
    void Start()
    {

        ballHealthManager = FindObjectOfType<BallHealthManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {

            gameManager.extraSpeedSound.Play();
            ballHealthManager.extraSpeed = powerUpColor.powerUpHealth;
            Time.timeScale = 2.0f;
            gameManager.objectPool.Add(this.gameObject);
            gameManager.objectInScene.Remove(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
