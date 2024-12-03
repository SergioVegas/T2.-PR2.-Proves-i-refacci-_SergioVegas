namespace Ex5
{
    public class LibraryValidator
    {
        [Fact]     
        public static void PersonalityTestMorning()
        {
            //Arrange
            string preference = "mati";
            int expected = 0;
            //Act
            int result = ExerciseFive.PersonaHelper.PersonalityTest(preference);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public static void PersonalityTestNight()
        {
            //Arrange
            string preference = "nit";
            int expected = 1;
            //Act
            int result = ExerciseFive.PersonaHelper.PersonalityTest(preference);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public static void PersonalityTestDefault()
        {
            //Arrange
            string preference = "migdia";
            int expected = 2;
            //Act
            int result = ExerciseFive.PersonaHelper.PersonalityTest(preference);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public static void VerifyColourNull()
        {
            //Arrange
            string colour = "";
            int expected = -1;
            //Act
            int result = ExerciseFive.PersonaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]

        //Arrange  
        [InlineData("blau")]
        [InlineData("Verd")]
        public static void VerifyColourCalm(string colour)
        {          
            int expected = 0;
            //Act
            int result = ExerciseFive.PersonaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        
        public static void VerifyColourExclusive(string colour)
        {                   
            int expected = 1;
            //Act
            int result = ExerciseFive.PersonaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]     
        public static void IsEvenTrue()
        {
            //Arrange            
            int age = 6;
            //Act
            bool result = ExerciseFive.PersonaHelper.IsEven(age);
            //Assert
            Assert.True(result);
        }
        [Fact]
        public static void IsEvenFalse()
        {
            //Arrange            
            int age = 3;
            //Act
            bool result = ExerciseFive.PersonaHelper.IsEven(age);
            //Assert
            Assert.False(result);
        }
        [Fact]
        //Arrange   
        [InlineData(17)]
        [InlineData(4)]
        public static void ClassifyAgeInfant(int age)
        {
            int expected = 0;
            //Act
            int result = ExerciseFive.PersonaHelper.ClassifyAge(age);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        //Arrange   
        [InlineData(18)]
        [InlineData(65)]
        [InlineData(50)]
        public static void ClassifyAgeAdult(int age)
        {
            int expected = 1;
            //Act
            int result = ExerciseFive.PersonaHelper.ClassifyAge(age);
            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        //Arrange   
        [InlineData(66)]
        [InlineData(78)]
        
        public static void ClassifyAgeOld (int age)
        {
            int expected = 2;
            //Act
            int result = ExerciseFive.PersonaHelper.ClassifyAge(age);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}