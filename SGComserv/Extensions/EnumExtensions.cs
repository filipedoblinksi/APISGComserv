﻿using System.ComponentModel;
using System.Reflection;

namespace SGComserv.Extensions;

public static class EnumExtensions {
    public static string GetDescription(this Enum value) {
        FieldInfo info = value.GetType().GetField(value.ToString())!;
        DescriptionAttribute[] attributes = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);

        return attributes.Length > 0 ? attributes[0].Description : value.ToString();
    }
}
