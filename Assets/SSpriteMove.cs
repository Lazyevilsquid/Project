using UnityEngine;
using System.Collections;

public class SSpriteMove : MonoBehaviour
{

   public Vector2 m_Vector = Vector2.zero;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
   void Update()
    {
        SpriteMove();       // 스프라이트 이동시켜주는 함수
    }

    /*
    transform.position : 전체 공간에서의 변환의 위치 
    transform.localPosition : 부모의 변환에 대해 상대적인 변환 위치.
    */

    void SpriteMove()
    {
        if (Input.GetKey(KeyCode.D))            // GetKey = 일치하게되는 키를 사용자가 누르는 동안 true로, KeyCode.D = 키 코드가 D일때
        {
            m_Vector.x += 0.5f;                 // Vector2 의 x값 변경
            transform.position = m_Vector;      // transform.postion 에 변경된 값 입력

            if (m_Vector.x > 8.5)               // 8.5 = 카메라 사이즈, 스프라이트가 카메라 밖에 못나가게 하기위해
            {
                m_Vector.x = 8.5f;              // 8.5 고정
                transform.position = m_Vector;  // 변경된 값 입력
            }

            // Debug.Log("Right");              // 로그로 입력되나 확인
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_Vector.x -= 0.5f;

            transform.position = m_Vector;

            if (m_Vector.x < -8.5)
            {
                m_Vector.x = -8.5f;
                transform.position = m_Vector;
            }

            // Debug.Log("Left");
        }
        if (Input.GetKey(KeyCode.W))
        {   
            m_Vector.y += 0.5f;

            transform.position = m_Vector;

            if (m_Vector.y > 4.5)
            {
                m_Vector.y = 4.5f;
                transform.position = m_Vector;
            }

            // Debug.Log("Up");
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_Vector.y -= 0.5f;

            transform.position = m_Vector;

            if (m_Vector.y < -4.5)
            {
                m_Vector.y = -4.5f;
                transform.position = m_Vector;
            }

            // Debug.Log("Down");
        }
    }
}