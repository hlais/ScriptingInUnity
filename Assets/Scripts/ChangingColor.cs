using UnityEngine;


public class ChangingColor : MonoBehaviour
{
    Renderer m_renderer;

    public void Start()
    {
        m_renderer = GetComponent<Renderer>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            m_renderer.material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
           m_renderer.material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            m_renderer.material.color = Color.blue;
        }

    }
    private void OnMouseEnter()
    {
        m_renderer.material.color = Color.clear;
    }
    private void OnMouseOver()
    {
        m_renderer.material.color = Color.black;
    }
    private void OnMouseExit()
    {
        m_renderer.material.color = Color.cyan;
    }
}