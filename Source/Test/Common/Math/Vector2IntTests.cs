using App.Common.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Common.Math
{
    internal class Vector2IntTests
    {
        [Test]
        public void Equals_WithSameValues_ShouldBeTrue()
        {
            var a = new Vector2Int(1, 2);
            var b = new Vector2Int(1, 2);

            Assert.That(a.Equals(b), Is.True);
            Assert.That(a.Equals((object)b), Is.True);
            Assert.That(a == b, Is.True);
            Assert.That(a != b, Is.False);
        }

        [Test]
        public void Equals_WithDifferentValues_ShouldBeFalse()
        {
            var a = new Vector2Int(1, 2);
            var b = new Vector2Int(2, 1);

            Assert.Multiple(() =>
            {
                Assert.That(a.Equals(b), Is.False);
                Assert.That(a.Equals((object)b), Is.False);
                Assert.That(a == b, Is.False);
                Assert.That(a != b, Is.True);
            });
        }

        [Test]
        public void Equals_WithNullObject_ShouldBeFalse()
        {
            var a = new Vector2Int(1, 2);

            Assert.That(a.Equals(null), Is.False);
        }

        [Test]
        public void GetHashCode_WithSameValues_ShouldMatch()
        {
            var a = new Vector2Int(1, 2);
            var b = new Vector2Int(1, 2);

            Assert.That(b.GetHashCode(), Is.EqualTo(a.GetHashCode()));
        }

        [Test]
        public void GetHashCode_WithDifferentValues_ShouldNotMatch()
        {
            var a = new Vector2Int(1, 2);
            var b = new Vector2Int(2, 1);

            Assert.That(b.GetHashCode(), Is.Not.EqualTo(a.GetHashCode()));
        }

        [Test]
        public void Operators_ShouldWorkAsExpected()
        {
            var a = new Vector2Int(1, 2);
            var b = new Vector2Int(3, 4);

            Assert.That(a + b, Is.EqualTo(new Vector2Int(4, 6)));
            Assert.That(a - b, Is.EqualTo(new Vector2Int(-2, -2)));
            Assert.That(a * b, Is.EqualTo(new Vector2Int(3, 8)));
            Assert.That(2 * a, Is.EqualTo(new Vector2Int(2, 4)));
            Assert.That(a * 2, Is.EqualTo(new Vector2Int(2, 4)));
            Assert.That(b / 3, Is.EqualTo(new Vector2Int(1, 1)));
            Assert.That(-a, Is.EqualTo(new Vector2Int(-1, -2)));
        }
    }
}
