using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class start_button : MonoBehaviour, IPointerClickHandler
{
    
    public Rigidbody2D player;

    private void Start()
    {
        player.Sleep();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        player.WakeUp();
        game_control._gameOver = false;
        game_control._gameLock = false;
        gameObject.SetActive(false);
    }
}
