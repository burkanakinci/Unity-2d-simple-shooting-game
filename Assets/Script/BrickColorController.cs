using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickColorController : MonoBehaviour
{
    public int brickHealth;
    public string brickColorNum;
    public Gradient[] gradients;
    public SpriteRenderer spriteRenderer;
    private GameManager gameManager;
    public GameObject DestroyAnim;
    private BallController ballController;

    private void Start()
    {

        ballController = FindObjectOfType<BallController>();
    }
    private void OnEnable()
    {

        gameManager = FindObjectOfType<GameManager>();

        if (gameManager.level <= 3)
        {
            spriteRenderer.color = gradients[0].Evaluate(1f);
            brickColorNum = "zero";
        }
        else if (gameManager.level > 3 && gameManager.level <= 6)
        {
            int colorRandom = Random.Range(0, 2);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                brickColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                brickColorNum = "one";
            }
        }
        else if (gameManager.level > 6&& gameManager.level <= 9)
        {
            int colorRandom = Random.Range(0, 3);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                brickColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                brickColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                brickColorNum = "two";
            }
        }
        else if (gameManager.level > 9 && gameManager.level <= 12)
        {
            int colorRandom = Random.Range(0, 4);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                brickColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                brickColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                brickColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                brickColorNum = "three";
            }
        }
        else if (gameManager.level > 12 && gameManager.level <= 15)
        {
            int colorRandom = Random.Range(0, 5);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                brickColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                brickColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                brickColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                brickColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                brickColorNum = "four";
            }
        }
        else if (gameManager.level > 15 && gameManager.level <= 18)
        {
            int colorRandom = Random.Range(0, 6);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                brickColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                brickColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                brickColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                brickColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                brickColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                brickColorNum = "five";
            }
        }
        else if (gameManager.level > 18 && gameManager.level <= 21)
        {
            int colorRandom = Random.Range(0, 7);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                brickColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                brickColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                brickColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                brickColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                brickColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                brickColorNum = "five";
            }
            else if (colorRandom == 6)
            {
                spriteRenderer.color = gradients[6].Evaluate(1f);
                brickColorNum = "six";
            }
        }
        else if (gameManager.level > 21 && gameManager.level <= 24)
        {
            int colorRandom = Random.Range(0, 8);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                brickColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                brickColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                brickColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                brickColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                brickColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                brickColorNum = "five";
            }
            else if (colorRandom == 6)
            {
                spriteRenderer.color = gradients[6].Evaluate(1f);
                brickColorNum = "six";
            }
            else if (colorRandom == 7)
            {
                spriteRenderer.color = gradients[7].Evaluate(1f);
                brickColorNum = "seven";
            }
        }
        else if (gameManager.level > 24 && gameManager.level <= 27)
        {
            int colorRandom = Random.Range(0, 9);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                brickColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                brickColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                brickColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                brickColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                brickColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                brickColorNum = "five";
            }
            else if (colorRandom == 6)
            {
                spriteRenderer.color = gradients[6].Evaluate(1f);
                brickColorNum = "six";
            }
            else if (colorRandom == 7)
            {
                spriteRenderer.color = gradients[7].Evaluate(1f);
                brickColorNum = "seven";
            }
            else if (colorRandom ==8)
            {
                spriteRenderer.color = gradients[8].Evaluate(1f);
                brickColorNum = "eight";
            }
        }
        else if (gameManager.level > 27)
        {
            int colorRandom = Random.Range(0,10);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                brickColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                brickColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                brickColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                brickColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                brickColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                brickColorNum = "five";
            }
            else if (colorRandom == 6)
            {
                spriteRenderer.color = gradients[6].Evaluate(1f);
                brickColorNum = "six";
            }
            else if (colorRandom == 7)
            {
                spriteRenderer.color = gradients[7].Evaluate(1f);
                brickColorNum = "seven";
            }
            else if (colorRandom == 8)
            {
                spriteRenderer.color = gradients[8].Evaluate(1f);
                brickColorNum = "eight";
            }
            else if (colorRandom == 9)
            {
                spriteRenderer.color = gradients[9].Evaluate(1f);
                brickColorNum = "nine";
            }
        }

        if (brickColorNum == "zero")
        {
            brickHealth = 1;
        }
        else if (brickColorNum == "one")
        {
            brickHealth = 2;
        }
        else if (brickColorNum == "two")
        {
            brickHealth = 3;
        }
        else if (brickColorNum == "three")
        {
            brickHealth = 4;
        }
        else if (brickColorNum == "four")
        {
            brickHealth = 5;
        }
        else if (brickColorNum == "five")
        {
            brickHealth = 6;
        }
        else if (brickColorNum == "six")
        {
            brickHealth = 7;
        }
        else if (brickColorNum == "seven")
        {
            brickHealth = 8;
        }
        else if (brickColorNum == "eight")
        {
            brickHealth = 9;
        }
        else if (brickColorNum == "nine")
        {
            brickHealth = 10;
        }

    }


    void Update()
    {

        switch (brickColorNum)
        {
            case "zero":
                break;

            case "one":
                if (brickHealth == 2)
                {
                    spriteRenderer.color = gradients[1].Evaluate(1f);
                }
                else if (brickHealth == 1)
                {
                    spriteRenderer.color = gradients[1].Evaluate(0f);
                }
                break;

            case "two":
                if (brickHealth == 3)
                {
                    spriteRenderer.color = gradients[2].Evaluate(1f);
                }
                else if (brickHealth == 2)
                {
                    spriteRenderer.color = gradients[2].Evaluate(0.5f);
                }
                else if (brickHealth == 1)
                {
                    spriteRenderer.color = gradients[2].Evaluate(0f);
                }
                break;

            case "three":
                if (brickHealth == 4)
                {
                    spriteRenderer.color = gradients[3].Evaluate(1f);
                }
                else if (brickHealth == 3)
                {
                    spriteRenderer.color = gradients[3].Evaluate(0.66f);
                }
                else if (brickHealth == 2)
                {
                    spriteRenderer.color = gradients[3].Evaluate(0.33f);
                }
                else if (brickHealth == 1)
                {
                    spriteRenderer.color = gradients[3].Evaluate(0f);
                }
                break;

            case "four":
                if (brickHealth == 5)
                {
                    spriteRenderer.color = gradients[4].Evaluate(1f);
                }
                else if (brickHealth == 4)
                {
                    spriteRenderer.color = gradients[4].Evaluate(0.75f);
                }
                else if (brickHealth == 3)
                {
                    spriteRenderer.color = gradients[4].Evaluate(0.50f);
                }
                else if (brickHealth == 2)
                {
                    spriteRenderer.color = gradients[4].Evaluate(0.25f);
                }
                else if (brickHealth == 1)
                {
                    spriteRenderer.color = gradients[4].Evaluate(0f);
                }
                break;

            case "five":
                if (brickHealth == 6)
                {
                    spriteRenderer.color = gradients[5].Evaluate(1f);
                }
                else if (brickHealth == 5)
                {
                    spriteRenderer.color = gradients[5].Evaluate(0.8f);
                }
                else if (brickHealth == 4)
                {
                    spriteRenderer.color = gradients[5].Evaluate(0.6f);
                }
                else if (brickHealth == 3)
                {
                    spriteRenderer.color = gradients[5].Evaluate(0.4f);
                }
                else if (brickHealth == 2)
                {
                    spriteRenderer.color = gradients[5].Evaluate(0.2f);
                }
                else if (brickHealth == 1)
                {
                    spriteRenderer.color = gradients[5].Evaluate(0f);
                }
                break;

            case "six":
                if (brickHealth == 7)
                {
                    spriteRenderer.color = gradients[6].Evaluate(1f);
                }
                else if (brickHealth == 6)
                {
                    spriteRenderer.color = gradients[6].Evaluate(0.84f);
                }
                else if (brickHealth == 5)
                {
                    spriteRenderer.color = gradients[6].Evaluate(0.58f);
                }
                else if (brickHealth == 4)
                {
                    spriteRenderer.color = gradients[6].Evaluate(0.42f);
                }
                else if (brickHealth == 3)
                {
                    spriteRenderer.color = gradients[6].Evaluate(0.27f);
                }
                else if (brickHealth == 2)
                {
                    spriteRenderer.color = gradients[6].Evaluate(0.135f);
                }
                else if (brickHealth == 1)
                {
                    spriteRenderer.color = gradients[6].Evaluate(0f);
                }
                break;

            case "seven":
                if (brickHealth == 8)
                {
                    spriteRenderer.color = gradients[7].Evaluate(1f);
                }
                else if (brickHealth == 7)
                {
                    spriteRenderer.color = gradients[7].Evaluate(0.86f);
                }
                else if (brickHealth == 6)
                {
                    spriteRenderer.color = gradients[7].Evaluate(0.72f);
                }
                else if (brickHealth == 5)
                {
                    spriteRenderer.color = gradients[7].Evaluate(0.58f);
                }
                else if (brickHealth == 4)
                {
                    spriteRenderer.color = gradients[7].Evaluate(0.44f);
                }
                else if (brickHealth == 3)
                {
                    spriteRenderer.color = gradients[7].Evaluate(0.30f);
                }
                else if (brickHealth == 2)
                {
                    spriteRenderer.color = gradients[7].Evaluate(0.15f);
                }
                else if (brickHealth == 1)
                {
                    spriteRenderer.color = gradients[7].Evaluate(0f);
                }
                break;

            case "eight":
                if (brickHealth == 9)
                {
                    spriteRenderer.color = gradients[8].Evaluate(1f);
                }
                else if (brickHealth == 8)
                {
                    spriteRenderer.color = gradients[8].Evaluate(0.875f);
                }
                else if (brickHealth == 7)
                {
                    spriteRenderer.color = gradients[8].Evaluate(0.75f);
                }
                else if (brickHealth == 6)
                {
                    spriteRenderer.color = gradients[8].Evaluate(0.625f);
                }
                else if (brickHealth == 5)
                {
                    spriteRenderer.color = gradients[8].Evaluate(0.5f);
                }
                else if (brickHealth == 4)
                {
                    spriteRenderer.color = gradients[8].Evaluate(0.375f);
                }
                else if (brickHealth == 3)
                {
                    spriteRenderer.color = gradients[8].Evaluate(0.25f);
                }
                else if (brickHealth == 2)
                {
                    spriteRenderer.color = gradients[8].Evaluate(0.125f);
                }
                else if (brickHealth == 1)
                {
                    spriteRenderer.color = gradients[8].Evaluate(0f);
                }
                break;

            case "nine":
                if (brickHealth == 10)
                {
                    spriteRenderer.color = gradients[9].Evaluate(1f);
                }
                else  if (brickHealth == 9)
                {
                    spriteRenderer.color = gradients[9].Evaluate(0.89f);
                }
                else if (brickHealth == 8)
                {
                    spriteRenderer.color = gradients[9].Evaluate(0.78f);
                }
                else if (brickHealth == 7)
                {
                    spriteRenderer.color = gradients[9].Evaluate(0.67f);
                }
                else if (brickHealth == 6)
                {
                    spriteRenderer.color = gradients[9].Evaluate(0.56f);
                }
                else if (brickHealth == 5)
                {
                    spriteRenderer.color = gradients[9].Evaluate(0.45f);
                }
                else if (brickHealth == 4)
                {
                    spriteRenderer.color = gradients[9].Evaluate(0.34f);
                }
                else if (brickHealth == 3)
                {
                    spriteRenderer.color = gradients[9].Evaluate(0.23f);
                }
                else if (brickHealth == 2)
                {
                    spriteRenderer.color = gradients[9].Evaluate(0.12f);
                }
                else if (brickHealth == 1)
                {
                    spriteRenderer.color = gradients[9].Evaluate(0f);
                }
                break;
        }

        if (brickHealth <= 0)
        {
            if(gameManager.brickDestroyAnimation.Count!=0)
            {

                for (int i = gameManager.brickDestroyAnimation.Count - 1; i >= 0; i--)
                {

                    if (!gameManager.brickDestroyAnimation[i].activeInHierarchy)
                    {

                        gameManager.brickDestroyAnimation[i].transform.position = this.transform.position;
                        gameManager.brickDestroyAnimation[i].SetActive(true);
                        break;
                    }
                    if (i == 0)
                    {

                        gameManager.brickDestroyAnimation.Add(Instantiate(DestroyAnim, this.transform.position, Quaternion.identity));
                    }
                }
            }
            else
            {

                gameManager.brickDestroyAnimation.Add(Instantiate(DestroyAnim, this.transform.position, Quaternion.identity));
            }
            gameManager.objectPool.Add(this.gameObject);
            gameManager.objectInScene.Remove(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball"&&ballController.currentBallState!=BallController.ballState.aim)
        {
            brickHealth -= 1;
        }
    }
}
