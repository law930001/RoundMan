using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    public Text message;
    public Button restart_btn;

    public GameObject[] circles;

    SpriteRenderer spr;
    Texture2D texture_left, texture_mid, texture_right;

    private void Start()
    {
        // initialize
        message.text = "GameOver";
        message.gameObject.SetActive(false);
        restart_btn.gameObject.SetActive(false);
        // loading sprites
        spr = gameObject.GetComponent<SpriteRenderer>();
        texture_left = (Texture2D)Resources.Load("elements/player/player_left");
        texture_mid = (Texture2D)Resources.Load("elements/player/player_mid");
        texture_right = (Texture2D)Resources.Load("elements/player/player_right");
    }

    private void Update()
    {
        // change direction
        if(game_control._l_btn_hold == false && game_control._r_btn_hold == false){
            game_control._dir = 0;   
        }
        // change sprite
        if (game_control._gameLock == false)
        {
            Texture2D chosen = null;
            switch (game_control._dir)
            {
                case -1:
                    chosen = texture_left;
                    break;
                case 0:
                    chosen = texture_mid;
                    break;
                case 1:
                    chosen = texture_right;
                    break;
                default:
                    Debug.Log("Sprite loading wrong");
                    break;
            }
            Sprite sp = Sprite.Create(chosen, spr.sprite.textureRect, new Vector2(0.5f, 0.5f));
            spr.sprite = sp;
        }
    }

    // judge if lose
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("circle"))
        {
            GameOver();
        }
    }

    // execute if game over
    void GameOver()
    {
        game_control._gameOver = true;
        game_control._gameLock = true;
        message.gameObject.SetActive(true);
        restart_btn.gameObject.SetActive(true);
        // make circles stop
        circles = GameObject.FindGameObjectsWithTag("circle");
        foreach(var cir in circles){
            Rigidbody2D rb = cir.GetComponent<Rigidbody2D>();
            rb.Sleep();
        }
    }
}
