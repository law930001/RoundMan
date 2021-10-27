using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class pause_button : MonoBehaviour, IPointerClickHandler
{
    public GameObject pause_panel;
    public Rigidbody2D player;

    GameObject[] circles;

    private void Start()
    {
        pause_panel.gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (game_control._gameOver == false)
        {
            pause_panel.gameObject.SetActive(true);
            // game pause
            game_control._gameLock = true;
            // player stop
            player.Sleep();
            // make circles stop
            circles = GameObject.FindGameObjectsWithTag("circle");
            foreach (var cir in circles)
            {
                Rigidbody2D rb = cir.GetComponent<Rigidbody2D>();
                game_control._circle_pause_rb.Add(rb);
                rb.Sleep();
            }
        }
    }
}
