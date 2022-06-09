using ExitGames.Client.Photon;
using UnityEngine;

public class ColorSerialization
{
    private static byte[] colorMemory = new byte[4*4];

    public static short SerializColor(StreamBuffer outStream, object targetObject)
    {
        Color color = (Color) targetObject;

        lock(colorMemory)
        {
            byte[] bytes = colorMemory;
            int index = 0;

            Protocol.Serialize(color.r, bytes, ref index);
            Protocol.Serialize(color.g, bytes, ref index);
            Protocol.Serialize(color.b, bytes, ref index);
            Protocol.Serialize(color.a, bytes, ref index);
        }

        return 4 * 4;
    }

    public static object DeserializeColor(StreamBuffer inStream, short Length)
    {
        Color color = new Color();

        lock(colorMemory)
        {
            inStream.Read(colorMemory, 0, 4 * 4);
            int index = 0;

            Protocol.Serialize(color.r, colorMemory, ref index);
            Protocol.Serialize(color.g, colorMemory, ref index);
            Protocol.Serialize(color.b, colorMemory, ref index);
            Protocol.Serialize(color.a, colorMemory, ref index);
        } 

        return color;
    }
}
