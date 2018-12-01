using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location
{
    //world cords
    private Vector2 worldCore2D;

    //Zone
    private ZoneTypes zone;
    public enum ZoneTypes
    {
        A,
        B,
        C,
        None
    }


    public Vector2 WorldCore2D
    {
        get { return worldCore2D; }
    }

    public ZoneTypes Zone
    {
        get { return zone; }
    }

    public Location(Vector2 worldCore2D)
    {
        this.worldCore2D = worldCore2D;
        zone = ZoneTypes.None;
    }

    public Location(ZoneTypes zone)
    {
        worldCore2D = Vector2.zero;
        this.zone = zone;
    }

    public bool Compare(Location location)
    {
        if (worldCore2D != Vector2.zero && location.worldCore2D == worldCore2D)
        {
            return true;
        }
        else if (zone != ZoneTypes.None && location.zone == zone)
        {
            return true;
        }
        else
            return false;
    }
}
