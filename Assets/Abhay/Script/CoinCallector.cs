using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCallector : MonoBehaviour
{

    private TextMeshProUGUI textUGI;

    private void Awake()
    {
        textUGI = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        updadescorevalue();
    }

    int score = 0;

    public void incrementvalue(int increment)
    {
        score = score + increment;
        updadescorevalue();

    }

    private void updadescorevalue()
    {
        textUGI.text = " Coin " + score;
    }


}