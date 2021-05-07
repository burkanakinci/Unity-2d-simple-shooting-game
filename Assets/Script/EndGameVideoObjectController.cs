using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameVideoObjectController : MonoBehaviour
{
    [SerializeField] GameObject timeLevelCanvas;
    private void OnEnable()
    {

        timeLevelCanvas.SetActive(false);
    }

    private void OnDisable()
    {

        timeLevelCanvas.SetActive(true);
    }
}
