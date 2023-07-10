using LogicTest.Common;

namespace LogicTest.Tests
{
    [TestClass]
    public class NetworkServiceTest
    {
        private INetworkService _service;
        public NetworkServiceTest()
        {
            _service = new NetworkService();
        }
        [TestInitialize]
        public void Init()
        {
            _service.Init(10);
            _service.Connect(1, 2);
            _service.Connect(6, 2);
            _service.Connect(2, 4);
            _service.Connect(5, 8);
        }
        [TestMethod]
        public void MustBeConnected()
        {
            Assert.IsTrue(_service.Query(1, 6));
            Assert.IsTrue(_service.Query(6, 4));
        }
        [TestMethod]
        public void MustBeDisconnected()
        {
            Assert.IsFalse(_service.Query(7, 4));
        }

    }
}