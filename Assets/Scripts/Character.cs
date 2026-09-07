using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("캐릭터 생성됨");
        Debug.Log("생성 위치: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
