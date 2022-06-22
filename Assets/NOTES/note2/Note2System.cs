using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note2System : MonoBehaviour
{
    public GameObject Note2;
    public AudioSource PaperSound2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {

            Note2.SetActive(false);

        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Note2"))
        {
            Note2.SetActive(true);
            PaperSound2.Play();

        }



    }

    void OnTriggerExit(Collider other)
    {


        if (other.CompareTag("Note2"))
        {
            Note2.SetActive(false);
        }

    }



}