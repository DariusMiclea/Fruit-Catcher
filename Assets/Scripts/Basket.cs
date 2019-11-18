using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public float speed;
    private Vector3 position;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Transform>().Translate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Transform>().Translate(-speed, 0, 0);
        }
        position = this.GetComponent<Transform>().position;
        position.x = Mathf.Clamp(position.x, -5.5f, 5.5f);
        this.GetComponent<Transform>().position = position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fruit"){
            Destroy(collision.gameObject);
            GameManager.score++;
        }

        if (collision.gameObject.tag == "BonusTime")
        {
            Destroy(collision.gameObject);
            gameManager.timeLeft += 5;
        }

        if (collision.gameObject.tag == "Bomb")
        {
            Destroy(collision.gameObject);
            gameManager.timeLeft -= 10;
        }
    }
   
}
