using System;

namespace SGComserv.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IgnoreOnInsertAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class IgnoreOnUpdateAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class IgnoreOnHistoricAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class KeyOriginalAttribute : Attribute
    {
        public string FieldKeyOriginal { get; }

        public KeyOriginalAttribute(string keyOriginal)
        {
            FieldKeyOriginal = keyOriginal;
        }
    }


    [AttributeUsage(AttributeTargets.Property)]
    public class AutoIncrementAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class SufixoNivelSenhaAttribute : Attribute
    {
        public string Nivel { get; }

        public SufixoNivelSenhaAttribute(string nivel)
        {
            Nivel = nivel;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MainTableAttribute : Attribute
    {
        public string MainTable { get; }

        public MainTableAttribute(string mainTable)
        {
            MainTable = mainTable;
        }
    }
}

