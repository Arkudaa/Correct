using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    // Start is called before the first frame update
    public int currentHealth, maxHealth;
    public static PlayerHealthController instance;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage()
    {
        currentHealth--;
        UIController.instance.UpdateHealthDisplay();
        if (currentHealth <=0)
        {
            gameObject.SetActive(false);
            LevelManager.instance.RespawnPlayer();
        }


    }

    public void Heal()
    {
        currentHealth++;
        UIController.instance.UpdateHealthDisplay();
        if(currentHealth>maxHealth)
        {
            currentHealth = maxHealth;
        }

    }

}
