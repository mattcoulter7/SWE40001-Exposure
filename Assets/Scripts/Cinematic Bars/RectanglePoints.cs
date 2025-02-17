using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for calculating various points that on a 3D Box
/// </summary>
public class RectanglePoints : MonoBehaviour
{
    /// <summary>The Height of the box</summary>
    public float height {
        get
        {
            return transform.localScale.y;
        }
    }
    
    /// <summary>The Width of the box</summary>
    public float width
    {
        get
        {
            return transform.localScale.x;
        }
    }
    
    /// <summary>The Depth of the box</summary>
    public float depth
    {
        get
        {
            return transform.localScale.z;
        }
    }

    /// <summary>The Bottom Middle of the box</summary>
    public Vector3 bottom
    {
        get
        {
            return transform.position - transform.up * height / 2;
        }
        set
        {
            transform.position = value + transform.up * height / 2;
        }
    }

    /// <summary>The Left Middle of the box</summary>
    public Vector3 left
    {
        get
        {
            return transform.position - transform.right * width / 2;
        }
        set
        {
            transform.position = value + transform.right * width / 2;
        }
    }
    
    /// <summary>The Bottom Left of the box</summary>
    public Vector3 backleft
    {
        get
        {
            return transform.position - transform.right * width / 2 + transform.forward * depth / 2;
        }
        set
        {
            transform.position = value + transform.right * width / 2 - transform.forward * depth / 2;
        }
    }
    
    /// <summary>The Front Left of the box</summary>
    public Vector3 frontLeft
    {
        get
        {
            return transform.position - transform.right * width / 2 - transform.forward * depth / 2;
        }
        set
        {
            transform.position = value + transform.right * width / 2 + transform.forward * depth / 2;
        }
    }
    
    /// <summary>The Bottom Left of the box</summary>
    public Vector3 localFrontLeft {
        get {
            return frontLeft - transform.position;
        }
    }

    public Vector3 frontBottomLeft 
    {
        get 
        {
            return frontLeft - transform.up * height / 2;
        }
        set 
        {
            frontLeft = value + transform.up * height / 2;
        }
    }
    public Vector3 frontTopLeft 
    {
        get 
        {
            return frontLeft + transform.up * height / 2;
        }
        set 
        {
            frontLeft = value - transform.up * height / 2;
        }
    }
    public Vector3 frontRight
    {
        get
        {
            return transform.position + transform.right * width / 2 - transform.forward * depth / 2;
        }
        set
        {
            transform.position = value - transform.right * width / 2 + transform.forward * depth / 2;
        }
    }

    public Vector3 frontBottomRight
    {
        get 
        {
            return frontRight - transform.up * height / 2;
        }
        set 
        {
            frontLeft = value + transform.up * height / 2;
        }
    }
    public Vector3 frontTopRight
    {
        get 
        {
            return frontRight + transform.up * height / 2;
        }
        set 
        {
            frontRight = value - transform.up * height / 2;
        }
    }
}
