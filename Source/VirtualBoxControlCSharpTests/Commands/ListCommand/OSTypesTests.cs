using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using NUnit.Framework;
using Rhino.Mocks;
using VirtualBoxControlCSharp.Commands.ListCommand;
using VirtualBoxControlCSharp.Configuration;
using OperatingSystem = VirtualBoxControlCSharp.Types.OperatingSystem;

namespace VirtualBoxControlCSharpTests.Commands.ListCommand
{
    [TestFixture]
    public class OSTypesTests : BaseTest
    {
        private IConfigurationManager _configurationManager;
        private IConfigurationStorage _configurationStorage;
        private OSTypes _osTypes;

        [SetUp]
        public void SetUp()
        {
            _configurationManager = MockRepository.GenerateMock<IConfigurationManager>();
            _configurationStorage = MockRepository.GenerateMock<IConfigurationStorage>();

            _configurationStorage.Stub(x => x.VirtualBoxInstallLocation).Return(VirtualBoxPath);
            _configurationManager.Stub(x => x.Configuration).Return(_configurationStorage);

            _osTypes = MockRepository.GeneratePartialMock<OSTypes>();
            _osTypes.ConfigurationManager = _configurationManager;
        }

        [Test]
        public void ExecuteCallsExecuteCommandCorrectly()
        {
            const string osTypesCommand = "VBoxManage list ostypes";

            _osTypes.Stub(x => x.ExecuteCommand(Arg<String>.Is.Anything)).Return(null);

            _osTypes.Execute();

            var result = _osTypes.GetArgumentsForCallsMadeOn(x => x.ExecuteCommand(Arg<String>.Is.Anything));

            Assert.AreEqual(osTypesCommand, result[0][0]);
        }

        [Test]
        public void ExecuteReturnsCorrectAmmountOfOperatingSystems()
        {
            string executeCommandReturn =
            @"  ID:          L4
                Description: L4
                Family ID:   Other
                Family Desc: Other
                64 bit:      false
                    
                ID:          QNX
                Description: QNX
                Family ID:   Other
                Family Desc: Other
                64 bit:      false
                
                ID:          JRockitVE
                Description: JRockitVE
                Family ID:   Other
                Family Desc: Other
                64 bit:      false";

            _osTypes.Stub(x => x.ExecuteCommand(Arg<String>.Is.Anything)).Return(executeCommandReturn);

            var result = _osTypes.Execute();

            Assert.AreEqual(3, result.Count);
        }
    }
}
