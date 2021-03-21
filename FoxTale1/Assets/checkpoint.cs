using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public static checkpoint instance;
    public SpriteRenderer sr;
    public Sprite cpOn, cpOff;

    private void Awake()
    {
        instance = this;
    }
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

        if (collision.tag == "Player")
        {
            //Debug.Log("It works!");
            cpController.instance.DeactivateCp();
            sr.sprite = cpOn;
            
        }

        


        
    }

    public void Reset()
    {
        sr.sprite = cpOff;
    }

}
