using System;
using AutoMapper;
using FluentAssertions;
using Moq;
using Movety.Domain.Exceptions;
using Movety.Domain.Services;
using Movety.Persistence.DAO;
using Movety.Persistence.Repositories.Interfaces;
using NUnit.Framework;

namespace Movety.Domain.Tests.Services
{
    [TestFixture]
    public class TrainingProposalsLikesServiceTests
    {
        private TrainingProposalsLikesService _sut;
        private Mock<IUnitOfWork> _unitOfWorkMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void SetUp()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _sut = new TrainingProposalsLikesService(_unitOfWorkMock.Object, _mapperMock.Object);                 
        }

        [Test]
        public void Add_WhenUserDoesntExist_ThrowsUserNotFoundException()
        {
            //Arrange
            Guid userId = Guid.NewGuid();
            Guid trainingProposalId = Guid.NewGuid();
            _unitOfWorkMock.Setup(x => x.Athletes.Get(userId)).Returns((Athlethe)null).Verifiable();

            //Act
            Action get = () => _sut.Add(userId, trainingProposalId);

            //Assert
            get.Should().Throw<UserNotFoundException>();
            _unitOfWorkMock.Verify();
        }

        [Test]
        public void Add_WhenTrainingProposalDoesntExist_ThrowsTrainingProposalNotFoundException()
        {
            //Arrange
            Guid userId = Guid.NewGuid();
            Guid trainingProposalId = Guid.NewGuid();
            _unitOfWorkMock.Setup(x => x.Athletes.Get(userId)).Returns(new Athlethe()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposals.Get(trainingProposalId)).Returns((TrainingProposals)null).Verifiable();

            //Act
            Action add = () => _sut.Add(userId, trainingProposalId);

            //Assert
            add.Should().Throw<TrainingProposalNotFoundException>();
            _unitOfWorkMock.Verify();
        }

        [Test]
        public void Add_WhenCompleteDoesNotReturn1_ThrowsInvalidOperationException()
        {
            //Arrange
            Guid userId = Guid.NewGuid();
            Guid trainingProposalId = Guid.NewGuid();
            _unitOfWorkMock.Setup(x => x.Athletes.Get(userId)).Returns(new Athlethe()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposals.Get(trainingProposalId)).Returns(new TrainingProposals()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposalsLikes.Add(It.IsAny<TrainingProposalsLikes>())).Verifiable();
            _unitOfWorkMock.Setup(x => x.Complete()).Returns(0).Verifiable();

            //Act
            Action add = () => _sut.Add(userId, trainingProposalId);

            //Assert
            add.Should().Throw<InvalidOperationException>();
            _unitOfWorkMock.Verify();
        }

        [Test]
        public void Add_WhenAdditionSucceed_DoesNotThrowException()
        {
            //Arrange
            Guid userId = Guid.NewGuid();
            Guid trainingProposalId = Guid.NewGuid();
            _unitOfWorkMock.Setup(x => x.Athletes.Get(userId)).Returns(new Athlethe()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposals.Get(trainingProposalId)).Returns(new TrainingProposals()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposalsLikes.Add(It.IsAny<TrainingProposalsLikes>())).Verifiable();
            _unitOfWorkMock.Setup(x => x.Complete()).Returns(1).Verifiable();

            //Act
            Action add = () => _sut.Add(userId, trainingProposalId);

            //Assert
            add.Should().NotThrow();
            _unitOfWorkMock.Verify();
        }

    }
}