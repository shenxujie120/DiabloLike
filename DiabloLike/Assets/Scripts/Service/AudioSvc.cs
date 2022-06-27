/****************************************************
    文件：AudioSvc.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/27 19:12:38
	功能：Nothing
*****************************************************/

using UnityEngine;

public class AudioSvc : MonoBehaviour 
{
    public static AudioSvc Instance = null;
    public AudioSource bgAudio;
    public AudioSource uiAudio;

    public void InitSvc()
    {
        Instance = this;
        Debug.Log("AudioAvc Start…");
    }

    public void PlayBGAudio(string name,bool isLoop = true)
    {
        //只加载没播放
        AudioClip audio=ResSvc.Instance.AudioLoad("ResAudio/" + name,true);
        bgAudio.clip = audio;
        bgAudio.loop = isLoop;
        bgAudio.Play();
    }

}