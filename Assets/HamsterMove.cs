using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HamsterMove : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject target;

    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
       
        if (GameObject.FindWithTag("floor"))
        {
            
        }
        agent.destination = target.transform.position;
    }
    //public GameObject gameObject;
    //private float speed;
    //public Transform target;
    //public Vector3 pos;
    //public float moveTime = 10.0f;  // �ړ�����
    //float elapsedTime = 0f;         // �o�ߎ���
    //float rate;

    //// �ʒu
    //Vector3 preposition;            // �ړ��O�ʒu
    //Vector3 postposition;           // �ړ���ʒu

    //bool isMoving = true;

    //void Start()
    //{
    //    speed = 0.1f;
    //    //target.transform.position = new Vector3(5.5f, 3.2f, -2.8f);

    //    preposition = transform.position;   // �ړ��O�ʒu
    //    postposition = new Vector3(preposition.x + 6.0f, preposition.y, preposition.z);   // �ړ���ʒu(x��6�ړ�)
    //}

    //void Update()
    //{
    //    if (isMoving == false) return;
    //    // �o�ߎ��Ԃ��߂����Ƃ��̏���
    //    if (elapsedTime >= moveTime)
    //    {
    //        Debug.Log(elapsedTime);
    //        Debug.Log(moveTime);
    //        isMoving = false;
    //        return;
    //    }
    //    // �ړ��E��]k
    //    gameObject.transform.position = Vector3.Slerp(preposition, postposition, rate);

    //    //if (Input.GetMouseButtonUp(0))
    //    //{
    //    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    //    RaycastHit hit;
    //    //    int layerMask = (1 << LayerMask.NameToLayer("HitPanel")); //�K���ȃ��C���[�}�X�N��ݒ肷���

    //    //    if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
    //    //    {
    //    //        //���C�����������ʒu�𓾂��
    //    //        pos = hit.point;
    //    //        Debug.Log(pos);
    //    //    }
    //    //    target.transform.position = pos;
    //    //}

    //    //transform.position = Vector3.MoveTowards(transform.position, target, speed);


    //}
}
