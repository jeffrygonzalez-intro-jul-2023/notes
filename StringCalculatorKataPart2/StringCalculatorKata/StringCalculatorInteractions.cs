
using Castle.Core.Logging;

namespace StringCalculatorKata;

public class StringCalculatorInteractions
{

    [Theory]
    [InlineData("15", "15")]
    [InlineData("1,2", "3")]
    public void ResultsAreLogged(string numbers, string expectedToBeLogged)
    {
        // given
        var loggerMock = new Mock<ILogger>();
        var mockedWebService =  new Mock<IWebService>();
        var calculator = new StringCalculator(loggerMock.Object,mockedWebService.Object);

        // when
        calculator.Add(numbers);

        // then
        // hey logger, did you get called with "15"
        loggerMock.Verify(logger => logger.Log(expectedToBeLogged));
        mockedWebService.Verify(ws => ws.NotifyOfLoggerFailure(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void WebServiceIsCalledOnLoggerFailure()
    {
        // Given
        var loggerStub = new Mock<ILogger>();
        var mockedWebService = new Mock<IWebService>();
        var calculator = new StringCalculator(loggerStub.Object, mockedWebService.Object);
        loggerStub.Setup(m => m.Log(It.IsAny<string>()))
            .Throws<CalculatorLoggerException>();

        // When
        calculator.Add("1");

        // Then
        mockedWebService.Verify(m => m.NotifyOfLoggerFailure("Blammo!"), Times.Once);
    }


}
