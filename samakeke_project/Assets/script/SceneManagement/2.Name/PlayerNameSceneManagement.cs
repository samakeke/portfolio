using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerNameSceneManagement : MonoBehaviour
{
    #region Field

    [SerializeField]
    private InputField pNameField;
    [SerializeField]
    private Text pNameText;
    [SerializeField]
    private Text text;

    private FindSingleObj singleObj;    // 文字列を管理しているスクリプト型変数

    #endregion

    void Start()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjString();

        pNameField.onEndEdit.AddListener(PlayerNameField);
    }

    public void PlayerNameField(string field)
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (pNameText.text == "")
            {
                text.text = singleObj.GetSingleObjString.GetPnameSceneText;
            }
            else
            {
                StaticPlayerName.PropertyPlayerName = pNameText.text;

                PlayerPrefs.SetString(singleObj.GetSingleObjString.GetPrefsKey,
                    StaticPlayerName.PropertyPlayerName);

                SceneManager.LoadScene(singleObj.GetSingleObjString.GetCharaSelectScene);
            }
        }
    }
}