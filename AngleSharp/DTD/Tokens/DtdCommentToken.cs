﻿using AngleSharp.DOM;
using AngleSharp.Xml;
using System;

namespace AngleSharp.DTD
{
    sealed class DtdCommentToken : DtdToken
    {
        #region Members

        String _data;

        #endregion

        #region ctor

        public DtdCommentToken(XmlCommentToken token)
        {
            _type = DtdTokenType.Comment;
            _data = token.Data;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the supplied data.
        /// </summary>
        public String Data
        {
            get { return _data; }
            set { _data = value; }
        }

        #endregion

        #region Methods

        public Comment ToElement()
        {
            var comment = new Comment();
            comment.Data = _data;
            return comment;
        }

        #endregion
    }
}
