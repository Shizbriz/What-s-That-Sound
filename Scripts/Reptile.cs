using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Reptiles
    {
    public string animalName;
    public AudioSource animalSound;
    public string[] answers;
    public int correctAnswer;
    [SerializeField] GameObject aboutAnimal;
    }
  

  /* public class Reptile : MonoBehaviour
        {
        Reptiles africanGavial = new Reptiles();

        private void Start()
            {
            africanGavial.animalName = "African Gavial";
           
            }
        }
  */
    
