using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int gemsCollected;
    private void Awake()
    {
        instance = this;
    }

    public void RespawnPlayer()
    {
        // Debug.Log("Jah, player respawnib, kui kirjutame kuidas seda tehakse");
        StartCoroutine(RespawnCo());

    }


    IEnumerator RespawnCo()
    {
        //FindObjectOfType<PlayerHealthController>().gameObject.SetActive(false);
        PlayerHealthController.instance.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        //FindObjectOfType<PlayerHealthController>().gameObject.SetActive(true);
        PlayerHealthController.instance.gameObject.SetActive(true);
        //FindObjectOfType<PlayerHealthController>().transform.position = FindObjectOfType<cpController>().spawnPoint;
        PlayerHealthController.instance.transform.position = cpController.instance.spawnPoint;
        PlayerHealthController.instance.currentHealth = PlayerHealthController.instance.maxHealth;
        UIController.instance.UpdateHealthDisplay();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
