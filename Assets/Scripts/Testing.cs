using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private Unit unit;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            // GridPosition mouseGridPosition = LevelGrid.Instance.GetGridPosition(MouseWorld.GetPosition());
            // GridPosition startGridPostion = new GridPosition(0, 0);

            // List<GridPosition> gridPositionList = Pathfinding.Instance.FindPath(startGridPostion, mouseGridPosition);

            // if (gridPositionList == null)
            // {
            //     return;
            // }

            // for (int i = 0; i < gridPositionList.Count - 1; i++)
            // {
            //     Debug.DrawLine(
            //         LevelGrid.Instance.GetWorldPosition(gridPositionList[i]),
            //         LevelGrid.Instance.GetWorldPosition(gridPositionList[i + 1]),
            //         Color.white,
            //         10f
            //     );
            // }
            ScreenShake.Instance.Shake(5f);
        }
    }
}
