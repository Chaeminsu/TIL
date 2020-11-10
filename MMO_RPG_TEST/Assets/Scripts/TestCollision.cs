using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision !{collision.gameObject.name}");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trriger ! {other.gameObject.name}");
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        // Local <-> World <-> View Port <-> Screen
        //Screen 좌표
        //Debug.Log(Input.mousePosition);
        //Viewport
        //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition));
        //World 좌표

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);
            RaycastHit hit;

            LayerMask mask = LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");
            //int mask = (1 << 8) | (1 << 9);

            if (Physics.Raycast(ray, out hit, 100.0f, mask))
            {
                Debug.Log($"RayCast Camera {hit.collider.gameObject.name}");
            }
        }
        //if (Input.GetMouseButtonDown(0))
        //{

        //    Vector3 moustPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        //    Vector3 dir = (moustPos - Camera.main.transform.position).normalized;

        //    Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);
        //    RaycastHit hit;
        //    if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
        //    {
        //        Debug.Log($"RayCast Camera {hit.collider.gameObject.name}");
        //    }
        //}
    }
}
