using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionSceneManagement : MonoBehaviour
{
    #region Field

    [SerializeField]
    private Button titleButton;
    
    private FindSingleObj singleObj;    // 文字列を管理しているスクリプト型変数

    #endregion

    void Start()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjString();

        titleButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(singleObj.GetSingleObjString.GetTitleScene);
        });
    }
}