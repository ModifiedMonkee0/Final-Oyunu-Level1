using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteTab : MonoBehaviour
{
    public GameObject Note1u�;
    public GameObject Note1;
    public GameObject Note2u�;
    public GameObject Note2;
    public GameObject Note3;
    public GameObject Note3u�;
    public GameObject NotePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (NotePanel != null)
            {
                bool isActive = NotePanel.activeSelf;
                NotePanel.SetActive(!isActive);
            }
        }

       if(Note1.activeSelf== false)
        {
            Note1u�.SetActive(true);
        }

        if (Note2.activeSelf == false)
        {
            Note2u�.SetActive(true);
        }
        if (Note3.activeSelf == false)
        {
            Note3u�.SetActive(true);
        }


    }
}
