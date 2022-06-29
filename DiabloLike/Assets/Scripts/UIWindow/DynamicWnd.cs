/****************************************************
    文件：DynamicWnd.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/28 2:23:46
	功能：Tips显示
*****************************************************/

using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class DynamicWnd : WindowRoot 
{
    public TextMeshProUGUI textMesh;
    public Animation ani;
    private bool isTipsShow = false;

    protected override void InitWnd()
    {
        base.InitWnd();
        SetActive(textMesh,false);
    }
    
    //声明队列
    //解决上一个播放完毕后再播放下一个而不是按照信息次序
    private Queue tipsQueue = new Queue();
    //加入队列
    public void AddTips(string tips)
    {
        lock (tipsQueue)
        {
            tipsQueue.Enqueue(tips);
        }
        
    }
    //从队列取出
    private void Update()
    {
        if(tipsQueue.Count > 0&& isTipsShow==false)
        {
            lock (tipsQueue)
            {
                string tips = (string)tipsQueue.Dequeue();
                SetTips(tips);
                isTipsShow = true;
            }
        }
    }

    private void SetTips(string txt)
    {
            SetActive(textMesh);
            textMesh.SetText(txt);
            //SetText(textMesh, );
        //播放完成后关闭，动画监测结束
        AnimationClip clip = ani.GetClip("TipsShowAni");
        ani.Play();
        StartCoroutine(AniPlayDone(clip.length, () => {
            SetActive(textMesh,false);
            isTipsShow = false;
        }));

    }

    private IEnumerator AniPlayDone(float sec,Action cb)
    {
        yield return new WaitForSeconds(sec);
        if (cb != null)
        {
            cb();
        }
    }

}