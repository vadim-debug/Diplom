using Diplom;
namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string Data1, Data2;
            int Data3, Data4, Data5, expected = 1;
            Data1 = "sdsdsdsd";
            Data2 = "26.08.2003";
            Data3 = 1;
            Data4 = 2;
            Data5 = 3;
            Data data = new Data();
            int actual = data.CheckData(Data1,Data2,Data3,Data4,Data5);
            Assert.Equal(expected, actual);
        }
    }
}