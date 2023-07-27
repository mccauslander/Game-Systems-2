using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Week2GridLesson : MonoBehaviour
{
    private int length = 16;
    private int height = 9;
    private Vector2 cellRef;

    private bool toggleLessonGrid = true;

    private void Start()
    {
        cellRef = new Vector2(1.0f,1.0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        

        if (GUI.Button(ScreenPlacement(cellRef, cellRef), "Button"))
        {
            if (!toggleLessonGrid) 
            {
                toggleLessonGrid = true;
            }
            else
            {
                toggleLessonGrid = false;
            }
        }

        if (toggleLessonGrid)
        {
            LessonGrid();

        }
    }

    void LessonGrid()
    {
        Vector2 gridVect = new Vector2 (0, 0);
        for (int x = 0; x < length; x++)
        {
            for (int y = 0; y < height; y++)
            {
                gridVect.x = x;
                gridVect.y = y;
                GUI.Box(ScreenPlacement(gridVect, cellRef), "");
                GUI.Label(ScreenPlacement(gridVect, cellRef), "X: " + x + " Y: " + y);
            }
        }
    }

    Rect ScreenPlacement(Vector2 startPos, Vector2 cellSize)
    {
        Rect placement = new Rect(startPos.x * Screen.width / length, startPos.y * Screen.height / height, cellSize.x * Screen.width / length, cellSize.y * Screen.height / height);

        return placement;
    }
}
