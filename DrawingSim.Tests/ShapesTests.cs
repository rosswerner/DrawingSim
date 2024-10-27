using static System.Net.Mime.MediaTypeNames;

namespace DrawingSim.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        #region Shape Tests
        [Test]
        public void ShapeNegativeX_ShouldThrowArgumentException_WithExpectedMessage( )
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentException>( ( ) => new Square( -10, 10, 10 ) );

            // Assert
            Assert.That( ex.Message, Is.EqualTo( "X value must not be negative." ) );
        }

        [Test]
        public void ShapeNegativeY_ShouldThrowArgumentException_WithExpectedMessage( )
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentException>( ( ) => new Square( 10, -10, 10 ) );

            // Assert
            Assert.That( ex.Message, Is.EqualTo( "Y value must not be negative." ) );
        }
        #endregion

        #region Rectangle Tests
        [Test]
        public void RectangleOutput_ShouldReturnCorrectValue( )
        {
            // Arrange
             Rectangle rectangle = new Rectangle( 10, 10, 30, 40 );

            // Act
            string shapeOutput = rectangle.WriteProperties();

            // Assert
            Assert.That( shapeOutput, Is.EqualTo( "Rectangle (10,10) width=30 height=40" ) );
        }

        [Test]
        public void RectangleEditWidthHeight_ShouldReturnCorrectValue( )
        {
            // Arrange
            Rectangle rectangle = new Rectangle( 10, 10, 10, 40 );

            // Act
            rectangle.EditWidthHeight( 20, 40 ); 
            string shapeOutput = rectangle.WriteProperties();

            // Assert
            Assert.That( shapeOutput, Is.EqualTo( "Rectangle (10,10) width=20 height=40" ) );

            // Act
            rectangle.EditWidthHeight( 30, 40 );
            shapeOutput = rectangle.WriteProperties();

            // Assert
            Assert.That( shapeOutput, Is.EqualTo( "Rectangle (10,10) width=30 height=40" ) );

            // Act
            rectangle.Undo();
            shapeOutput = rectangle.WriteProperties();

            // Assert
            Assert.That( shapeOutput, Is.EqualTo( "Rectangle (10,10) width=20 height=40" ) );

            // Act
            rectangle.Undo();
            shapeOutput = rectangle.WriteProperties();

            // Assert
            Assert.That( shapeOutput, Is.EqualTo( "Rectangle (10,10) width=10 height=40" ) );

        }

        [Test]
        public void RectangleNegativeWidth_ShouldThrowArgumentException_WithExpectedMessage( )
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentException>( ( ) => new Rectangle( 10, 10, -30, 40 ));

            // Assert
            Assert.That( ex.Message, Is.EqualTo("Width value must not be negative.") );
        }

        [Test]
        public void RectangleNegativeHeight_ShouldThrowArgumentException_WithExpectedMessage( )
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentException>( ( ) => new Rectangle( 10, 10, 30, -40 ) );

            // Assert
            Assert.That( ex.Message, Is.EqualTo( "Height value must not be negative." ) );
        }
        #endregion

        #region Square Tests
        [Test]
        public void SquareOutput_ShouldReturnCorrectValue( )
        {
            // Arrange
            Square square = new Square( 15, 30, 35);

            // Act
            string shapeOutput = square.WriteProperties();

            // Assert
            Assert.That( shapeOutput, Is.EqualTo( "Square (15,30) size=35" ) );
        }

        [Test]
        public void SquareNegativeSize_ShouldThrowArgumentException_WithExpectedMessage( )
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentException>( ( ) => new Square( 10, 10, -10 ) );

            // Assert
            Assert.That( ex.Message, Is.EqualTo( "Size value must not be negative." ) );
        }
        #endregion

        #region Ellipse Tests
        [Test]
        public void EllipseOutput_ShouldReturnCorrectValue( )
        {
            // Arrange
            Ellipse ellipse = new Ellipse( 100, 150, 300, 200 );

            // Act
            string shapeOutput = ellipse.WriteProperties();

            // Assert
            Assert.That( shapeOutput, Is.EqualTo( "Ellipse (100,150) diameterH = 300 diameterV = 200" ) );
        }

        [Test]
        public void EllipseNegativeHorizontalDiameter_ShouldThrowArgumentException_WithExpectedMessage( )
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentException>( ( ) => new Ellipse( 100, 150, -300, 200 ) );

            // Assert
            Assert.That( ex.Message, Is.EqualTo( "Horizontal Diameter value must not be negative." ) );
        }

        [Test]
        public void EllipseNegativeVerticalDiameter_ShouldThrowArgumentException_WithExpectedMessage( )
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentException>( ( ) => new Ellipse( 100, 150, 300, -200 ) );

            // Assert
            Assert.That( ex.Message, Is.EqualTo( "Vertical Diameter value must not be negative." ) );
        }
        #endregion

        #region Circle Tests
        [Test]
        public void CircleOutput_ShouldReturnCorrectValue( )
        {
            // Arrange
            Circle circle = new Circle( 1, 1, 300 );

            // Act
            string shapeOutput = circle.WriteProperties();

            // Assert
            Assert.That( shapeOutput, Is.EqualTo( "Circle (1,1) size=300" ) );
        }

        [Test]
        public void CircleNegativeSize_ShouldThrowArgumentException_WithExpectedMessage( )
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentException>( ( ) => new Circle( 1, 1, -300 ) );

            // Assert
            Assert.That( ex.Message, Is.EqualTo( "Size value must not be negative." ) );
        }
        #endregion

        #region Textbox Tests
        [Test]
        public void TextboxOutput_ShouldReturnCorrectValue( )
        {
            // Arrange
            Textbox textbox = new Textbox( 5, 5, 200, 100, "sample text" );

            // Act
            string shapeOutput = textbox.WriteProperties();

            // Assert
            Assert.That( shapeOutput, Is.EqualTo( "Textbox (5,5) width=200 height=100 Text=\"sample text\"" ) );
        }
        #endregion
    }
}