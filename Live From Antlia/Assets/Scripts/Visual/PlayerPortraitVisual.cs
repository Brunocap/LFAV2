using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerPortraitVisual : MonoBehaviour {

    public CharacterAsset charAsset;
    [Header("Text Component References")]
    //public Text NameText;
    public Text IntText;
    public Text PopText;
    public Text FundsText;
    [Header("Image References")]
    public Image HeroPowerIconImage;
    public Image HeroPowerBackgroundImage;
    public Image PortraitImage;
    public Image PortraitBackgroundImage;

    void Awake()
	{
		if(charAsset != null)
			ApplyLookFromAsset();
	}

	public void ApplyLookFromAsset()
    {
        IntText.text = charAsset.MaxHealth.ToString();
        PopText.text = charAsset.MaxHealth.ToString();
        FundsText.text = charAsset.MaxHealth.ToString();
        HeroPowerIconImage.sprite = charAsset.HeroPowerIconImage;
        HeroPowerBackgroundImage.sprite = charAsset.HeroPowerBGImage;
        PortraitImage.sprite = charAsset.AvatarImage;
        PortraitBackgroundImage.sprite = charAsset.AvatarBGImage;

        HeroPowerBackgroundImage.color = charAsset.HeroPowerBGTint;
        PortraitBackgroundImage.color = charAsset.AvatarBGTint;

    }

    public void TakeDamage(int amount, int healthAfter)
    {
        if (amount > 0)
        {
          if (type == Int)
          {
            DamageEffect.CreateDamageEffect(transform.position, amount);
            IntText.text = healthAfter.ToString();
          }
          else if (type == Pop)
          {
            DamageEffect.CreateDamageEffect(transform.position, amount);
            PopText.text = healthAfter.ToString();
          }
          else if (type == Funds)
          {
            DamageEffect.CreateDamageEffect(transform.position, amount);
            FundsText.text = healthAfter.ToString();
          }
        }
    }

    public void Explode()
    {
        Instantiate(GlobalSettings.Instance.ExplosionPrefab, transform.position, Quaternion.identity);
        Sequence s = DOTween.Sequence();
        s.PrependInterval(2f);
        s.OnComplete(() => GlobalSettings.Instance.GameOverPanel.SetActive(true));
    }



}
