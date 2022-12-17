using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonController : MonoBehaviour
{
        public ButtonType buttonType;

        //CanvasManager canvasManager;
        //GameManager gameManager;
        Button menuButton;
        bool hasObjectToAnim = false;

        void Start()
        {
            
            menuButton = GetComponent<Button>();
            menuButton.onClick.AddListener(OnButtonClick);
            //canvasManager = CanvasManager.GetInstance();
            //gameManager = GameManager.GetInstance();
        }

        private void OnButtonClick()
        {
            
            switch(buttonType)
            {
                case ButtonType.PREGAME:
                    //canvasManager.SwitchCanvas(CanvasType.MAINMENU);
                    break;
                case ButtonType.MAINMENU:
                    Debug.Log("button has been pressed");
                    //canvasManager.SwitchCanvas(CanvasType.MAINMENU);
                    // UnmountScene
                    break;
                case ButtonType.START:
                    //canvasManager.SwitchCanvas(CanvasType.GAMEUI);
                    //gameManager.CurrentGamestate = GameState.GAME;
                    break;
                case ButtonType.PAUSE:
                    //canvasManager.SwitchCanvas(CanvasType.PAUSE);
                    break;
                case ButtonType.RESTART:
                    //canvasManager.SwitchCanvas(CanvasType.GAMEUI);
                    break;
                case ButtonType.RESUME:
                    //canvasManager.SwitchCanvas(CanvasType.GAMEUI);
                    break;
                case ButtonType.OPTIONS:
                    //canvasManager.SwitchCanvas(CanvasType.OPTIONS);
                    break;
                default:
                    break;
            }
        }
}
