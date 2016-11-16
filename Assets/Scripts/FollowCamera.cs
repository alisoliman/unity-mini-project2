﻿using UnityEngine;public class FollowCamera : MonoBehaviour {    public GameObject target;    public float rotateSpeed = 5;    Vector3 offset;    public float damping = 1;    void Start() {        offset = transform.position - target.transform.position;    }    void LateUpdate ()    {        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.        transform.position = target.transform.position + offset;    }}