using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionBreak : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int OnMouseDown()
    {
        return score;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins \n" + "X " + score;
    }
}
