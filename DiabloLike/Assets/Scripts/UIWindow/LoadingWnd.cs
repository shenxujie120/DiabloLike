/****************************************************
    文件：LoadingWnd.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/25 1:7:6
	功能：Nothing
*****************************************************/

using UnityEngine;
using UnityEngine.UI;

public class LoadingWnd : MonoBehaviour 
{
    public TextMesh txtTips;
    public Image ImgFg;
    public Image ImgPoint;
    public TextMesh txtPrg;

    private float fgWidth;

    public void InitWnd()
    {
        fgWidth = ImgFg.GetComponent<RectTransform>().sizeDelta.x;
        txtTips.text = "我是最骄傲的狼……";
        ImgFg.fillAmount = 0;
        txtPrg.text = "0%";
        ImgPoint.transform.localPosition = new Vector3(-515f, 0, 0);
    }

    public void SetProgress(float prg)
    {
        txtPrg.text = (int)(prg*100)+"%";
        ImgFg.fillAmount = prg;
        float posx = fgWidth * prg - 515;
        ImgPoint.GetComponent<RectTransform>().anchoredPosition = new Vector2(posx,0);
    }

}