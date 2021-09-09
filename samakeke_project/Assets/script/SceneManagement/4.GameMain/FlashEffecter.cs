using UnityEngine;

public class FlashEffecter : MonoBehaviour
{
    [SerializeField]
    private Animator Panel;

    public Animator GetPanel => this.Panel;
}