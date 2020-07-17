﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class Track : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public VideoPlayer video;
    public Text timeText;
    Slider tracking;
    bool slide = false;
    
    // Start is called before the first frame update
    void Start()
    {
        tracking = GetComponent<Slider> ();
      
    }

     public void OnPointerDown(PointerEventData a){
        slide = true;
    }

    public void OnPointerUp(PointerEventData a){
        float frame = (float)tracking.value * (float)video.frameCount;
        video.frame = (long)frame;
        slide = false;
    }
  
    // Update is called once per frame
    void Update()
    {
        if(!slide && video.isPlaying){
            tracking.value = (float)video.frame / (float)video.frameCount;
        
            float timer = (float)video.time;
 
            string minutes = Mathf.Floor(timer / 60).ToString("00");
            string seconds = (timer % 60).ToString("00");
     
            timeText.text = string.Format("{0}:{1}", minutes, seconds);
        }
       
    }

    
   
}
