using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatusDraw : MonoBehaviour
{
    #region Field

    [SerializeField]
    private Text[] ui_name = new Text[5];                      // ���O�̕`��p
    [SerializeField]
    private Text[] ui_hp = new Text[5];                        // HP�̕`��p

    Party[] partyInstance = new Party[4];
    Enemy enemyInstance;

    private FindSingleObj singleObj;    // ��������Ǘ����Ă���X�N���v�g�^�ϐ�

    #endregion

    void Awake()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjString();
        singleObj.SingleObjInt();

        Instantiate();

        PartyStatusDraw();
    }

    public void Instantiate()
    {
        partyInstance[0] = new Party((Job)Enum.ToObject(typeof(Job),
            StaticPlayerJobReference.PropertyPlayerStatus));     // �v���C���[�쐬

        enemyInstance = new Enemy();                             // �G�쐬

        for (int i = 1; i < 4; i++)                              // NPC3�l�쐬
        {
            int index = i;

            partyInstance[index] = new Party((Job)Enum.ToObject(typeof(Job), index));
        }
    }

    public void PartyStatusDraw()
    {
        singleObj.GetSingleObjString.PropertyPname = StaticPlayerName.PropertyPlayerName;

        for (int i = 0; i < partyInstance.Length; i++)     // �p�[�e�B�̃X�e�[�^�X�`��
        {
            int index = i;

            ui_name[index].text = singleObj.GetSingleObjString.GetName(index);

            ui_hp[index].text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetUi_hpText
                + partyInstance[index].PropertyHp.ToString() + singleObj.GetSingleObjString.GetColorEnd;
        }

        ui_name[4].text = singleObj.GetSingleObjString.GetName(4);

        ui_hp[4].text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetUi_hpText
            + enemyInstance.PropertyHp.ToString() + singleObj.GetSingleObjString.GetColorEnd;
    }

    //public void PartyHeal(Party party, int num)
    //{
    //    party.PropertyHp = party.PropertyHp + intVar.GetWhiteMageHeal;

    //    ui_hp[].text = strVar.GetGreenColor + strVar.GetUi_hpText
    //        + party.PropertyHp + strVar.GetColorEnd;
    //}

    public void PartyAttack(Party party, Enemy enemy)
    {
        enemy.PropertyHp = enemy.PropertyHp - party.PropertyAtk;

        EnemyDeath(enemy);
    }

    public void EnemyAttack(Enemy enemy, Party party)
    {
        party.PropertyHp = party.PropertyHp - enemy.PropertyAtk;

        PartyDeath(party);
    }

    public void PartyDeath(Party party)
    {
        if (party.PropertyHp <= 0)
        {
            party.PropertyHp = 0;

            ui_hp[0].text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetUi_hpText
            + party.PropertyHp + singleObj.GetSingleObjString.GetColorEnd;

            SceneManager.LoadScene(singleObj.GetSingleObjString.GetCreditScene);
        }
        else
        {
            ui_hp[0].text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetUi_hpText
            + party.PropertyHp + singleObj.GetSingleObjString.GetColorEnd;
        }
    }

    public void EnemyDeath(Enemy enemy)
    {
        if (enemy.PropertyHp <= 0)
        {
            enemy.PropertyHp = 0;

            ui_hp[4].text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetUi_hpText
            + enemy.PropertyHp + singleObj.GetSingleObjString.GetColorEnd;

            SceneManager.LoadScene(singleObj.GetSingleObjString.GetCreditScene);
        }
        else
        {
            ui_hp[4].text = singleObj.GetSingleObjString.GetGreenColor + singleObj.GetSingleObjString.GetUi_hpText
            + enemy.PropertyHp + singleObj.GetSingleObjString.GetColorEnd;
        }
    }

    public Party GetPlayerInstance => this.partyInstance[0];
    public Party GetNpc1Instance => this.partyInstance[1];
    public Party GetNpc2Instance => this.partyInstance[2];
    public Party GetNpc3Instance => this.partyInstance[3];
    public Enemy GetEnemyInstance => this.enemyInstance;
}