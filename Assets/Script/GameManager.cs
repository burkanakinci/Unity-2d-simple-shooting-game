using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Transform[] spawnPoints;
    public List<GameObject> objectInScene;
    public List<GameObject> objectPool;
    public List<GameObject> brickDestroyAnimation;
    public int level;
    public GameObject brick, xtraBall, xtraSecond, waitSecond, xtraSpeed;
    public Text levelText;
    public AudioSource extraSpeedSound, extraSecondSound, waitSecondSound, mainSceneSound;
    public GameObject extraSecondAnim;
    public float extraSecondAnimHealth;
    public GameObject extraBall;
    private BallController ballController;
    private EndGameManager endGameManager;
    public bool endGameLimitter;
    void Start()
    {

        endGameManager = FindObjectOfType<EndGameManager>();
        ballController = FindObjectOfType<BallController>();

        extraBall.SetActive(false);

        extraSecondAnimHealth=0;
        extraSecondAnim.SetActive(false);

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 45;

        mainSceneSound.Play();

        level = 0;

        for(int i=brickDestroyAnimation.Count-1;i>=0;i--)
        {

            brickDestroyAnimation[i].SetActive(false);
        }

        endGameLimitter = false;
    }

    void Update()
    {

        for (int i1 = 0; i1 < objectInScene.Count - 1; i1++)
        {

            if (objectInScene[i1].transform.position.y < 0)
                endGameLimitter = true;
        }
        if (!endGameLimitter)
            endGameManager.endGameAnim.SetActive(false);
        else
            endGameManager.endGameAnim.SetActive(true);
        endGameLimitter = false;


        for (int i=brickDestroyAnimation.Count-1;i>=0;i--)
        {

            if(brickDestroyAnimation[i].GetComponent<SpriteRenderer>().sprite.name=="3")
            {

                brickDestroyAnimation[i].SetActive(false);
            }
        }
        if(extraSecondAnimHealth<=0)
        {

            extraSecondAnim.SetActive(false);
        }
        if(extraSecondAnimHealth>0)
        {

            extraSecondAnimHealth -= Time.deltaTime;
        }

        levelText.text = level.ToString();
    }

    public void LevelUp()
    {

        for (int j = objectInScene.Count - 1; j >= 0; j--)
        {

            objectInScene[j].GetComponent<ObjectMovementController>().currentObjectState = ObjectMovementController.objectState.move;
        }

        for (int i = 0; i < spawnPoints.Length; i++)
        {

            int prefabType = Random.Range(0, 2);
            if(prefabType==0)
            {
                if(objectPool.Count != 0)
                {

                    for(int i1 = 0; i1 < objectPool.Count; i1++)
                    {

                        if (objectPool[i1].tag == "brick" && !objectPool[i1].activeInHierarchy)
                        {

                            objectPool[i1].transform.position = spawnPoints[i].transform.position;
                            objectPool[i1].SetActive(true);
                            objectInScene.Add(objectPool[i1]);
                            objectPool.Remove(objectPool[i1]);

                            break;
                        }
                        if(i1==objectPool.Count-1)
                        {

                            objectInScene.Add(Instantiate(brick,spawnPoints[i].transform.position,Quaternion.identity));
                        }
                    }
                }
                else
                {

                    objectInScene.Add(Instantiate(brick, spawnPoints[i].transform.position, Quaternion.identity));
                }               
            }
            else if (prefabType == 1)
            {
                int prefabType2 = Random.Range(0, 2);
                if (prefabType2 == 0)
                {

                    if (objectPool.Count != 0)
                    {

                        for (int i1 = 0; i1 < objectPool.Count; i1++)
                        {

                            if (objectPool[i1].tag == "brick" && !objectPool[i1].activeInHierarchy)
                            {

                                objectPool[i1].transform.position = spawnPoints[i].transform.position;
                                objectPool[i1].SetActive(true);
                                objectInScene.Add(objectPool[i1]);
                                objectPool.Remove(objectPool[i1]);

                                break;
                            }
                            if (i1 == objectPool.Count - 1)
                            {

                                objectInScene.Add(Instantiate(brick, spawnPoints[i].transform.position, Quaternion.identity));
                            }
                        }
                    }
                    else
                    {

                        objectInScene.Add(Instantiate(brick, spawnPoints[i].transform.position, Quaternion.identity));
                    }
                }
                else if(prefabType2==1)
                {

                    int prefabType3 = Random.Range(0,7);
                    if(prefabType3==0||prefabType3==1|| prefabType3 == 6)
                    {

                        if (objectPool.Count != 0)
                        {

                            for (int i1 = 0; i1 < objectPool.Count; i1++)
                            {

                                if (objectPool[i1].tag == "brick" && !objectPool[i1].activeInHierarchy)
                                {

                                    objectPool[i1].transform.position = spawnPoints[i].transform.position;
                                    objectPool[i1].SetActive(true);
                                    objectInScene.Add(objectPool[i1]);
                                    objectPool.Remove(objectPool[i1]);

                                    break;
                                }
                                if (i1 == objectPool.Count - 1)
                                {

                                    objectInScene.Add(Instantiate(brick, spawnPoints[i].transform.position, Quaternion.identity));
                                }
                            }
                        }
                        else
                        {

                            objectInScene.Add(Instantiate(brick, spawnPoints[i].transform.position, Quaternion.identity));
                        }
                    }
                    else if(prefabType3 == 2)
                    {

                        if (objectPool.Count != 0)
                        {

                            for (int i1 = 0; i1 < objectPool.Count; i1++)
                            {

                                if (objectPool[i1].tag == "xtraBall" && !objectPool[i1].activeInHierarchy)
                                {

                                    objectPool[i1].transform.position = spawnPoints[i].transform.position;
                                    objectPool[i1].SetActive(true);
                                    objectInScene.Add(objectPool[i1]);
                                    objectPool.Remove(objectPool[i1]);

                                    break;
                                }
                                if (i1 == objectPool.Count - 1)
                                {

                                    objectInScene.Add(Instantiate(xtraBall, spawnPoints[i].transform.position, Quaternion.identity));
                                }
                            }
                        }
                        else
                        {

                            objectInScene.Add(Instantiate(xtraBall, spawnPoints[i].transform.position, Quaternion.identity));
                        }
                    }
                    else if (prefabType3 == 3)
                    {

                        if (objectPool.Count != 0)
                        {

                            for (int i1 = 0; i1 < objectPool.Count; i1++)
                            {

                                if (objectPool[i1].tag == "xtraSecond" && !objectPool[i1].activeInHierarchy)
                                {

                                    objectPool[i1].transform.position = spawnPoints[i].transform.position;
                                    objectPool[i1].SetActive(true);
                                    objectInScene.Add(objectPool[i1]);
                                    objectPool.Remove(objectPool[i1]);

                                    break;
                                }
                                if (i1 == objectPool.Count - 1)
                                {

                                    objectInScene.Add(Instantiate(xtraSecond, spawnPoints[i].transform.position, Quaternion.identity));
                                }
                            }
                        }
                        else
                        {

                            objectInScene.Add(Instantiate(xtraSecond, spawnPoints[i].transform.position, Quaternion.identity));
                        }
                    }
                    else if (prefabType3 == 4)
                    {

                        if (objectPool.Count != 0)
                        {

                            for (int i1 = 0; i1 < objectPool.Count; i1++)
                            {

                                if (objectPool[i1].tag == "xtraSpeed" && !objectPool[i1].activeInHierarchy)
                                {

                                    objectPool[i1].transform.position = spawnPoints[i].transform.position;
                                    objectPool[i1].SetActive(true);
                                    objectInScene.Add(objectPool[i1]);
                                    objectPool.Remove(objectPool[i1]);

                                    break;
                                }
                                if (i1 == objectPool.Count - 1)
                                {

                                    objectInScene.Add(Instantiate(xtraSpeed, spawnPoints[i].transform.position, Quaternion.identity));
                                }
                            }
                        }
                        else
                        {

                            objectInScene.Add(Instantiate(xtraSpeed, spawnPoints[i].transform.position, Quaternion.identity));
                        }
                    }
                    else if (prefabType3 == 5)
                    {

                        if (objectPool.Count != 0)
                        {

                            for (int i1 = 0; i1 < objectPool.Count; i1++)
                            {

                                if (objectPool[i1].tag == "waitSecond" && !objectPool[i1].activeInHierarchy)
                                {

                                    objectPool[i1].transform.position = spawnPoints[i].transform.position;
                                    objectPool[i1].SetActive(true);
                                    objectInScene.Add(objectPool[i1]);
                                    objectPool.Remove(objectPool[i1]);

                                    break;
                                }
                                if (i1 == objectPool.Count - 1)
                                {

                                    objectInScene.Add(Instantiate(waitSecond, spawnPoints[i].transform.position, Quaternion.identity));
                                }
                            }
                        }
                        else
                        {

                            objectInScene.Add(Instantiate(waitSecond, spawnPoints[i].transform.position, Quaternion.identity));
                        }
                    }
                }

            }

        }
        if(ballController.currentBallState==BallController.ballState.aim)
        {

            level++;
        }   
    }
    public void LevelUp2()
    {
        for(int j=objectInScene.Count-1;j>=0;j--)
        {

            objectInScene[j].GetComponent<ObjectMovementController>().currentObjectState = ObjectMovementController.objectState.move2;
        }

        for (int i = 0; i < 7; i++)
        {


            if (objectPool.Count != 0)
            {

                for (int i1 = 0; i1 < objectPool.Count; i1++)
                {

                    if (objectPool[i1].tag == "brick" && !objectPool[i1].activeInHierarchy)
                    {

                        objectPool[i1].transform.position = spawnPoints[i].transform.position;
                        objectPool[i1].SetActive(true);
                        objectInScene.Add(objectPool[i1]);
                        objectPool.Remove(objectPool[i1]);

                        break;
                    }
                    if (i1 == objectPool.Count - 1)
                    {

                        objectInScene.Add(Instantiate(brick, spawnPoints[i].transform.position, Quaternion.identity));
                    }
                }
            }
            else
            {

                objectInScene.Add(Instantiate(brick, spawnPoints[i].transform.position, Quaternion.identity));
            }
        }
        if (ballController.currentBallState == BallController.ballState.aim)
        {

            level++;
        }
    }

}

