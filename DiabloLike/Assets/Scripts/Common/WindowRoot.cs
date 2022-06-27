/****************************************************
    文件：WindowRoot.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/26 20:54:49
	功能：Nothing
*****************************************************/

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WindowRoot : MonoBehaviour 
{
    public ResSvc resSvc = null;
    //激活并且初始化，其他cs需要调用

    public void SetWndState(bool isActive = true)
    {
        if (gameObject.activeSelf!=isActive)
        {
            SetActive(gameObject, isActive);
        }
        if (isActive)
        {
            InitWnd();
        }
        else
        {
            ClearWnd();
         }
    }

    protected virtual void InitWnd()
    {
        resSvc = ResSvc.Instance;
    }

    protected virtual void ClearWnd()
    {
        resSvc = null;
    }


    #region TOOL FUNC 基础方法
    protected void SetText(Text txt, string context="")
    {
        txt.text = context;
    }

    protected void SetText(Text txt, int num=0)
    {
        SetText(txt, num.ToString());
    }

    //传入transform组件
    protected void SetText(Transform trans, int num=0)
    {
        SetText(trans.GetComponent<Text>(), num.ToString());
    }

    protected void SetText(Transform trans, string context="")
    {
        SetText(trans.GetComponent<Text>(), context);
    }

    protected void SetText(TextMeshProUGUI txtMesh, string context="")
    {
        txtMesh.GetComponent<TMP_Text>().text = context;
    }

    protected void SetText(TextMeshProUGUI txtMesh, int num = 0)
    {
        txtMesh.GetComponent<TMP_Text>().text = num.ToString();
    }

    //激活与取消激活
    protected void SetActive(GameObject go, bool isActive = true) {
        go.SetActive(isActive);
    }

    protected void SetActive(Transform trans, bool isActive = true)
    {
        SetActive(trans.gameObject,isActive);
    }

    protected void SetActive(Image img, bool isActive = true)
    {
        SetActive(img.gameObject, isActive);
    }

    protected void SetActive(Text txt, bool isActive = true)
    {
        SetActive(txt.gameObject, isActive);
    }

    protected void SetActive(RectTransform rectTrans, bool isActive = true)
    {
        SetActive(rectTrans.gameObject, isActive);
    }

    #endregion

}