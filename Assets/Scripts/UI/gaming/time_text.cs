using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_text : MonoBehaviour {

    public Text time_message;

    float time_f = 0f;

	void Update () {
        if (game_control._gameLock == false)
        {
            time_f += Time.deltaTime;
            game_control._score = (int)time_f;
            time_message.text = game_control._score.ToString();
        }
        else
        {
            if (game_control._gameOver == true)
            {
                time_f = 0f;
            }
        }
	}
}
