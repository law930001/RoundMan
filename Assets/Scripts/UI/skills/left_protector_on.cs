using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class left_protector_on : MonoBehaviour, IPointerEnterHandler {

    public GameObject go_protector;

    private void Start()
    {
        go_protector.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        if (game_control._protector_overlow == false && game_control._gameLock == false)
        {
            go_protector.SetActive(true);
            game_control._potector_static = true;
        }
    }
}
