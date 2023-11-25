using NUnit.Framework;

namespace TestMindbox
{
    [TestFixture]
    public class GeometryTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new(5);
            Assert.AreEqual(Math.PI * 25, circle.GetArea(), 0.001);
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea(), 0.001);
        }

        [Test]
        public void RightAngledTriangleCheck()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());

            Triangle nonRightAngledTriangle = new(3, 4, 6);
            Assert.IsFalse(nonRightAngledTriangle.IsRightAngled());
        }
    }
}
