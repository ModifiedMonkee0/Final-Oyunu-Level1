using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteTab : MonoBehaviour
{
    public GameObject Note1uý;
    public GameObject Note1;
    public GameObject Note2uý;
    public GameObject Note2;
    public GameObject Note3;
    public GameObject Note3uý;
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
            Note1uý.SetActive(true);
        }

        if (Note2.activeSelf == false)
        {
            Note2uý.SetActive(true);
        }
        if (Note3.activeSelf == false)
        {
            Note3uý.SetActive(true);
        }


    }
}
