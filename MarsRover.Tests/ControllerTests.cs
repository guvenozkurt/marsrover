using MarsRover.Controllers;
using MarsRover.CustomExceptions;
using Xunit;

namespace MarsRover.Tests
{
    public class ControllerTests
    {
        private const string Input = @"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";

        private const string Output = @"1 3 N
5 1 E";

        [Fact]
        public void When_Invoke_Rover_ShouldBe_Output()
        {
            IController controller = new MarsController();
            controller.GetCommands(Input);
            controller.InvokeCommands();
            var a = controller.Plateau._rovers;
            Assert.Equal(Output, controller.Plateau._rovers[0].ToString() + "\n" + controller.Plateau._rovers[1].ToString());
        }
    }
}
