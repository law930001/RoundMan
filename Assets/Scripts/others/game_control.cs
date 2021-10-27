using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_control : MonoBehaviour {
    
    // game data
    public static bool _gameLock = true;
    public static bool _gameOver = true;
    public static int _score = 0;

    // protector
    public static float _potector_energy = 100f;
    public static bool _potector_static = false; // true if on
    public static bool _protector_overlow = false;

    // movement data
    public static bool _r_btn_hold = false;
    public static bool _l_btn_hold = false;
    public static int _dir = 0;
    public static float _velocity = 8.5f;

    // pause
    public static List<Rigidbody2D> _circle_pause_rb = new List<Rigidbody2D>();
}
