﻿using System;
using System.Collections.Generic;

namespace AngleSharp.DTD
{
    sealed class DtdElementToken : DtdToken
    {
        #region ctor

        /// <summary>
        /// Creates a new entity token.
        /// </summary>
        public DtdElementToken()
        {
            _type = DtdTokenType.Element;
        }

        #endregion

        #region Properties

        public ElementDeclarationEntry.ContentType CType
        {
            get;
            set;
        }

        public ElementDeclarationEntry Entry
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public ElementDeclaration ToElement()
        {
            return new ElementDeclaration(this);
        }

        #endregion
    }
}
