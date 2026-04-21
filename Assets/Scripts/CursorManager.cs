using UnityEngine;

public class CursorManager : MonoBehaviour
{
    private Gun gun;
    [SerializeField] private Texture2D cursorNormal;
    [SerializeField] private Texture2D cursorShoot;

    [SerializeField] private Texture2D cursorReload;
    private Vector2 hotspot = new Vector2(16, 48);
    void Start()
    {
        gun = FindObjectOfType<Gun>();
        Cursor.SetCursor(cursorNormal, hotspot, CursorMode.Auto);
    }

    void Update()
    {
        if (gun.isReload)
        {
            Cursor.SetCursor(cursorReload, hotspot, CursorMode.Auto);
            return;
        }
        else if (Input.GetMouseButton(0))
        {
            Cursor.SetCursor(cursorShoot, hotspot, CursorMode.Auto);

        }
        else
        {
            Cursor.SetCursor(cursorNormal, hotspot, CursorMode.Auto);

        }
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Cursor.SetCursor(cursorShoot, hotspot, CursorMode.Auto);
        // }
        // else if (Input.GetMouseButtonUp(0))
        // {
        //     Cursor.SetCursor(cursorNormal, hotspot, CursorMode.Auto);
        // }
        // if (Input.GetMouseButtonDown(1) || gun.isReload)
        // {
        //     Cursor.SetCursor(cursorReload, hotspot, CursorMode.Auto);
        // }
        // else if (Input.GetMouseButtonUp(1) || !gun.isReload)
        // {
        //     Cursor.SetCursor(cursorNormal, hotspot, CursorMode.Auto);
        // }
    }
}
