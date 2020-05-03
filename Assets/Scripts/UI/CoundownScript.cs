using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoundownScript : MonoBehaviour
{
    public GameControl game;
    public AudioClip one,two,three,go;
    private bool oneDone = false;
    private bool twoDone = false;
    private bool goDone = false;

    private AudioSource source;
    private TextMeshProUGUI Display;
    private float counter = 0f;

    void Start()
    {
        Display = gameObject.GetComponent<TextMeshProUGUI>();
        source = gameObject.GetComponent<AudioSource>();
        Display.text = "3";
        source.PlayOneShot(three);
    }

    void Update()
    {
        if(counter >= 5.0f){return;}
        counter += Time.deltaTime;
        if(counter >= 4.0f){
            gameObject.SetActive(false);
        }       
        else if(counter >= 3.0f){
            Display.text = "GO";
            if(!source.isPlaying && !goDone){
                source.PlayOneShot(go);
                goDone = true;
            }
            game.StartGame();
        } 
        else if(counter >= 2.0f){
            Display.text = "1";
            if(!source.isPlaying && !oneDone){
                source.PlayOneShot(one);
                oneDone = true;
            }
        } 
        else if(counter >= 1.0f){
            Display.text = "2";
            if(!source.isPlaying && !twoDone){
                source.PlayOneShot(two);
                twoDone = true;
            }
        }
    }
}
