using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class videoPlayer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
   public VideoPlayer video ;
    public Text timetext;
    public RawImage image;
    public List<VideoClip> videoClipList;
    public Button button1;
    public Button button2;
    public Button button3;
    int videoIndex = 0;
    Slider tracking;
    bool slide = false;

    // Start is called before the first frame update
    void Start()
    {
        tracking = GetComponent<Slider>();
        button1.onClick.AddListener(onClick1);
        button2.onClick.AddListener(onClick2);
        button3.onClick.AddListener(onClick3);
    }


   

    void onClick1(){
        videoIndex = 0;
        video.clip = videoClipList[videoIndex];
        video.Play();
    }

    void onClick2(){
        videoIndex = 1;
        video.clip = videoClipList[videoIndex];
        video.Play();
    }


    void onClick3(){
        videoIndex = 2;
        video.clip = videoClipList[videoIndex];
        video.Play();
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
            float videoTime = (float)video.time;
            int videoTomeInt = Mathf.RoundToInt(videoTime);
            timetext.text = videoTomeInt.ToString();
        }
       
    }

}
