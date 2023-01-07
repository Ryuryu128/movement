using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTile : Tile
{
    public override void RunCommand(Ground ground, Coordinate pos)
    {
        foreach (var entity in ground.EntityList) {
            if (entity.EntityType == ENTITY_TYPE.POWER) {
                Debug.Log("Game Clear");
                // ���� Ŭ��� �۵���Ű�� �Լ�
                return;
            }
        }
    }
}
