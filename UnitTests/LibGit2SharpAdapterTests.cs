using System;
using LibGit2SharpAdapter;
using Xunit;

namespace UnitTests
{
    public class LibGit2SharpAdapterTests
    {
        [Fact]
        public void Test1()
        {
            new Adapter().Method();
        }
    }
}