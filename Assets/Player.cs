using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //public GameObject gameObject;
    //private float speed;
    //public Transform target;
    //public Vector3 pos;
    //public float moveTime = 10.0f;  // �ړ�����
    //float elapsedTime = 0f;         // �o�ߎ���
    //float rate;
    private Vector3 mousePosition;
    private Vector3 objPosition;
    // �ʒu
    Vector3 preposition;            // �ړ��O�ʒu
    Vector3 postposition;           // �ړ���ʒu
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        transform.Translate(0f, 0f, 0.05f);
    //    }
    //    if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        transform.Translate(0f, 0f, -0.05f);
    //    }
    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        transform.Translate(-0.05f, 0f, 0f);
    //    }
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        transform.Translate(0.05f, 0f, 0f);
    //    }
    //}
    void Update()
    {
        // �ړ��E��]k
        //Vector3 vector3 = Vector3.Slerp(preposition, postposition, rate);
        //gameObject.transform.position = vector3;

        //if (Input.GetMouseButtonUp(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    int layerMask = (1 << LayerMask.NameToLayer("HitPanel")); //�K���ȃ��C���[�}�X�N��ݒ肷���

        //    if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        //    {
        //        //���C�����������ʒu�𓾂��
        //        pos = hit.point;
        //        Debug.Log(pos);
        //    }
        //    target.transform.position = pos;
        //}
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = 10.0f;
            objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            this.transform.position = objPosition;
        }
        //transform.position = Vector3.MoveTowards(transform.position, target, speed);

    }
}
