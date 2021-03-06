﻿using System;
using System.Xml.Serialization;
using System.IO;

namespace TheGameProject
{
    public class SaveManager<T>
    {
        public Type Type;

        public SaveManager()
        {
            Type = typeof(T);
        }

        public T Load(string path)
        {
            T instance;
            using (TextReader reader = new StreamReader(path))
            {
                var xml = new XmlSerializer(Type);
                instance = (T)xml.Deserialize(reader);
            }

            return instance;
        }
           
        public void Save(string path, object obj)
        {
            using (TextWriter writer = new StreamWriter(path))
            {
                var xml = new XmlSerializer(Type);
                xml.Serialize(writer, obj);
            }
        }
    }
}
