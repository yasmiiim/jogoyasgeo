using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemHeart : MonoBehaviour
{
    public int healthValue;
    private AudioSource sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sound.Play();
            collision.gameObject.GetComponent<player>().IncreaseLife(healthValue);
            Destroy(gameObject, 0.1f);
            
        }
    }
    void Awake()
    {
        sound = GetComponent<AudioSource>();
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
