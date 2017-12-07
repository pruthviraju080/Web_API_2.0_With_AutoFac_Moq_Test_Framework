using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Web_Service.Appliation;
using Web_Service.Appliation.Entities;
using Web_Service.API.Controllers;
using Web_Service.API.Models;
using Web_Service.Tests.TestData;

namespace Web_Service.Tests.ControllerTests
{
    [TestClass]
    public class CustomersControllerTests
    {
        private CutomersController _customerController;
        private Mock<IApplication> _application;
        private Mock<IMapper> _mapper;

        [TestInitialize]
        public void Init()
        {
            _application = new Mock<IApplication>();
            _customerController = new CutomersController(_application.Object);
            _mapper = new Mock<IMapper>();
        }

    }
}
