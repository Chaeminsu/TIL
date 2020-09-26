using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance =  null;
    static Managers Instance { get { Init(); return s_instance; }  }

    InputManger _input = new InputManger();
    public static InputManger input { get { return Instance._input; } }

    ResourceManger _resouce = new ResourceManger();
    public static ResourceManger Resource { get { return Instance._resouce; } }
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        input.OnUpdate();
    }
    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }


        
    }
}
