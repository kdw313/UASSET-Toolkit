﻿using System;
using System.Collections.Generic;
using System.Text;
using UassetToolkit.UPropertyTypes;

namespace UassetToolkit.UStructTypes
{
    public class Vector3Struct : UStruct
    {
        public float x;
        public float y;
        public float z;

        public override void ReadStruct(IOMemoryStream ms, UAssetFile f, StructProperty s)
        {
            x = ms.ReadFloat();
            y = ms.ReadFloat();
            z = ms.ReadFloat();
        }

        public override string WriteString()
        {
            return $"x={x}, y={y}, z={z}";
        }
    }
}
