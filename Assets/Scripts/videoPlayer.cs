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
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
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
        button4.onClick.AddListener(onClick4);
        button5.onClick.AddListener(onClick5);
        button6.onClick.AddListener(onClick6);
        button7.onClick.AddListener(onClick7);
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

    void onClick4(){
        videoIndex = 3;
        video.clip = videoClipList[videoIndex];
        video.Play();
    }

    void onClick5(){
        videoIndex = 4;
        video.clip = videoClipList[videoIndex];
        video.Play();
    }

    void onClick6(){
        videoIndex = 5;
        video.clip = videoClipList[videoIndex];
        video.Play();
    }

    void onClick7(){
        videoIndex = 6;
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
