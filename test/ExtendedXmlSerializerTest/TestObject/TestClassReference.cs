﻿// MIT License
// 
// Copyright (c) 2016 Wojciech Nagórski
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
using System.Collections.Generic;

namespace ExtendedXmlSerialization.Test.TestObject
{
    public class TestClassReferenceWithDictionary
    {
        public TestClassReference Parent { get; set; }

        public Dictionary<int, TestClassReference> All { get; set; }
    }

    public class TestClassReferenceWithList
    {
        public TestClassReference Parent { get; set; }

        public List<TestClassReference> All { get; set; }
    }
    public interface IReference
    {
        int Id { get; set; }
    }
    public class TestClassReference : IReference
    {
        public int Id { get; set; }
        public TestClassReference CyclicReference { get; set; }
        public TestClassReference ObjectA { get; set; }

        public TestClassReference ReferenceToObjectA { get; set; }

        public List<TestClassReference> Lists { get; set; }
    }
}
