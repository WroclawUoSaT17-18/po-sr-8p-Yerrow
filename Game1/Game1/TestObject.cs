using System;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    /// <summary>
    /// A small class to show Serialization with
    /// </summary>
    public class TestObject
    {
        public Vector2 Position;
        [XmlIgnore]
        public Texture2D Texture;

    }


}