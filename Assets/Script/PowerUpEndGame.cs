using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEndGame : MonoBehaviour
{
    private GameManager gameManager;
    private EndGameManager endGameManager;
    private BallController ballController;

    

    void Start()
    {

        ballController = FindObjectOfType<BallController>();
        endGameManager = FindObjectOfType<EndGameManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (this.gameObject.transform.position.y <= -1.55f && this.gameObject.tag == "brick")
        {


            //Debug.Log((GameObject.Find("LimiterObject")).transform.position);
            GameObject.Find("LimiterObject").GetComponent<SpriteRenderer>().color = new Color(255,0,0,255);
            Time.timeScale = 0.1f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
        if (this.gameObject.transform.position.y<= 0)
        {

            endGameManager.endGameAnim.SetActive(true);
        }
        if(this.gameObject.transform.position.y<=-2)
        {

            if (this.gameObject.tag=="brick")
            {

                Time.timeScale = 1f;
                Time.fixedDeltaTime = Time.timeScale * 0.02f;
                this.gameObject.GetComponent<BrickColorController>().brickHealth=-1;
                gameManager.mainSceneSound.Stop();
                ballController.isGameActive = false;
                endGameManager.endGameVideoObject.SetActive(true);
                Invoke("EGS",3f);
            }
            else
            {

                gameManager.objectPool.Add(this.gameObject);
                gameManager.objectInScene.Remove(this.gameObject);
                this.gameObject.SetActive(false);
            }

            
        }
    }

    void EGS()
    {

        //endGameManager.endGameAnim.SetActive(false);
        if (gameManager.endGameLimitter)
        {
            GameObject.Find("LimiterObject").GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
        }
        
        endGameManager.endGameVideoObject.SetActive(false);
        endGameManager.endGamePanel.SetActive(true);
        gameManager.objectInScene.Remove(this.gameObject);
    }

    private void OnDisable()
    {
        this.transform.position = new Vector3(-3f,1f,0f);
    }
}
