using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //public GameObject gameObject;
    //private float speed;
    //public Transform target;
    //public Vector3 pos;
    //public float moveTime = 10.0f;  // 移動時間
    //float elapsedTime = 0f;         // 経過時間
    //float rate;
    private Vector3 mousePosition;
    private Vector3 objPosition;
    // 位置
    Vector3 preposition;            // 移動前位置
    Vector3 postposition;           // 移動後位置
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
        // 移動・回転k
        //Vector3 vector3 = Vector3.Slerp(preposition, postposition, rate);
        //gameObject.transform.position = vector3;

        //if (Input.GetMouseButtonUp(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    int layerMask = (1 << LayerMask.NameToLayer("HitPanel")); //適当なレイヤーマスクを設定するよ

        //    if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        //    {
        //        //レイが当たった位置を得るよ
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
