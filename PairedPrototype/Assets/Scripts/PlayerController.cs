using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 8f;
    public Transform movePoint;

    public LayerMask whatStopsMovement;
    public Tilemap walkableTiles;
    Color newColor = new Color(1f, 1f, 1f, 0.3f);

    // Start is called before the first frame update
    void Start()
    {
        // make the movePoint independent of the parent
        movePoint.parent = null;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, movePoint.position) <= 0.001f)
        {
            
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), 0.2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }

            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), 0.2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }

            //movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
        }


        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        Vector3Int cellPos = walkableTiles.WorldToCell(transform.position);
        //Debug.Log(cellPos);

        walkableTiles.SetTileFlags(cellPos, TileFlags.None);
        walkableTiles.SetColor(cellPos, newColor);
        //Debug.Log(walkableTiles.GetTile(cellPos));


    }
}
