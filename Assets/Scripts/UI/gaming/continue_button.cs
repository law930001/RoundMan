using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class continue_button : MonoBehaviour, IPointerClickHandler {

    public GameObject pause_panel;
    public Rigidbody2D player;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        pause_panel.gameObject.SetActive(false);
        // game pause
        game_control._gameLock = false;
        // player stop
        player.WakeUp();
        // make circles stop
        foreach(var ele in game_control._circle_pause_rb)
        {
            ele.WakeUp();
            ele.AddForce(new Vector2(Random.Range(-1F,1F), Random.Range(-1F,1F)) * 500);
        }
        game_control._circle_pause_rb.Clear();
    }
}
