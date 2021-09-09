using UnityEngine;

public class UseIntVariable : MonoBehaviour
{
    #region [Field] Fixed Number

    // �萔
    // ======================================================

    // ��׏���MAXHP
    private const int warriorHp = 100;
    private const int monkHp = 50;
    private const int blackMageHp = 30;
    private const int whiteMageHp = 30;
    private const int enemyHp = 100;

    // ��׏���ATK
    private const int warriorAtk = 5;
    private const int monkAtk = 15;
    private const int blackMageAtk = 20;
    private const int whiteMageAtk = 3;
    private const int enemyAtk = 20;

    // ��׏���HEAL
    private const int warriorHeal = 0;
    private const int monkHeal = 0;
    private const int blackMageHeal = 0;
    private const int whiteMageHeal = 20;

    // ======================================================

    #endregion

    #region [Field] Variable

    // �ϐ�
    // ======================================================

    // GameMain�ł̑���ݐ����ėp
    private int turnCount =1;

    // GameMain�ł̱�è����ݐؑ֗p�i1�`5���[�v�j
    private int activeTurnChange = 1;

    // �׸ފǗ��pbool�^
    private bool flag;

    // ======================================================

    #endregion

    // ��׏���MAXHP�ޯ�
    public int GetWarriorHp => warriorHp;
    public int GetMonkHp => monkHp;
    public int GetBlackMageHp => blackMageHp;
    public int GetWhiteMageHp => whiteMageHp;
    public int GetEnemyHp => enemyHp;

    // ��׏���ATK�ޯ�
    public int GetWarriorAtk => warriorAtk;
    public int GetMonkAtk => monkAtk;
    public int GetBlackMageAtk => blackMageAtk;
    public int GetWhiteMageAtk => whiteMageAtk;
    public int GetEnemyAtk => enemyAtk;

    // ��׏���HEAL�ޯ�
    public int GetWarriorHeal => warriorHeal;
    public int GetMonkHeal => monkHeal;
    public int GetBlackMageHeal => blackMageHeal;
    public int GetWhiteMageHeal => whiteMageHeal;

    // GameMain�ł̑���ݐ����Ĺޯ�
    public int GetTurnCount { get => this.turnCount; set => this.turnCount = value; }

    // GameMain�ł̱�è����ݐؑ֗p
    public int PropertyActiveTurnChange { get => this.activeTurnChange; set => this.activeTurnChange = value; }

    // �׸ފǗ��pbool�^
    public bool PropertyFlag { get => this.flag; set => this.flag = value; }
}