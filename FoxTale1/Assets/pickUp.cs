using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{   public bool isGem;
    public bool ischerry;
    public static pickUp instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (isGem)
            {
                Destroy(gameObject);
                LevelManager.instance.gemsCollected++;
                UIController.instance.UpdateGemText();
            }

            if (ischerry)
            {
                if (PlayerHealthController.instance.currentHealth != PlayerHealthController.instance.maxHealth)
                {
                    Destroy(gameObject);
                    PlayerHealthController.instance.Heal();
                }
                

            }
                
             



           

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
