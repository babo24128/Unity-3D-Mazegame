using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
    private static GameManager instance = null;

    private void Awake()
    {
     


        if (Instance)
        {
            DestroyImmediate(gameObject);
            return;
        }
        instance = this;

    }

    


   int Player_Life = 3;
   int Player_Coin = 0;
    int coinPerAdd = 1;

    public AudioClip Clip_enemy;
    public AudioClip Clip_coin;
    public AudioSource AudioPlayer;
    public Text LifeText;
    public Text CoinText;

    public Slider HPBar;





    private void Update()
    {
      
    }


    private void Start()
    {
        LifeText.text = "Life :" + Player_Life;
        CoinText.text = "Coin :" + Player_Coin;
    }

    public void CalculatePlayerLife(int addLife)
    {
        HPBar.value = HPBar.value - addLife;
        Player_Life = Player_Life - addLife;
        LifeText.text = string.Format(Player_Life.ToString());

        AudioPlayer.clip = Clip_enemy;
        AudioPlayer.Play();

        if (HPBar.value == 0)
        {
            SceneManager.LoadScene("Title");
        }
        else
        {
            LifeText.text = "Life : " + Player_Life;
        }

    }


    public void CalculatePlayerCoin()
    {

        //  Count_Coin = Count_Coin + addCoin;

        HPBar.value += coinPerAdd;
        Player_Life += coinPerAdd;
        AudioPlayer.clip = Clip_coin;
        AudioPlayer.Play();


        LifeText.text = string.Format(Player_Life.ToString());
        LifeText.text = "Life : " + Player_Life;


      /*  if (Player_Coin >= 500)
        {
            SceneManager.LoadScene("Success");
        }
        else
        {
            CoinText.text = "Coin :" + Player_Coin;
        }
      */

    }

    public void GetCube()
    {
        
    }



}