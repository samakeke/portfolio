using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharaSelectSceneManagement : MonoBehaviour
{

    #region Field

    [SerializeField]
    private Text pNameText;
    [SerializeField]
    private Button[] jobButton;
    [SerializeField]
    private DiaLog jobDialog;
    [SerializeField]
    private GameObject[] dialogObj;

    private FindSingleObj singleObj;    // 文字列を管理しているスクリプト型変数

    #endregion

    void Start()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjString();

        pNameText.text = StaticPlayerName.PropertyPlayerName + singleObj.GetSingleObjString.GetCharaSelectText;

        JobButtonRegister();
    }

    public void JobButtonRegister()
    {
        for (int i = 0; i < 4; i++)     // warrior,monk,blackMage,whiteMageの4ジョブ分のボタンを登録する
        {
            int index = i;

            jobButton[index].onClick.AddListener(() =>
            {
                StaticPlayerJobReference.PropertyPlayerStatus = index;  // プレイヤーインスタンス作成のための変数を用意
                                                                        // この時点ではまだインスタンス化しない
                dialogObj[index].gameObject.SetActive(true);
            });
        }
    }
}