using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingTutorialController : MonoBehaviour
{
    private BallController ballController;
    [SerializeField] List<GameObject> tutorialObjects;
    void Start()
    {

        ballController = FindObjectOfType<BallController>();
        ballController.isGameActive=false;
        for(int k=tutorialObjects.Count-1;k>=0;k--)
        {

            tutorialObjects[k].SetActive(true);
        }
        Invoke("Tutorial1End", 1.9f);
    }

    private void Tutorial1End()
    {

        for (int k = tutorialObjects.Count - 1; k >= 0; k--)
        {

            tutorialObjects[k].SetActive(false);
        }
        ballController.isGameActive = true;
        this.gameObject.SetActive(false);
    }
}
