/****************************************************
    文件：LoopDragonAni.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/28 1:55:15
	功能：飞龙循环
*****************************************************/

using UnityEngine;

public class LoopDragonAni : MonoBehaviour 
{
    private Animation ani;

    private void Awake()
    {
        ani = transform.GetComponent<Animation>();
    }

    private void Start()
    {
        if (ani!=null)
        {
            InvokeRepeating("PlayDragonAni", 0, 20);
        }
    }

    private void PlayDragonAni()
    {
        ani.Play();
    }

}