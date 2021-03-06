﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct RubikCubeFaces
{
    public enum CubeFace
    {

        Front,
        Back,
        Right,
        Left,
        Up,
        Down
    }

    public CubeFace Face;
    public Color Color;
}

[System.Serializable]
public class RubikCubeFaceColors
{
    public List<Color> frontFaceColors = new List<Color>();
    public List<Vector3> frontPositions = new List<Vector3>();

    public List<Color> backFaceColors = new List<Color>();
    public List<Vector3> backPositions = new List<Vector3>();

    public List<Color> upFaceColors = new List<Color>();
    public List<Vector3> upPositions = new List<Vector3>();

    public List<Color> downFaceColors = new List<Color>();
    public List<Vector3> downPositions = new List<Vector3>();

    public List<Color> rightFaceColors = new List<Color>();
    public List<Vector3> rightPositions = new List<Vector3>();

    public List<Color> leftFaceColors = new List<Color>();
    public List<Vector3> leftPositions = new List<Vector3>();
}

[CreateAssetMenu(fileName = "New Rubik Cube Preset", menuName = "Rubik Cube/Rubik Cube Preset", order = 0)]
public class RubikCubePreset : ScriptableObject
{
    private void OnEnable()
    {
        FrontFace.Face = RubikCubeFaces.CubeFace.Front;
        BackFace.Face = RubikCubeFaces.CubeFace.Back;
        RightFace.Face = RubikCubeFaces.CubeFace.Right;
        LeftFace.Face = RubikCubeFaces.CubeFace.Left;
        UpFace.Face = RubikCubeFaces.CubeFace.Up;
        DownFace.Face = RubikCubeFaces.CubeFace.Down;
    }

    public RubikCubeFaces FrontFace;
    public RubikCubeFaces BackFace;
    public RubikCubeFaces RightFace;
    public RubikCubeFaces LeftFace;
    public RubikCubeFaces UpFace;
    public RubikCubeFaces DownFace;
}
