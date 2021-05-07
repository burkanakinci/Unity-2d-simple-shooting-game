using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    public GameObject endGamePanel;
    private GameManager gameManager;
    private BallHealthManager ballHealth;
    public GameObject endGameAnim;
    public GameObject endGameVideoObject;
    void Start()
    {

        ballHealth = FindObjectOfType<BallHealthManager>();
        gameManager = FindObjectOfType<GameManager>();

        endGameAnim.SetActive(false);
        endGameVideoObject.SetActive(false);
    }

    public void RestartGame()
    {

        SceneManager.LoadScene(1);
    }
}
