using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stambox : MonoBehaviour
{
    public GameObject deathEffect;
    public GameObject gem;
   [Range(0,10)] public int chanceToDrop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            //Debug.Log("Hit Enemy");
            collision.transform.parent.gameObject.SetActive(false);
            GameObject clone= Instantiate(deathEffect, collision.transform.position, collision.transform.rotation);
            AudioManager.instance.PlaySound(3);
            MovingScript.instance.Bounce();
            Destroy(clone, 0.5f);

            int randchance = Random.Range(0, 10);
            Debug.Log(randchance);
            if (randchance <= chanceToDrop)
            {
                Instantiate(gem, collision.transform.position, collision.transform.rotation);

            }
            

        }
    }
}
