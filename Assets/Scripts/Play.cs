using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public Button play;
    void Start()
    {
        play.onClick.AddListener(OnClick);
        
    }

    void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
