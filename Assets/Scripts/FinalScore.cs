using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score;
    void Start()
    {
        score.text = "Score: \n" + GameManager.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
