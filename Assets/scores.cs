using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scores : MonoBehaviour
{
    public int score;
    public Text text;
    public void addScore()
    {
        score++;
        text.text = score.ToString();
    }

}
