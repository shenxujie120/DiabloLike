/****************************************************
    文件：SysytemRoot.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/28 1:48:13
	功能：Nothing
*****************************************************/

using UnityEngine;

public class SystemRoot : MonoBehaviour 
{
    protected ResSvc resSvc;
    protected AudioSvc audioSvc;

    public virtual void InitSys()
    {
        resSvc = ResSvc.Instance;
        audioSvc = AudioSvc.Instance;
    }
}