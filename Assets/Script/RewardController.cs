using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;
//reward ad

public class RewardController : MonoBehaviour
{
    private RewardBasedVideoAd adReward;
    private BallController ballController;

    private string  idReward;

    private EndGameManager endGameManager;
    private GameManager gameManager;

    [SerializeField] Button BtnReward;
    [SerializeField] Button BtnLoading;


    void Start()
    {

        ballController = FindObjectOfType<BallController>();
        endGameManager = FindObjectOfType<EndGameManager>();
        gameManager = FindObjectOfType<GameManager>();

        BtnLoading.gameObject.SetActive(false);

        //idApp = "ca-app-pub-3940256099942544~3347511713";
        idReward = "ca-app-pub-9562707167462286/9705800483";//benim id
        //idReward = "ca-app-pub-3940256099942544/5224354917";//test id

        adReward = RewardBasedVideoAd.Instance;

        //MobileAds.Initialize (idApp);
    }


    #region Reward video methods ---------------------------------------------

    public void RequestRewardAd()
    {
        AdRequest request = AdRequestBuild();
        adReward.LoadAd(request, idReward);

        adReward.OnAdLoaded += this.HandleOnRewardedAdLoaded;
        adReward.OnAdRewarded += this.HandleOnAdRewarded;
        adReward.OnAdClosed += this.HandleOnRewardedAdClosed;
    }

    public void ShowRewardAd()
    {
        if (adReward.IsLoaded())
            adReward.Show();
    }
    //events
    public void HandleOnRewardedAdLoaded(object sender, EventArgs args)
    {//ad loaded
        ShowRewardAd();

    }

    public void HandleOnAdRewarded(object sender, EventArgs args)
    {//user finished watching ad

        gameManager.mainSceneSound.Play();
        ballController.isGameActive = true;
        endGameManager.endGamePanel.SetActive(false);
        GameObject.Find("LimiterObject").GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);

        //int points = int.Parse(TxtPoints.text);
        //points += 50; //add 50 points
        //TxtPoints.text = points.ToString();
    }

    public void HandleOnRewardedAdClosed(object sender, EventArgs args)
    {//ad closed (even if not finished watching)

        BtnReward.gameObject.SetActive(true);
        BtnReward.interactable = true;
        BtnLoading.gameObject.SetActive(false);

       // BtnReward.GetComponentInChildren<Text>().text = "More Points";

        adReward.OnAdLoaded -= this.HandleOnRewardedAdLoaded;
        adReward.OnAdRewarded -= this.HandleOnAdRewarded;
        adReward.OnAdClosed -= this.HandleOnRewardedAdClosed;
    }

    #endregion

    //other functions
    //btn (more points) clicked
    public void OnGetMorePointsClicked()
    {

        BtnReward.gameObject.SetActive(false);
        BtnLoading.gameObject.SetActive(true);
        BtnLoading.interactable = false;
        BtnReward.interactable = false;

        //BtnReward.GetComponentInChildren<Text>().text = "Loading...";
        RequestRewardAd();
    }

    //------------------------------------------------------------------------
    AdRequest AdRequestBuild()
    {
        return new AdRequest.Builder().Build();
    }

    void OnDestroy()
    {
        adReward.OnAdLoaded -= this.HandleOnRewardedAdLoaded;
        adReward.OnAdRewarded -= this.HandleOnAdRewarded;
        adReward.OnAdClosed -= this.HandleOnRewardedAdClosed;
    }

}