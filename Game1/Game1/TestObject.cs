using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class TestObject
    {
        public Vector2 Position;
        [XmlIgnore]
        public Texture2D Texture;
    }
}