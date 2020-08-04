using System.Collections.Generic;
using NUnit.Framework;

namespace Acme.Models.Tests
{
    [TestFixture]
    public class ModelTests
    {
        [Test]
        public void WhenARectangleIsCreatedThenNoExceptionIsThrown()
        {
            Rectangle r = new Rectangle();
        }

        [Test]
        public void WhenASquareIsCreatedThenNoExceptionIsThrown()
        {
            var r = new Square();
        }

        [Test]
        public void WhenARectangleIsCreatedAndItsHeightAndWidthAreSetThenTheyReadBackCorectly()
        {
            Rectangle r = new Rectangle();

            r.SetWidth(10);
            r.SetHeight(15);

            Assert.AreEqual(r.GetWidth(), 10);
            Assert.AreEqual(r.GetHeight(), 15);
        }

        [Test]
        public void WhenASquareIsCreatedAndItsWidthIsSetThenTheHeightAndWidthReadBackCorrectly()
        {
            Rectangle s = new Square();

            s.SetWidth(17);

            Assert.AreEqual(s.GetWidth(), 17);
            Assert.AreEqual(s.GetHeight(), 17);
        }

        [Test]
        public void WhenASquareIsCreatedAndItsHeightIsSetThenTheHeightAndWidthReadBackCorrectly()
        {
            Rectangle s = new Square();
  
            s.SetHeight(6);

            Assert.AreEqual(s.GetHeight(), 6);
            Assert.AreEqual(s.GetWidth(), 6);
        }

        [Test]
        public void WhenASquareIsCreatedAndItsWidthIsSetThenTheIncreaseWidthMethodIsCalledThenTheHeightAndWidthAreCorrect()
        {
            Rectangle s = new Square();

            s.SetWidth(18);

            s.IncreaseWidth(2);

            Assert.AreEqual(s.GetHeight(), 20);
            Assert.AreEqual(s.GetWidth(), 20);
        }

        [Test]
        public void WhenASquareIsCreatedAndItsHeightIsSetThenTheIncreaseHeightMethodIsCalledThenTheHeightAndWidthAreCorrect()
        {
            Rectangle s = new Square();

            s.SetHeight(10);

            s.IncreaseHeight(5);

            Assert.AreEqual(s.GetHeight(), 15);
            Assert.AreEqual(s.GetWidth(), 15);
        }

        [Test]
        public void WhenACollectionOfRectanglesAreCreatedAndTheirWidthsAndHeightsAreSetThenTheirWidthIsDoubledThenTheSizesRemainCorrect()
        {
            var shapes = new List<Rectangle> {new Rectangle(), new Rectangle(), new Square()};

            shapes[0].SetWidth(10);
            shapes[0].SetHeight(15);

            shapes[1].SetWidth(12);
            shapes[1].SetHeight(14);

            shapes[2].SetWidth(10);
            shapes[2].SetHeight(10);

            shapes[0].IncreaseWidth(shapes[0].GetWidth());
            shapes[1].IncreaseWidth(shapes[1].GetWidth());
            shapes[2].IncreaseWidth(shapes[2].GetWidth());

            Assert.AreEqual(shapes[0].GetWidth(), 20);
            Assert.AreEqual(shapes[0].GetHeight(), 15);

            Assert.AreEqual(shapes[1].GetWidth(), 24);
            Assert.AreEqual(shapes[1].GetHeight(), 14);

            //This one is a square so the width and height should always be equal
            Assert.AreEqual(shapes[2].GetWidth(), 20);
            Assert.AreEqual(shapes[2].GetHeight(), 20);
        }
    }
}
