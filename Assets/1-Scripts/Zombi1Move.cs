﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi1Move : MonoBehaviour
{
    float rightMax = -0.7f; //아래로 이동가능한 (z)최대값
    float leftMax = -0.1f; //좌로 이동가능한 (z)최대값
    float direction = 0.2f; //이동속도+방향
    float currentPos;
    public float speed = 0.1f;
    void Start(){
    currentPos = transform.position.z;
    //startTime = Time.time;
}
   void Update()
{
    //float startTime = (Time.time - startTime); // duration
    //progress = Mathf.Clamp(progress, 0, 1);
    currentPos += Time.deltaTime * direction;

    if (currentPos >= rightMax)
    {
        direction *= -1;
        currentPos = rightMax;
    }
    //현재 위치(x)가 우로 이동가능한 (x)최대값보다 크거나 같다면
    //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 우로 이동가능한 (x)최대값으로 설정
    else if (currentPos <= leftMax)
    {
        direction *= -1;
        currentPos = leftMax;
    }
    //현재 위치(x)가 좌로 이동가능한 (x)최대값보다 크거나 같다면
    //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 좌로 이동가능한 (x)최대값으로 설정
    transform.position = new Vector3(transform.position.x,transform.position.y,currentPos);
    Debug.Log("Pos: " + transform.position);

}
}
