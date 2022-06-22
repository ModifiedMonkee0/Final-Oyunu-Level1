using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollect : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    private void Update()
    {
        scoreText.GetComponent<Text>().text = "NOTES: " + theScore + "/3";
    }
}
