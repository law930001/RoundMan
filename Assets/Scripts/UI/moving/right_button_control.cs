using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class right_button_control : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        if (game_control._r_btn_hold == true &&
            game_control._dir == 1 &&
            game_control._gameLock == false)
        {
            player.transform.Translate(new Vector3(1 * Time.deltaTime * game_control._velocity, 0, 0));
        }
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        game_control._r_btn_hold = true;
        game_control._dir = 1;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        game_control._r_btn_hold = false;
    }
}
