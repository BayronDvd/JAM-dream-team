using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Transition
{
    IDLE, WANDER, CHASE, ATTACK, DEATH
}

public enum CanvasType
{
    BOOT, MAINMENU, MUSEUM, GAMEUI,  PAUSE, OPTIONS, CREDITS, GAMEOVER, VICTORY, PLACEHOLDER 
}

public enum GameState
{
    BOOT, MAINMENU, MUSEUM, GAME, PAUSE, OPTION, CREDITS, GAMEOVER, VICTORY, RESTART
}

public enum ButtonType
{
    PREGAME, MAINMENU, START, PAUSE, RESUME, OPTIONS, RESTART, QUIT, CREDITS
}

public class Definitions : MonoBehaviour
{
   
}
