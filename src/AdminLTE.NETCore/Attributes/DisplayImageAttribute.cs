﻿using System;

namespace AdminLTE.NETCore.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DisplayImageAttribute : Attribute
    {
        public readonly string DisplayImage;

        public DisplayImageAttribute(string image)  //image from http://fontawesome.io/icons/ to display
        {
            this.DisplayImage = image;
        }
    }
}