using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour
{
    private Button button;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(PlayAudio);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayAudio()
        {
        audioSource.Play();
        }
}
