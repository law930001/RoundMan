using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class restart_button_control : MonoBehaviour, IPointerClickHandler {

    public Text restart_message;
    public GameObject player;
    public GameObject protector;

    GameObject[] circles;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        game_control._gameOver = false;
        game_control._gameLock = false;
        restart_message.gameObject.SetActive(false);
        gameObject.SetActive(false);
        // move player to center
        player.transform.position = new Vector3(0.22f, 0.0f, 0.0f);
        // renew clock
        game_control._score = 0;
        game_control._dir = 0;
        // renew protector
        game_control._potector_static = false;
        game_control._potector_energy = 100;
        game_control._protector_overlow = false;
        protector.SetActive(false);
        // destroy circles
        circles = GameObject.FindGameObjectsWithTag("circle");
        foreach (var cir in circles)
        {
            if (cir.transform.position.x < 14f)
                Destroy(cir);
        }
    }
}
