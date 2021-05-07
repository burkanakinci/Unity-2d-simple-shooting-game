using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneManager : MonoBehaviour
{
    public GameObject loadingPanel;
    public Slider loadingSlider;
    public Text progressText;

    [SerializeField] Button startButton;
    [SerializeField] AudioSource startButtonAudio;

    private void Start()
    {

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 45;

        startButtonAudio.enabled = true;

        loadingPanel.SetActive(false);
        startButton.interactable = true;

        loadingSlider.value = 0;
    }
    public void MainSceneButton()
    {
        startButtonAudio.Play();

        loadingPanel.SetActive(true);
        startButton.interactable = false;

        StartCoroutine(startLoading(1));

        
    }

    IEnumerator startLoading(int level)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(level);

        loadingPanel.SetActive(true);

        while (!operation.isDone)
        {
            int progress =(int) Mathf.Clamp01(operation.progress/0.9f);

            loadingSlider.value = progress;
            progressText.text = progress * 100f + "" + "%";

            yield return null;

           // Debug.Log("aaaaaaaaaaaaaaaaa   " + progressText.text) ;
        }


        //while(loadingSlider.value<0.6f)
        //{

        //    loadingSlider.value += 0.1f;
        //    yield return new WaitForSeconds(0.05f) ;
        //}

        //loadingSlider.value =1f;
        //SceneManager.LoadScene(level);
    }
}
