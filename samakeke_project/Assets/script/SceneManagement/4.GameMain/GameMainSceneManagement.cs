using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class GameMainSceneManagement : MonoBehaviour
{
    #region Field

    [SerializeField]
    private Button battleButton;
    [SerializeField]
    private Button healButton;
    [SerializeField]
    private Text battleLog;
    [SerializeField]
    private Text turnText;
    [SerializeField]
    private GameObject playerPanel;
    [SerializeField]
    private GameObject npc1Panel;
    [SerializeField]
    private GameObject npc2Panel;
    [SerializeField]
    private GameObject npc3Panel;

    private FindSingleObj singleObj;    // 文字列を管理しているスクリプト型変数
    private StatusDraw statusDraw;
    private FlashEffecter playerFlash;
    private FlashEffecter npc1Flash;
    private FlashEffecter npc2Flash;
    private FlashEffecter npc3Flash;

    #endregion

    void Start()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjString();
        singleObj.SingleObjInt();

        playerFlash = playerPanel.GetComponent<FlashEffecter>();
        npc1Flash = npc1Panel.GetComponent<FlashEffecter>();
        npc2Flash = npc2Panel.GetComponent<FlashEffecter>();
        npc3Flash = npc3Panel.GetComponent<FlashEffecter>();

        statusDraw = GetComponent<StatusDraw>();

        StartCoroutine(Main());
    }

    IEnumerator Main()
    {
        for (; ; )
        {
            ActiveTurn(singleObj.GetSingleObjInt.PropertyActiveTurnChange);
            
            if (singleObj.GetSingleObjInt.PropertyActiveTurnChange == 5)
            {
                yield return null;
                StartCoroutine(enemyTurn());
            }

            //yield return healButton.OnClickAsObservable().First().ToYieldInstruction();
            //HealButtonOnClick();

            yield return battleButton.OnClickAsObservable().First().ToYieldInstruction();
            BattleButtonOnClick();
                
            yield return null;
        }
    }

    // 現在誰のターンかを判断する関数
    public void ActiveTurn(int num)
    {
        switch (num)
        {
            case 1:
                singleObj.GetSingleObjInt.PropertyFlag = ActiveCharJob(statusDraw.GetPlayerInstance);
                healButton.gameObject.SetActive(singleObj.GetSingleObjInt.PropertyFlag);

                battleLog.text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetName(0)
                    + singleObj.GetSingleObjString.GetColorEnd + singleObj.GetSingleObjString.GetUi_turnText;

                turnText.text = singleObj.GetSingleObjInt.GetTurnCount + "ターン目";

                playerFlash.GetPanel.SetBool(singleObj.GetSingleObjString.GetPlayerFlashFlagName, true);
                npc1Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc1FlashFlagName, false);
                npc2Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc2FlashFlagName, false);
                npc3Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc3FlashFlagName, false);

                break;
            case 2:
                singleObj.GetSingleObjInt.PropertyFlag = ActiveCharJob(statusDraw.GetNpc1Instance);
                healButton.gameObject.SetActive(singleObj.GetSingleObjInt.PropertyFlag);

                battleLog.text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetName(1)
                    + singleObj.GetSingleObjString.GetColorEnd + singleObj.GetSingleObjString.GetUi_turnText;

                turnText.text = singleObj.GetSingleObjInt.GetTurnCount + "ターン目";

                playerFlash.GetPanel.SetBool(singleObj.GetSingleObjString.GetPlayerFlashFlagName, false);
                npc1Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc1FlashFlagName, true);
                npc2Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc2FlashFlagName, false);
                npc3Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc3FlashFlagName, false);
                break;
            case 3:
                singleObj.GetSingleObjInt.PropertyFlag = ActiveCharJob(statusDraw.GetNpc2Instance);
                healButton.gameObject.SetActive(singleObj.GetSingleObjInt.PropertyFlag);

                battleLog.text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetName(2)
                    + singleObj.GetSingleObjString.GetColorEnd + singleObj.GetSingleObjString.GetUi_turnText;

                turnText.text = singleObj.GetSingleObjInt.GetTurnCount + "ターン目";

                playerFlash.GetPanel.SetBool(singleObj.GetSingleObjString.GetPlayerFlashFlagName, false);
                npc1Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc1FlashFlagName, false);
                npc2Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc2FlashFlagName, true);
                npc3Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc3FlashFlagName, false);
                break;
            case 4:
                singleObj.GetSingleObjInt.PropertyFlag = ActiveCharJob(statusDraw.GetNpc3Instance);
                healButton.gameObject.SetActive(singleObj.GetSingleObjInt.PropertyFlag);

                battleLog.text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetName(3)
                    + singleObj.GetSingleObjString.GetColorEnd + singleObj.GetSingleObjString.GetUi_turnText;

                turnText.text = singleObj.GetSingleObjInt.GetTurnCount + "ターン目";

                playerFlash.GetPanel.SetBool(singleObj.GetSingleObjString.GetPlayerFlashFlagName, false);
                npc1Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc1FlashFlagName, false);
                npc2Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc2FlashFlagName, false);
                npc3Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc3FlashFlagName, true);
                break;
            case 5:
                singleObj.GetSingleObjInt.PropertyFlag = false;
                battleButton.gameObject.SetActive(singleObj.GetSingleObjInt.PropertyFlag);
                healButton.gameObject.SetActive(singleObj.GetSingleObjInt.PropertyFlag);

                battleLog.text = singleObj.GetSingleObjString.GetRedColor + singleObj.GetSingleObjString.GetName(4)
                    + singleObj.GetSingleObjString.GetColorEnd + singleObj.GetSingleObjString.GetUi_turnText;

                playerFlash.GetPanel.SetBool(singleObj.GetSingleObjString.GetPlayerFlashFlagName, false);
                npc1Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc1FlashFlagName, false);
                npc2Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc2FlashFlagName, false);
                npc3Flash.GetPanel.SetBool(singleObj.GetSingleObjString.GetNpc3FlashFlagName, false);
                break;
        }
    }

    public void BattleButtonOnClick()
    {
        BattleButton(singleObj.GetSingleObjInt.PropertyActiveTurnChange);
    }

    public void BattleButton(int num)
    {
        switch (num)
        {
            case 1:
                statusDraw.PartyAttack(statusDraw.GetPlayerInstance, statusDraw.GetEnemyInstance);

                singleObj.GetSingleObjInt.PropertyActiveTurnChange++;
                singleObj.GetSingleObjInt.GetTurnCount++;
                break;
            case 2:
                statusDraw.PartyAttack(statusDraw.GetNpc1Instance, statusDraw.GetEnemyInstance);

                singleObj.GetSingleObjInt.PropertyActiveTurnChange++;
                singleObj.GetSingleObjInt.GetTurnCount++;
                break;
            case 3:
                statusDraw.PartyAttack(statusDraw.GetNpc2Instance, statusDraw.GetEnemyInstance);

                singleObj.GetSingleObjInt.PropertyActiveTurnChange++;
                singleObj.GetSingleObjInt.GetTurnCount++;
                break;
            case 4:
                statusDraw.PartyAttack(statusDraw.GetNpc3Instance, statusDraw.GetEnemyInstance);

                singleObj.GetSingleObjInt.PropertyActiveTurnChange++;
                singleObj.GetSingleObjInt.GetTurnCount++;
                break;
        }
    }

    IEnumerator enemyTurn()
    {
        yield return new WaitForSeconds(1.0f);
        statusDraw.EnemyAttack(statusDraw.GetEnemyInstance, statusDraw.GetPlayerInstance);
        yield return new WaitForSeconds(1.0f);

        battleButton.gameObject.SetActive(true);
        singleObj.GetSingleObjInt.PropertyActiveTurnChange = 1;

        turnText.text = singleObj.GetSingleObjInt.GetTurnCount + "ターン目";
    }

    // 現在アクティブなキャラが白魔導士かどうかを判断する
    public bool ActiveCharJob(Party party)
    {
        if (Job.whiteMage == (Job)Enum.ToObject(typeof(Job), party.PropertyJob))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}