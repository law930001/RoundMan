using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class protector_energy : MonoBehaviour {

    public Text energy_text;
    public RectTransform energy_bar;
    public GameObject go_protector;
    	
    void Update()
    {
        if (game_control._gameLock == false)
        {
            if (game_control._potector_static == true)
            {
                if (game_control._potector_energy > 0) // reduce energy
                {
                    game_control._potector_energy -= 1;
                }
                if (game_control._potector_energy <= 0) // turn to recharge
                {
                    game_control._potector_energy = 0;
                    game_control._potector_static = false; // turn off
                    go_protector.SetActive(false);
                    game_control._protector_overlow = true;
                }

            }
            else
            { // recharge
                if (game_control._potector_energy < 100) // recharge here
                {
                    game_control._potector_energy += 0.50F;
                }
                if (game_control._potector_energy >= 100) // end recharge
                {
                    game_control._potector_energy = 100;
                    game_control._protector_overlow = false;
                }
            }
        }
        // energy bar
        energy_bar.sizeDelta = new Vector2(game_control._potector_energy * 2, 60);
        // number string
        if (game_control._protector_overlow == true)
        {
            energy_text.color = Color.red;
            energy_text.text = "Wait";
        }
        else
        {
            energy_text.color = Color.black;
            energy_text.text = game_control._potector_energy.ToString();
        }
    
    }
}
