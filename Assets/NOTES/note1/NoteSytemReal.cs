using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteSytemReal : MonoBehaviour
{
    public GameObject Note1;
    public AudioSource PaperSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {

            Note1.SetActive(false);
            
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.CompareTag("Note1"))
        {
            Note1.SetActive(true);
            PaperSound.Play();
            
        }
        


    }

    void OnTriggerExit(Collider other)
    {
        
        
        if (other.CompareTag("Note1"))
        {
            Note1.SetActive(false);
        }

    }

    
    
}
