using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public Color[] colors; 
    private int currentColorIndex = 0;
    private Renderer renderer;

    void Start()
    {
        
        renderer = GetComponent<Renderer>();

        
        if (renderer != null && colors.Length > 0)
        {
            renderer.material.color = colors[currentColorIndex];
        }
        else
        {
            Debug.LogError("Renderer component not found or no colors assigned!");
        }
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        renderer.material.color = colors[currentColorIndex];
    }
}