using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour
{

    public Material key1;
    public Material key2;
    public Material key3;
    public Material key4;
    public Material key5;
    public Material key6;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        if (Input.GetKeyDown(KeyCode.Alpha1))
            renderer.material = key1;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            renderer.material = key2;
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            renderer.material = key3;
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            renderer.material = key4;
        else if (Input.GetKeyDown(KeyCode.Alpha5))
            renderer.material = key5;
        else if (Input.GetKeyDown(KeyCode.Alpha6))
            renderer.material = key6;
    }
}
