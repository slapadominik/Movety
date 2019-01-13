using System;
using System.Collections.Generic;
using AutoMapper;
using FluentAssertions;
using Moq;
using Movety.Domain.Entities;
using Movety.Domain.Exceptions;
using Movety.Domain.Services;
using Movety.Persistence.DAO;
using Movety.Persistence.Repositories.Interfaces;
using NUnit.Framework;
using Athlethe = Movety.Persistence.DAO.Athlethe;

namespace Movety.Domain.Tests.Services
{
    [TestFixture]
    public class TrainingProposalsAcceptanceServiceTests
    {
        private TrainingProposalsAcceptanceService _sut;
        private Mock<IUnitOfWork> _unitOfWorkMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void SetUp()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _sut = new TrainingProposalsAcceptanceService(_unitOfWorkMock.Object, _mapperMock.Object);
        }

        [Test]
        public void Add_WhenUserDoesntExist_ThrowsUserNotFoundException()
        {
            //Arrange
            Guid requesterId = Guid.NewGuid();
            TrainingProposalAcceptance trainingProposalsAcceptance = new TrainingProposalAcceptance { UserId = Guid.NewGuid(), TrainingProposalId = Guid.NewGuid()};

            _unitOfWorkMock.Setup(x => x.Athletes.Get(trainingProposalsAcceptance.UserId)).Returns((Athlethe)null).Verifiable();

            //Act
            Action get = () => _sut.Add(requesterId, trainingProposalsAcceptance);

            //Assert
            get.Should().Throw<UserNotFoundException>();
            _unitOfWorkMock.Verify();
        }

        [Test]
        public void Add_WhenTrainingProposalDoesntExist_ThrowsTrainingProposalNotFoundException()
        {
            //Arrange
            Guid requesterId = Guid.NewGuid();
            TrainingProposalAcceptance trainingProposalsAcceptance = new TrainingProposalAcceptance { UserId = Guid.NewGuid(), TrainingProposalId = Guid.NewGuid() };

            _unitOfWorkMock.Setup(x => x.Athletes.Get(trainingProposalsAcceptance.UserId)).Returns(new Athlethe()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposals.Get(trainingProposalsAcceptance.TrainingProposalId)).Returns((TrainingProposals)null).Verifiable();

            //Act
            Action add = () => _sut.Add(requesterId, trainingProposalsAcceptance);

            //Assert
            add.Should().Throw<TrainingProposalNotFoundException>();
            _unitOfWorkMock.Verify();
        }

        [Test]
        public void Add_WhenRequesterIsNotAuthorOfTrainingProposal_ThrowsAcceptanceAuthorizationException()
        {
            //Arrange
            Guid requesterId = Guid.NewGuid();
            Guid trainingProposalId = Guid.NewGuid();
            TrainingProposalAcceptance trainingProposalsAcceptance = new TrainingProposalAcceptance { UserId = Guid.NewGuid(), TrainingProposalId = trainingProposalId};

            _unitOfWorkMock.Setup(x => x.Athletes.Get(trainingProposalsAcceptance.UserId)).Returns(new Athlethe()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposals.Get(trainingProposalsAcceptance.TrainingProposalId)).Returns(new TrainingProposals{Id = trainingProposalId}).Verifiable();

            //Act
            Action add = () => _sut.Add(requesterId, trainingProposalsAcceptance);

            //Assert
            add.Should().Throw<AcceptanceAuthorizationException>();
            _unitOfWorkMock.Verify();
        }

        [Test]
        public void Add_WhenUserDidntLikeTrainingProposal_ThrowsTrainingProposalLikeNotFoundException()
        {
            //Arrange
            Guid requesterId = Guid.NewGuid();
            Guid trainingProposalId = Guid.NewGuid();
            TrainingProposalAcceptance acceptance = new TrainingProposalAcceptance { UserId = Guid.NewGuid(), TrainingProposalId = trainingProposalId };

            _unitOfWorkMock.Setup(x => x.Athletes.Get(acceptance.UserId)).Returns(new Athlethe()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposals.Get(acceptance.TrainingProposalId)).Returns(new TrainingProposals { Id = trainingProposalId, AuthorId = requesterId}).Verifiable();
            _unitOfWorkMock
                .Setup(x => x.TrainingProposalsLikes.Find(It.IsAny<Func<TrainingProposalsLikes, bool>>()))
                .Returns(new List<TrainingProposalsLikes>()).Verifiable();

            //Act
            Action add = () => _sut.Add(requesterId, acceptance);

            //Assert
            add.Should().Throw<TrainingProposalLikeNotFoundException>();
            _unitOfWorkMock.Verify();
        }

        [Test]
        public void Add_WhenTrainingProposalHasMaxParticipants_ThrowsMaxParticipantsException()
        {
            //Arrange
            Guid requesterId = Guid.NewGuid();
            Guid trainingProposalId = Guid.NewGuid();
            TrainingProposalAcceptance acceptance = new TrainingProposalAcceptance { UserId = Guid.NewGuid(), TrainingProposalId = trainingProposalId };

            _unitOfWorkMock.Setup(x => x.Athletes.Get(acceptance.UserId)).Returns(new Athlethe()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposals.Get(acceptance.TrainingProposalId)).Returns(new TrainingProposals { Id = trainingProposalId, AuthorId = requesterId, MaxParticipants = 2}).Verifiable();
            _unitOfWorkMock
                .Setup(x => x.TrainingProposalsLikes.Find(It.IsAny<Func<TrainingProposalsLikes, bool>>()))
                .Returns(new List<TrainingProposalsLikes>{new TrainingProposalsLikes(), new TrainingProposalsLikes()}).Verifiable();

            //Act
            Action add = () => _sut.Add(requesterId, acceptance);

            //Assert
            add.Should().Throw<MaxParticipantsException>();
            _unitOfWorkMock.Verify();
        }

        [Test]
        public void Add_WhenAdditionSucceed_DoesNotThrowException()
        {
            //Arrange
            Guid requesterId = Guid.NewGuid();
            Guid trainingProposalId = Guid.NewGuid();
            TrainingProposalAcceptance acceptance = new TrainingProposalAcceptance { UserId = Guid.NewGuid(), TrainingProposalId = trainingProposalId };

            _unitOfWorkMock.Setup(x => x.Athletes.Get(acceptance.UserId)).Returns(new Athlethe()).Verifiable();
            _unitOfWorkMock.Setup(x => x.TrainingProposals.Get(acceptance.TrainingProposalId)).Returns(new TrainingProposals { Id = trainingProposalId, AuthorId = requesterId, MaxParticipants = 2 }).Verifiable();
            _unitOfWorkMock
                .Setup(x => x.TrainingProposalsLikes.Find(It.IsAny<Func<TrainingProposalsLikes, bool>>()))
                .Returns(new List<TrainingProposalsLikes> { new TrainingProposalsLikes() }).Verifiable();
            _unitOfWorkMock.Setup(x => x.Acceptances.Add(It.IsAny<TrainingProposalsAcceptance>())).Verifiable();
            _unitOfWorkMock.Setup(x => x.Complete()).Returns(1);

            //Act
            Action add = () => _sut.Add(requesterId, acceptance);

            //Assert
            add.Should().NotThrow();
            _unitOfWorkMock.Verify();
        }
    }
}