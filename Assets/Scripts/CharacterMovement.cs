using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterStats stat;

    protected virtual void Awake()
    {
        stat = GetComponent<CharacterStats>();
    }

    protected virtual void Move()
    {

    }

    void Update()
    {
        Move();
    }
}
