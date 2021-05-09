using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image heart1, heart2, heart3;
    public Sprite heartfull, heartempty;
    public static UIController instance;
    public Text gemText;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateGemText();
    }

    public void UpdateGemText()
    {
        gemText.text = LevelManager.instance.gemsCollected.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthDisplay()
    {
        switch (PlayerHealthController.instance.currentHealth)
        {
            case 3:
                heart1.sprite = heartfull;
                heart2.sprite = heartfull;
                heart3.sprite = heartfull;
                break;

            case 2:
                heart1.sprite = heartfull;
                heart2.sprite = heartfull;
                heart3.sprite = heartempty;
                break;

            case 1:
                heart1.sprite = heartfull;
                heart2.sprite = heartempty;
                heart3.sprite = heartempty;
                break;

            case 0:
                heart1.sprite = heartempty;
                heart2.sprite = heartempty;
                heart2.sprite = heartempty;
                break;

            default:
                heart1.sprite = heartempty;
                heart2.sprite = heartempty;
                heart2.sprite = heartempty;
                break;

        }



    }

}
