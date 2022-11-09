using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject startCanvas;
    [SerializeField] GameObject gameCanvas;
    [SerializeField] GameObject categories;
    [SerializeField] GameObject gamePanel;
    [SerializeField] TextMeshProUGUI category;
    [SerializeField] Button playButton;

    public List<Reptiles> reptilesAndSounds;
    public GameObject[] options;
    public int correctQuestion;
    private AudioSource questionAudio;
    private int currentReptile;

    
    public void StartGame()
        {
        startCanvas.SetActive(false);
        gameCanvas.SetActive(true);
        }

    public void StartReptiles()
        {
        categories.SetActive(false);
        gamePanel.SetActive(true);
        category.text = "Reptiles";
        GenerateReptiles();
        }

    void GenerateAnswers()
        {
        for (int i = 0; i < options.Length; i++)
            {
            options[i].GetComponent<Answers>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = reptilesAndSounds[currentReptile].answers[i];
            if (reptilesAndSounds[currentReptile].animalName == reptilesAndSounds[currentReptile].answers[i])
                {
                options[i].GetComponent<Answers>().isCorrect = true;
                }
            }
        }
         
    void GenerateReptiles()
        {
        currentReptile = Random.Range(0, reptilesAndSounds.Count);
        questionAudio = reptilesAndSounds[currentReptile].animalSound;
        GenerateAnswers();

        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(PlayAudio);
        }

    void PlayAudio()
        {
        questionAudio.Play();
        }
    }
