using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;

public class InterstitialController : MonoBehaviour
{
	private InterstitialAd adInterstitial;
	private EndGameManager endGameManager;

	private string idInterstitial;

	[SerializeField] Button BtnInterstitial;


	void Start()
	{

		endGameManager=FindObjectOfType<EndGameManager>();

		idInterstitial = "ca-app-pub-9562707167462286/3403520514";//benim reklam
		//idInterstitial = "ca-app-pub-3940256099942544/8691691433";//test reklam

		//MobileAds.Initialize(idApp);

		RequestInterstitialAd();


	}

	#region Interstitial methods ---------------------------------------------

	public void RequestInterstitialAd()
	{
		adInterstitial = new InterstitialAd(idInterstitial);
		AdRequest request = AdRequestBuild();
		adInterstitial.LoadAd(request);

		//attach events
		adInterstitial.OnAdLoaded += this.HandleOnAdLoaded;
		adInterstitial.OnAdOpening += this.HandleOnAdOpening;
		adInterstitial.OnAdClosed += this.HandleOnAdClosed;
	}

	public void ShowInterstitialAd()
	{
		if (adInterstitial.IsLoaded())
			adInterstitial.Show();
		BtnInterstitial.interactable = false;
	}

	public void DestroyInterstitialAd()
	{
		adInterstitial.Destroy();
	}

	//interstitial ad events
	public void HandleOnAdLoaded(object sender, EventArgs args)
	{
		//this method executes when interstitial ad is Loaded and ready to show
		BtnInterstitial.interactable = true; //button is ready to click (enabled)
	}

	public void HandleOnAdOpening(object sender, EventArgs args)
	{
		//this method executes when interstitial ad is shown
		BtnInterstitial.interactable = false; //disable the button
	}

	public void HandleOnAdClosed(object sender, EventArgs args)
	{
		//this method executes when interstitial ad is closed
		adInterstitial.OnAdLoaded -= this.HandleOnAdLoaded;
		adInterstitial.OnAdOpening -= this.HandleOnAdOpening;
		adInterstitial.OnAdClosed -= this.HandleOnAdClosed;

		endGameManager.RestartGame();

		//RequestInterstitialAd(); //request new interstitial ad after close
	}

	#endregion


	//------------------------------------------------------------------------
	AdRequest AdRequestBuild()
	{
		return new AdRequest.Builder().Build();
	}

	void OnDestroy()
	{
		DestroyInterstitialAd();

		//dettach events
		adInterstitial.OnAdLoaded -= this.HandleOnAdLoaded;
		adInterstitial.OnAdOpening -= this.HandleOnAdOpening;
		adInterstitial.OnAdClosed -= this.HandleOnAdClosed;
	}

}