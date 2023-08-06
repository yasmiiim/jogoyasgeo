using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocontroller : MonoBehaviour
{
    public GameObject objectToShow; 
    public float delay = 4f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            objectToShow.SetActive(true);

           
            StartCoroutine(DeactivateObjectAfterDelay());
        }
    }

    private System.Collections.IEnumerator DeactivateObjectAfterDelay()
    {
        yield return new WaitForSeconds(delay);

        objectToShow.SetActive(false);
    }
}
