﻿/*
 *  The MIT License (MIT)
 *
 *	Copyright (c) 2014 Mateusz Majchrzak
 *
 *	Permission is hereby granted, free of charge, to any person obtaining a copy
 *	of this software and associated documentation files (the "Software"), to deal
 *	in the Software without restriction, including without limitation the rights
 *	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *	copies of the Software, and to permit persons to whom the Software is
 *	furnished to do so, subject to the following conditions:
 *
 *	The above copyright notice and this permission notice shall be included in all
 *	copies or substantial portions of the Software.
 *
 *	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *	SOFTWARE.
 */

using System;
using System.Collections.Generic;

namespace Store
{
    /// <summary>
    /// Common store interface.
    /// </summary>
    public interface IStore
    {
		/// <summary>
		/// Gets or sets the delegate.
		/// </summary>
		/// <value>The delegate.</value>
		IStoreDelegate Delegate { get; set; }

		/// <summary>
		/// Checks that store is available on the current device.
		/// </summary>
		bool IsAvailable { get; }

		/// <summary>
		/// Returns products that are available in store.
		/// </summary>
		IEnumerable<Product> Shelf { get; }

        /// <summary>
        /// Downloads products data form store.
        /// </summary>
        /// <param name="products"></param>
        /// <param name="handler"></param>
        void Request(IEnumerable<string> identifiers);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="handler"></param>
        void Purchase(string identifier);

        /// <summary>
        /// 
        /// </summary>
        void Restore();
    }
}