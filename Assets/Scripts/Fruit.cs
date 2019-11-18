using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public Sprite[] fruit = new Sprite[12];
    // Start is called before the first frame update
    void Start()
    {
        int random = Random.Range(0, 12);
        this.GetComponent<SpriteRenderer>().sprite = fruit[random];
        this.GetComponent<Transform>().position = new Vector2(Random.Range(-6.2f, 6.2f), 5.5f);
        if(random == 10)
        {
            this.tag = "Bomb";
        }
        if(random == 11)
        {
            this.tag = "BonusTime";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
