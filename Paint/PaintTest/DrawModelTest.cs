using NUnit.Framework;
using Paint.Draw;
using System.Collections.Generic;

namespace PaintTest
{
    public class Tests
    {
        DrawModel drawModel;
        [SetUp]
        public void Setup()
        {
            List<Point> points1 = new List<Point>() { new Point(10f, 10), new Point(20f, 20f) };
            List<Point> points2 = new List<Point>() { new Point(50f, 50), new Point(20f, 20f) };

            Path path = new Path(points1, new Color(1, 2, 3), 10f);
            Path path2 = new Path(points2, new Color(1, 2, 3), 10f);
            drawModel = new DrawModel(new List<Path>() { path,path2 }, new Color(1, 2, 3), 15f);
        }

        [Test]
        public void DrawModel_Test_Clear()
        {
            int expected = 0;
            drawModel.Clear();
            int actual = drawModel.Paths.Count;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DrawModel_Test_Back()
        {
            int expected = 1;
            drawModel.Back();
            int actual = drawModel.Paths.Count;
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void Destroy()
        {
            Assert.Pass();
        }
    }