using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBallPowerUpController : MonoBehaviour
{

    public PowerUpColorController powerUpColor;
    private GameManager gameManager;
    public GameObject extraBall;
    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "ball")
        {
            //ekranda olan extra ball ı sıfırla

            //ekstraball oluştur
            if(gameManager.extraBall.activeInHierarchy)
            {
                gameManager.extraBall.SetActive(false);
            }
            gameManager.extraBall.transform.position = new Vector3(0,-4,3);
            gameManager.extraBall.GetComponent<SpriteRenderer>().color = this.gameObject.GetComponent<SpriteRenderer>().color;
            gameManager.extraBall.GetComponent<ExtraBallController>().extraBallHealth = powerUpColor.powerUpHealth;
            gameManager.extraBall.SetActive(true);
            gameManager.objectPool.Add(this.gameObject);
            gameManager.objectInScene.Remove(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
