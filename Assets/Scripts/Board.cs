using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Board : SolidObject
    {
        public Cell cellPrefab;
        public Cell[,] cellArray = new Cell[6, 4];

        public void Setup()
        {
            for (float x = 0, parsX = 0; x < 6f; x++, parsX += 1.2f)
            {
                for(float y = 0, parsY = 0; y < 4f; y++, parsY += 1.2f)
                {
                    Vector3 newVec = new Vector3(x + parsX - 5.5f, y + parsY - 2f, 3f);
                    Cell newCell = Instantiate(cellPrefab, newVec, Quaternion.identity);
                    newCell.transform.Rotate(90, 180, 0, Space.Self);
                    Material material = newCell.GetComponent<Renderer>().material;
                    if (x < 3)
                    {
                        material.color = new Color(0.6f, 0.75f, 1, 1); //Blue
                    }
                    else
                    {
                        material.color = new Color(1f, 0.2f, 0.2f, 1f); //Red
                    }
                    cellArray[(int) x, (int) y] = newCell;
                }
            }
        }
    }
}