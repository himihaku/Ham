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
    //public float moveTime = 10.0f;  // 移動時間
    //float elapsedTime = 0f;         // 経過時間
    //float rate;

    //// 位置
    //Vector3 preposition;            // 移動前位置
    //Vector3 postposition;           // 移動後位置

    //bool isMoving = true;

    //void Start()
    //{
    //    speed = 0.1f;
    //    //target.transform.position = new Vector3(5.5f, 3.2f, -2.8f);

    //    preposition = transform.position;   // 移動前位置
    //    postposition = new Vector3(preposition.x + 6.0f, preposition.y, preposition.z);   // 移動後位置(xを6移動)
    //}

    //void Update()
    //{
    //    if (isMoving == false) return;
    //    // 経過時間を過ぎたときの処理
    //    if (elapsedTime >= moveTime)
    //    {
    //        Debug.Log(elapsedTime);
    //        Debug.Log(moveTime);
    //        isMoving = false;
    //        return;
    //    }
    //    // 移動・回転k
    //    gameObject.transform.position = Vector3.Slerp(preposition, postposition, rate);

    //    //if (Input.GetMouseButtonUp(0))
    //    //{
    //    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    //    RaycastHit hit;
    //    //    int layerMask = (1 << LayerMask.NameToLayer("HitPanel")); //適当なレイヤーマスクを設定するよ

    //    //    if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
    //    //    {
    //    //        //レイが当たった位置を得るよ
    //    //        pos = hit.point;
    //    //        Debug.Log(pos);
    //    //    }
    //    //    target.transform.position = pos;
    //    //}

    //    //transform.position = Vector3.MoveTowards(transform.position, target, speed);


    //}
}
