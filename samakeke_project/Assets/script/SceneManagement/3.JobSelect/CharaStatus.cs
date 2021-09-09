using UnityEngine;

// �W���u
public enum Job
{
    warrior = 0,
    monk = 1,
    blackMage = 2,
    whiteMage = 3
}

// �L�����N�^�[���N���X
public class Chara
{
    private int hp;
    private int atk;

    public int PropertyHp { get => this.hp; set => this.hp = value; }
    public int PropertyAtk { get => this.atk; set => this.atk = value; }
}

// �p�[�e�B��p�X�e�[�^�X
public class Party : Chara
{
    #region Field

    private int heal;
    private int mJob;

    private FindSingleObj singleObj;    // ��������Ǘ����Ă���X�N���v�g�^�ϐ�

    #endregion

    public Party(Job job)
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjInt();

        mJob = (int)job;

        switch(mJob)
        {
            case (int)Job.warrior:
                PropertyHp = singleObj.GetSingleObjInt.GetWarriorHp;
                PropertyAtk = singleObj.GetSingleObjInt.GetWarriorAtk;
                this.heal = singleObj.GetSingleObjInt.GetWarriorHeal;
                break;
            case (int)Job.monk:
                PropertyHp = singleObj.GetSingleObjInt.GetMonkHp;
                PropertyAtk = singleObj.GetSingleObjInt.GetMonkAtk;
                this.heal = singleObj.GetSingleObjInt.GetMonkHeal;
                break;
            case (int)Job.blackMage:
                PropertyHp = singleObj.GetSingleObjInt.GetBlackMageHp;
                PropertyAtk = singleObj.GetSingleObjInt.GetBlackMageAtk;
                this.heal = singleObj.GetSingleObjInt.GetBlackMageHeal;
                break;
            case (int)Job.whiteMage:
                PropertyHp = singleObj.GetSingleObjInt.GetWhiteMageHp;
                PropertyAtk = singleObj.GetSingleObjInt.GetWhiteMageAtk;
                this.heal = singleObj.GetSingleObjInt.GetWhiteMageHeal;
                break;
        }
    }

    public int PropertyJob => this.mJob;
}

// �G�l�~�[��p�X�e�[�^�X
public class Enemy : Chara
{
    #region Field

    private FindSingleObj singleObj;    // ��������Ǘ����Ă���X�N���v�g�^�ϐ�

    #endregion

    public Enemy()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjInt();

        PropertyHp = singleObj.GetSingleObjInt.GetEnemyHp;
        PropertyAtk = singleObj.GetSingleObjInt.GetEnemyAtk;
    }
}