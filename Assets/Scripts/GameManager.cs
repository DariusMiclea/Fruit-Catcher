using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject fruit;
    private float timer, maxTime = 1f;
    public static int score = 0;
    public Text scoreText;
    public Text timeText;
    public float timeLeft;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (timeLeft <= 0)
        {
            GameOver();
        }
        if (timer > maxTime)
        {
            GameObject fruitInstance = Instantiate(fruit);
            timer = 0f;
            Destroy(fruitInstance, 3);
            
        }
        timer += Time.deltaTime;
        if(maxTime > 0.3f)
        {
            maxTime -= 0.002f;
        }
        scoreText.text = "Score" + '\n' + score.ToString();
        timeLeft -= Time.deltaTime;

        timeText.text = "Time" + '\n' + Mathf.FloorToInt(timeLeft).ToString();
        
    }
    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
