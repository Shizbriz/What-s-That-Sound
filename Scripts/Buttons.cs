using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Assets.Scripts
    {
    public class Buttons : MonoBehaviour
        {
        private  Button button;
        private GameManager gameManager;
        
        private void Start()
            {
            button = GetComponent<Button>();
            button.onClick.AddListener(ButtonClicked);
            gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

            
            }
        private void Update()
            {
            
            }

        void ButtonClicked()
            {
            if (button.CompareTag("StartButton"))
                {
                gameManager.StartGame();
                }
            else if (button.CompareTag("ReptileButton"))
                {
                gameManager.StartReptiles();
                }
           
            }
       
        }
    
    }
