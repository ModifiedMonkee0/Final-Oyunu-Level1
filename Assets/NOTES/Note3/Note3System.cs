using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note3System : MonoBehaviour
{
    public GameObject Note3;
    public AudioSource PaperSound3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {

            Note3.SetActive(false);

        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Note3"))
        {
            Note3.SetActive(true);
            PaperSound3.Play();

        }



    }

    void OnTriggerExit(Collider other)
    {


        if (other.CompareTag("Note3"))
        {
            Note3.SetActive(false);
        }

    }



}