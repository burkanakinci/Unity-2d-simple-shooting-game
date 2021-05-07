using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpColorController : MonoBehaviour
{
    public int powerUpHealth;
    public string powerUpColorNum;
    public Gradient[] gradients;
    public SpriteRenderer spriteRenderer;
    private GameManager gameManager;
    private void OnEnable()
    {

        gameManager = FindObjectOfType<GameManager>();

        if (gameManager.level <= 3)
        {
            spriteRenderer.color = gradients[0].Evaluate(1f);
            powerUpColorNum = "zero";
        }
        else if (gameManager.level > 3 && gameManager.level <= 6)
        {
            int colorRandom = Random.Range(0, 2);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                powerUpColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                powerUpColorNum = "one";
            }
        }
        else if (gameManager.level > 6 && gameManager.level <= 9)
        {
            int colorRandom = Random.Range(0, 3);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                powerUpColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                powerUpColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                powerUpColorNum = "two";
            }
        }
        else if (gameManager.level > 9 && gameManager.level <= 12)
        {
            int colorRandom = Random.Range(0, 4);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                powerUpColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                powerUpColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                powerUpColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                powerUpColorNum = "three";
            }
        }
        else if (gameManager.level > 12 && gameManager.level <= 15)
        {
            int colorRandom = Random.Range(0, 5);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                powerUpColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                powerUpColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                powerUpColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                powerUpColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                powerUpColorNum = "four";
            }
        }
        else if (gameManager.level > 15 && gameManager.level <= 18)
        {
            int colorRandom = Random.Range(0, 6);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                powerUpColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                powerUpColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                powerUpColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                powerUpColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                powerUpColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                powerUpColorNum = "five";
            }
        }
        else if (gameManager.level > 18 && gameManager.level <= 21)
        {
            int colorRandom = Random.Range(0, 7);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                powerUpColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                powerUpColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                powerUpColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                powerUpColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                powerUpColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                powerUpColorNum = "five";
            }
            else if (colorRandom == 6)
            {
                spriteRenderer.color = gradients[6].Evaluate(1f);
                powerUpColorNum = "six";
            }
        }
        else if (gameManager.level > 21 && gameManager.level <= 24)
        {
            int colorRandom = Random.Range(0, 8);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                powerUpColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                powerUpColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                powerUpColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                powerUpColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                powerUpColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                powerUpColorNum = "five";
            }
            else if (colorRandom == 6)
            {
                spriteRenderer.color = gradients[6].Evaluate(1f);
                powerUpColorNum = "six";
            }
            else if (colorRandom == 7)
            {
                spriteRenderer.color = gradients[7].Evaluate(1f);
                powerUpColorNum = "seven";
            }
        }
        else if (gameManager.level > 24 && gameManager.level <= 27)
        {
            int colorRandom = Random.Range(0, 9);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                powerUpColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                powerUpColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                powerUpColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                powerUpColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                powerUpColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                powerUpColorNum = "five";
            }
            else if (colorRandom == 6)
            {
                spriteRenderer.color = gradients[6].Evaluate(1f);
                powerUpColorNum = "six";
            }
            else if (colorRandom == 7)
            {
                spriteRenderer.color = gradients[7].Evaluate(1f);
                powerUpColorNum = "seven";
            }
            else if (colorRandom == 8)
            {
                spriteRenderer.color = gradients[8].Evaluate(1f);
                powerUpColorNum = "eight";
            }
        }
        else if (gameManager.level > 27)
        {
            int colorRandom = Random.Range(0, 10);
            if (colorRandom == 0)
            {
                spriteRenderer.color = gradients[0].Evaluate(0f);
                powerUpColorNum = "zero";
            }
            else if (colorRandom == 1)
            {
                spriteRenderer.color = gradients[1].Evaluate(1f);
                powerUpColorNum = "one";
            }
            else if (colorRandom == 2)
            {
                spriteRenderer.color = gradients[2].Evaluate(1f);
                powerUpColorNum = "two";
            }
            else if (colorRandom == 3)
            {
                spriteRenderer.color = gradients[3].Evaluate(1f);
                powerUpColorNum = "three";
            }
            else if (colorRandom == 4)
            {
                spriteRenderer.color = gradients[4].Evaluate(1f);
                powerUpColorNum = "four";
            }
            else if (colorRandom == 5)
            {
                spriteRenderer.color = gradients[5].Evaluate(1f);
                powerUpColorNum = "five";
            }
            else if (colorRandom == 6)
            {
                spriteRenderer.color = gradients[6].Evaluate(1f);
                powerUpColorNum = "six";
            }
            else if (colorRandom == 7)
            {
                spriteRenderer.color = gradients[7].Evaluate(1f);
                powerUpColorNum = "seven";
            }
            else if (colorRandom == 8)
            {
                spriteRenderer.color = gradients[8].Evaluate(1f);
                powerUpColorNum = "eight";
            }
            else if (colorRandom == 9)
            {
                spriteRenderer.color = gradients[9].Evaluate(1f);
                powerUpColorNum = "nine";
            }
        }

        if (powerUpColorNum == "zero")
        {
            powerUpHealth = 1;
        }
        else if (powerUpColorNum == "one")
        {
            powerUpHealth = 2;
        }
        else if (powerUpColorNum == "two")
        {
            powerUpHealth = 3;
        }
        else if (powerUpColorNum == "three")
        {
            powerUpHealth = 4;
        }
        else if (powerUpColorNum == "four")
        {
            powerUpHealth = 5;
        }
        else if (powerUpColorNum == "five")
        {
            powerUpHealth = 6;
        }
        else if (powerUpColorNum == "six")
        {
            powerUpHealth = 7;
        }
        else if (powerUpColorNum == "seven")
        {
            powerUpHealth = 8;
        }
        else if (powerUpColorNum == "eight")
        {
            powerUpHealth = 9;
        }
        else if (powerUpColorNum == "nine")
        {
            powerUpHealth = 10;
        }
    }
}
