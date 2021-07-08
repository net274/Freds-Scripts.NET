﻿// Copyright Dirk Lemstra, Fred Weinhaus (https://github.com/dlemstra/ImageMagick.FredsScripts.NET)
//
// These scripts are available free of charge for non-commercial use, ONLY.
//
// For use of these scripts in commercial (for-profit) environments or non-free applications,
// please contact Fred Weinhaus (fmw at alink dot net) for licensing arrangements.
//
// If you: 1) redistribute, 2) incorporate any of these scripts into other free applications or
// 3) reprogram them in another scripting language, then you must contact Fred Weinhaus for
// permission, especially if the result might be used in a commercial or for-profit environment.
//
// Usage, whether stated or not in the script, is restricted to the above licensing arrangements.
// It is also subject, in a subordinate manner, to the ImageMagick license, which can be found at:
// http://www.imagemagick.org/script/license.php

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImageMagick.FredsScripts.NET.Tests
{
    public partial class EmbroideryScriptTests
    {
        [TestClass]
        public class TheConstructor : EmbroideryScriptTests
        {
            [TestMethod]
            public void ShouldThrowExceptionWhenFactoryIsNull()
            {
                ExceptionAssert.ThrowsArgumentException<ArgumentNullException>("factory", () => new EmbroideryScript<ushort>(null));
            }

            [TestMethod]
            public void ShouldSetTheDefaults()
            {
                var factory = new MagickFactory();
                var script = new EmbroideryScript<ushort>(factory);

                AssertDefaults(script);
            }
        }
    }
}
